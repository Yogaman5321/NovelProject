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
using System.Diagnostics;

namespace NovelProject.BrowserPage
{
    public partial class BrowserView : UserControl, INavigatable
    {
        public BrowserHandler handler;
        private string _currentUsername;

        private int _pageSize = 10;
        private int _currentPage = 0;
        private bool _isLoading = false;
        string currentQuery = "";
        List<SqlParameter> currentParameters;

        public BrowserView(string username)
        {
            InitializeComponent();

            uxRadio1.Checked = true;
            _currentUsername = username;
            uxSearchButton.Click += SearchButtonClick;
            resultsPanel.Padding = Padding.Empty;
            resultsPanel.SizeChanged += ResultsPanel_SizeChanged;
            resultsPanel.Scroll += ResultsPanel_Scroll;
            resultsPanel.MouseWheel += ResultsPanel_MouseWheel;
            resultsPanel.ControlAdded += (s, e) => CheckLoadMore();
            resultsPanel.Resize += (s, e) => CheckLoadMore();

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
            resultsPanel.SuspendLayout();

            if (_currentPage == 0)
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

            resultsPanel.ResumeLayout();
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
            _currentPage = 0;

            resultsPanel.AutoScrollPosition = new Point(0, 0);
            resultsPanel.VerticalScroll.Value = 0;

            string query = BuildSearchQuery(out var parameters);
            handler(BrowserState.GetFilteredNovels, query, parameters);
        }

