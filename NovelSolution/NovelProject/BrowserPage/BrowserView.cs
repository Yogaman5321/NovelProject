using NovelProject.Models;
using NovelProject.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using NovelProject.NovelPage;

namespace NovelProject.BrowserPage
{
    public partial class BrowserView : UserControl, INavigatable
    {
        public BrowserHandler handler;
        private string _currentUsername;

        public BrowserView(string username)
        {
            InitializeComponent();
            DatabaseHelper.CleanNovels();

            uxRadio1.Checked = true;
            _currentUsername = username;
            uxSearchButton.Click += SearchButtonClick;
            resultsPanel.Padding = Padding.Empty;
            resultsPanel.SizeChanged += ResultsPanel_SizeChanged;

            GetTagBox();
            GetOtherFiltersBox();
            this.Load += GetInitialNovels;
        }

        public void DisplayState(BrowserState s, List<Novel> novels)
        {
            switch (s)
            {
                case BrowserState.GotNovels:
                    DisplayResults(novels);
                    break;
                case BrowserState.GotError:
                    // Replace this later
                    throw new Exception("Could not get novels.");
                default:
                    break;
            }
        }

        private void DisplayResults(List<Novel> novels)
        {
            resultsPanel.Controls.Clear();

            int cardWidth = resultsPanel.Width - SystemInformation.VerticalScrollBarWidth;

            foreach (var novel in novels)
            {
                var card = new NovelDisplayCard();
                card.Populate(novel);
                card.SetNavigator(_navigate);
                card.Width = cardWidth;

                EventHandler navigateToNovel = (s, e) =>
                {
                    var view = new NovelView(novel);
                    var controller = new NovelController(view.DisplayState);
                    view.SetNovelHandler(controller.HandleEvents);
                    _navigate?.Invoke(view);
                };

                card.DoubleClick += navigateToNovel;

                // Propagate double-click from child controls on the card
                foreach (Control child in card.Controls)
                {
                    child.DoubleClick += navigateToNovel;
                }

                resultsPanel.Controls.Add(card);
            }
        }

        private void ResultsPanel_SizeChanged(object sender, EventArgs e)
        {
            int cardWidth = resultsPanel.Width - SystemInformation.VerticalScrollBarWidth;
            foreach (Control control in resultsPanel.Controls)
            {
                control.Width = cardWidth;
            }
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            string query = BuildSearchQuery(out var parameters);
            handler(BrowserState.GetFilteredNovels, query, parameters);
        }

        private string BuildSearchQuery(out List<SqlParameter> parameters)
        {
            var sb = new StringBuilder();
            parameters = new List<SqlParameter>();

            bool filterByTag = tagBox.SelectedIndex > 0; // 0 is "No Filter"
            if (filterByTag)
            {
                sb.Append("SELECT n.* FROM Novels n ");
                sb.Append("INNER JOIN NovelTags nt ON n.NovelId = nt.NovelId ");
                sb.Append("INNER JOIN Tags t ON nt.TagId = t.TagId ");
            }
            else
            {
                sb.Append("SELECT * FROM Novels n ");
            }

            // Build WHERE clauses
            List<string> whereClauses = new();

            string searchText = uxSearchBar.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                if (uxRadio1.Checked) // Title
                {
                    whereClauses.Add("n.NovelName LIKE @searchText + '%'");
                }
                else if (uxRadio2.Checked) // Author
                {
                    whereClauses.Add("n.AuthorName LIKE @searchText + '%'");
                }
                parameters.Add(new SqlParameter("@searchText", searchText));
            }

            if (filterByTag)
            {
                whereClauses.Add("t.TagName = @tagName");
                parameters.Add(new SqlParameter("@tagName", tagBox.SelectedItem.ToString()));
            }

            if (whereClauses.Count > 0)
            {
                sb.Append("WHERE ");
                sb.Append(string.Join(" AND ", whereClauses));
            }

            switch (otherFilterBox.SelectedItem.ToString())
            {
                case "Best Rated":
                    sb.Append(" ORDER BY (SELECT AVG(CAST(Rating AS FLOAT)) FROM Reviews r WHERE r.NovelId = n.NovelId) DESC");
                    break;
                case "Popular":
                    sb.Append(" ORDER BY (SELECT COUNT(*) FROM Reviews r WHERE r.NovelId = n.NovelId) DESC");
                    break;
                case "Newest":
                    sb.Append(" ORDER BY n.DatePosted DESC");
                    break;
                case "Recommended":
                    // I'll go back and implement this once we have the ReadingHistory implemented.
                    throw new NotImplementedException("Recommended filter not implemented yet.");
                case "Random":
                    sb.Append(" ORDER BY NEWID()");
                    break;
                default:
                    break;
            }

            return sb.ToString();
        }

        private void GetInitialNovels(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Novels";
            handler(BrowserState.GetAllNovels, query, null);
        }

        private void GetTagBox()
        {
            tagBox.Items.Clear();
            tagBox.Items.Add("No Filter");
            tagBox.SelectedIndex = 0;
            using (var reader = DatabaseHelper.ExecuteReader("SELECT TagName FROM Tags"))
            {
                while (reader.Read())
                {
                    tagBox.Items.Add(reader.GetString(0));
                }
            }
        }

        private void GetOtherFiltersBox()
        {
            otherFilterBox.Items.Clear();
            otherFilterBox.Items.Add("No Filter");
            otherFilterBox.Items.Add("Best Rated");
            otherFilterBox.Items.Add("Popular");
            otherFilterBox.Items.Add("Newest");
            otherFilterBox.Items.Add("Recommended");
            otherFilterBox.Items.Add("Random");
            otherFilterBox.SelectedIndex = 0;
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;

            foreach (Control control in resultsPanel.Controls)
            {
                if (control is NovelDisplayCard card)
                {
                    card.SetNavigator(_navigate);
                }
            }
        }

        public void SetHandler(BrowserHandler handler)
        {
            this.handler = handler;
        }
    }
}