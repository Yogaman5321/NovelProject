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

namespace NovelProject.BrowserPage
{
    public partial class BrowserView : UserControl, INavigatable
    {
        public BrowserHandler handler;

        public BrowserView()
        {
            InitializeComponent();
            SetupListView();
            uxRadio1.Checked = true;

            browserListView.DoubleClick += ListViewDoubleClick;            
            uxSearchButton.Click += SearchButtonClick;

            GetTagBox();
            GetOtherFiltersBox();
            this.Load += GetAllNovels;

        }

        public void DisplayState(BrowserState s, List<Novel> novels)
        {
            switch (s)
            {
                case BrowserState.GotNovels:
                    DisplayResults(novels);
                    break;
                case BrowserState.GotError:
                    break;
                default:
                    break;
            }
        }       



        private void SetupListView()
        {
            browserListView.View = View.Details;
            browserListView.FullRowSelect = true;

            browserListView.Columns.Add("Title", 150);
            browserListView.Columns.Add("Author", 100);
        }

        private void DisplayResults(List<Novel> novels)
        {
            browserListView.Items.Clear();

            foreach (var novel in novels)
            {
                var item = new ListViewItem(novel.NovelName);
                item.SubItems.Add(novel.AuthorName);

                browserListView.Items.Add(item);
            }
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            string search = BuildSearchQuery();

            handler(BrowserState.GetFilteredNovels, search);
        }


        
        private string BuildSearchQuery()
        {
            // Will get back to this later, it's probably going to be complicated.
            return "";
        }

        private void GetAllNovels(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Novels";
            handler(BrowserState.GetAllNovels, query);
        }

        private void GetTagBox()
        {
            tagBox.Items.Clear();
            tagBox.Items.Add("No Filter");
            tagBox.SelectedIndex = 0;
            using(var reader = DatabaseHelper.ExecuteReader("SELECT TagName FROM Tags"))
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

        private void ListViewDoubleClick(object sender, EventArgs e)
        {
            if (browserListView.SelectedItems.Count == 0)
            {
                return;
            }

            string title = browserListView.SelectedItems[0].Text;
            string author = browserListView.SelectedItems[0].SubItems[1].Text;

            _navigate?.Invoke(new NovelPage.NovelView(title));
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }


        public void SetHandler(BrowserHandler handler)
        {
            this.handler = handler;
        }
    }
}