        private string BuildSearchQuery(out List<SqlParameter> parameters)
        {
            var sb = new StringBuilder();
            parameters = new List<SqlParameter>();

            bool filterByTag = tagBox.SelectedIndex > 0;
            string sortOption = otherFilterBox.SelectedItem.ToString();
            bool needsStats = sortOption == "Best Rated" || sortOption == "Popular";
            bool needsViewCount = sortOption == "View Count";

            // Building this early since it's a much more complex query that wouldn't fit with any of the logic below.
            if (sortOption == "Recommended")
            {
                parameters.Add(new SqlParameter("@username", _currentUsername));

                sb.Append(@"
                    WITH UserReadNovels AS (
                        SELECT DISTINCT c.NovelId
                        FROM ReadHistories rh
                        INNER JOIN Chapters c ON rh.ChapterId = c.ChapterId
                        INNER JOIN Users u ON rh.UserId = u.UserId
                        WHERE u.Username = @username
                    ),
                    TopTags AS (
                        SELECT TOP 5 nt.TagId
                        FROM NovelTags nt
                        INNER JOIN UserReadNovels urn ON nt.NovelId = urn.NovelId
                        GROUP BY nt.TagId
                        ORDER BY COUNT(*) DESC
                    ),
                    Recommended AS (
                        SELECT DISTINCT n.*
                        FROM Novels n
                        INNER JOIN NovelTags nt ON n.NovelId = nt.NovelId
                        INNER JOIN TopTags tt ON nt.TagId = tt.TagId
                        WHERE n.NovelId NOT IN (SELECT NovelId FROM UserReadNovels)
                    )
                    SELECT * FROM Recommended
                    ORDER BY NEWID()");

                return sb.ToString();
            }

            // Prepend stats CTE only when needed for ORDER BY
            if (needsStats)
            {
                sb.Append(@"WITH NovelStats AS (
                SELECT NovelId,
                    AVG(CAST(Rating AS FLOAT)) AS AvgRating,
                    COUNT(ReviewId) AS ReviewCount
                FROM Reviews
                GROUP BY NovelId
                ) ");
            }

            if (needsViewCount)
            {
                sb.Append(@"WITH NovelViewCounts AS (
                SELECT c.NovelId,
                    COUNT(*) AS ViewCount
                FROM ReadHistories rh
                INNER JOIN Chapters c ON rh.ChapterId = c.ChapterId
                GROUP BY c.NovelId
                ) ");
            }

            if (filterByTag)
            {
                sb.Append("SELECT n.* FROM Novels n ");
                sb.Append("INNER JOIN NovelTags nt ON n.NovelId = nt.NovelId ");
                sb.Append("INNER JOIN Tags t ON nt.TagId = t.TagId ");
            }
            else
            {
                sb.Append("SELECT n.* FROM Novels n ");
            }

            if (needsStats)
                sb.Append("LEFT JOIN NovelStats ns ON n.NovelId = ns.NovelId ");

            if (needsViewCount)
                sb.Append("LEFT JOIN NovelViewCounts nvc ON n.NovelId = nvc.NovelId ");

            List<string> whereClauses = new();

            string searchText = uxSearchBar.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                if (uxRadio1.Checked) // Title
                    whereClauses.Add("n.NovelName LIKE @searchText + '%'");
                else if (uxRadio2.Checked)
                { // Author
                    whereClauses.Add(@"
                    (
                        n.AuthorName LIKE @searchText + '%'
                        OR
                        SUBSTRING(n.AuthorName, 1, CHARINDEX(' ', n.AuthorName + ' ') - 1)
                            LIKE @searchText + '%'
                        OR
                        SUBSTRING(n.AuthorName,
                            CHARINDEX(' ', n.AuthorName + ' ') + 1,
                            LEN(n.AuthorName)
                        ) LIKE @searchText + '%'
                    )");
                }

                parameters.Add(new SqlParameter("@searchText", searchText));
            }

            if (filterByTag)
            {
                whereClauses.Add("t.TagName = @tagName");
                string selectedItem = tagBox.SelectedItem.ToString();
                string tagName = selectedItem[..selectedItem.LastIndexOf(" (")].Trim();
                parameters.Add(new SqlParameter("@tagName", tagName));
            }

            if (whereClauses.Count > 0)
            {
                sb.Append("WHERE ");
                sb.Append(string.Join(" AND ", whereClauses));
            }

            bool hasOrderBy = false;
            switch (sortOption)
            {
                case "Best Rated":
                    sb.Append(" ORDER BY ISNULL(ns.AvgRating, 0) DESC");
                    hasOrderBy = true;
                    break;

                case "Popular":
                    sb.Append(" ORDER BY ISNULL(ns.ReviewCount, 0) DESC");
                    hasOrderBy = true;
                    break;

                case "Newest":
                    sb.Append(" ORDER BY n.DatePosted DESC");
                    hasOrderBy = true;
                    break;

                case "View Count":
                    sb.Append(" ORDER BY ISNULL(nvc.ViewCount, 0) DESC");
                    hasOrderBy = true;
                    break;

                case "Random":
                    sb.Append(" ORDER BY NEWID()");
                    hasOrderBy = true;
                    break;
            }

            if (!hasOrderBy)
            {
                sb.Append(" ORDER BY n.DatePosted DESC ");
            }

            sb.Append(" OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY;");

            currentQuery = sb.ToString();
            currentParameters = parameters;

            currentParameters.Add(new SqlParameter("@offset", _currentPage * _pageSize));
            currentParameters.Add(new SqlParameter("@pageSize", _pageSize));

            return sb.ToString();
        }

        private void GetInitialNovels(object sender, EventArgs e)
        {
            _currentPage = 0;
            currentQuery = @"
                SELECT *
                FROM Novels
                ORDER BY DatePosted DESC
                OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY;";
            currentParameters = new List<SqlParameter>();
            currentParameters.Add(new SqlParameter("@offset", _currentPage * _pageSize));
            currentParameters.Add(new SqlParameter("@pageSize", _pageSize));

            LoadNextPage();
        }

        private void LoadNextPage()
        {
            if (_isLoading) return;
            _isLoading = true;

            var parameters = new List<SqlParameter>();

            // copy base params (WITHOUT modifying original)
            foreach (var p in currentParameters)
            {
                if (p.ParameterName != "@offset" && p.ParameterName != "@pageSize")
                    parameters.Add(new SqlParameter(p.ParameterName, p.Value));
            }

            parameters.Add(new SqlParameter("@offset", _currentPage * _pageSize));
            parameters.Add(new SqlParameter("@pageSize", _pageSize));

            Debug.WriteLine(currentQuery);
            foreach (var param in parameters)
                Debug.WriteLine($"{param.ParameterName}: {param.Value}");

            handler(BrowserState.GetAllNovels, currentQuery, parameters);

            _currentPage++;
            _isLoading = false;
        }

        private void GetTagBox()
        {
            tagBox.Items.Clear();
            tagBox.Items.Add("No Filter");
            tagBox.SelectedIndex = 0;


            using (var reader = DatabaseHelper.ExecuteReader(
                @"SELECT t.TagName, COUNT(nt.NovelId) AS NovelCount
                  FROM Tags t
                  LEFT JOIN NovelTags nt ON t.TagId = nt.TagId
                  GROUP BY t.TagName
                  ORDER BY NovelCount DESC"))
            {
                while (reader.Read())
                {
                    tagBox.Items.Add($"{reader.GetString(0)} ({reader.GetInt32(1)})");
                }
            }
        }

        private void GetOtherFiltersBox()
        {
            otherFilterBox.Items.Clear();
            otherFilterBox.Items.Add("No Filter");
            otherFilterBox.Items.Add("Best Rated");
            otherFilterBox.Items.Add("Popular");
            otherFilterBox.Items.Add("View Count");
            otherFilterBox.Items.Add("Newest");
            otherFilterBox.Items.Add("Recommended");
            otherFilterBox.Items.Add("Random");
            otherFilterBox.SelectedIndex = 0;
        }

        private void ResultsPanel_Scroll(object sender, ScrollEventArgs e)
        {
            if (resultsPanel.VerticalScroll.Value + resultsPanel.Height >= resultsPanel.VerticalScroll.Maximum - 100)
            {
                LoadNextPage();
            }
        }

        private void CheckLoadMore()
        {
            if (_isLoading) return;

            var visibleBottom = resultsPanel.DisplayRectangle.Bottom;
            var currentBottom = resultsPanel.AutoScrollPosition.Y * -1 + resultsPanel.Height;

            if (currentBottom >= visibleBottom - 200)
            {
                LoadNextPage();
            }
        }

        private void ResultsPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            CheckLoadMore();
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