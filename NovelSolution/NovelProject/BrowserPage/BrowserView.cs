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
public enum BrowserState
{
    Default,
    Popular,
    New, 
    Random,
    HigestRating,
    TagChanged, 
    Recommended
    
}
namespace NovelProject.BrowserPage
{
    public partial class BrowserView : UserControl, INavigatable
    {
        private BrowserController _controller;

        public BrowserView()
        {
            InitializeComponent();
            _controller = new BrowserController();
            SetupListView();

            uxListView.DoubleClick += ListViewDoubleClick;
        }
        private void SetupListView()
        {
            uxListView.View = View.Details;
            uxListView.FullRowSelect = true;

            uxListView.Columns.Add("Title", 150);
            uxListView.Columns.Add("Author", 100);
        }

        private string GetSelectedSearchType()
        {
            if (uxRadio1.Checked) return "Title";
            if (uxRadio2.Checked) return "Author";
            if (uxRadio3.Checked) return "Tag";

            return "Title"; // default
        }

        private void DisplayResults(List<Novel> novels)
        {
            uxListView.Items.Clear();

            foreach (var novel in novels)
            {
                var item = new ListViewItem(novel.NovelName);
                item.SubItems.Add(novel.AuthorName);

                uxListView.Items.Add(item);
            }
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            string search = uxSerachBar.Text;
            string type = GetSelectedSearchType();

            List<Novel> results = _controller.Search(search, type);
            DisplayResults(results);
        }

        //private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (FilterComboBox.SelectedItem.ToString())
        //    {
        //        case "Most Read":
        //            handler(BrowserState.Popular);
        //            break;
        //        case "Newest Releases":
        //            handler(BrowserState.New);
        //            break;
        //        case "Random Display":
        //            handler(BrowserState.Random);
        //            break;
        //        case "Highest Rating":
        //            handler(BrowserState.HigestRating);
        //            break;
        //        case "Recommended For You":
        //            handler(BrowserState.Recommended);
        //            break;
        //    }
        //}

        private void ListViewDoubleClick(object sender, EventArgs e)
        {
            if (uxListView.SelectedItems.Count == 0)
            {
                return;
            }

            string title = uxListView.SelectedItems[0].Text;
            string author = uxListView.SelectedItems[0].SubItems[1].Text;

            _navigate?.Invoke(new NovelPage.NovelView(title));
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }
    }
}