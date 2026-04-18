using NovelProject.Models;
using NovelProject.Navigation;
using NovelProject.NovelPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NovelProject.AuthorPage
{
    public partial class AuthorView : UserControl, INavigatable
    {
        private string _author;
        private List<Novel> _novels;

        public AuthorView()
        {
            InitializeComponent();
            _author = EnvironmentVars.username;
            _novels = AuthorController.GetNovelsByAuthor(_author);
            SetupListView();
            AddNovels();
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }

        private void SetupListView()
        {
            uxNovelList.View = View.Details;
            uxNovelList.FullRowSelect = true;

            uxNovelList.Columns.Add("Title", 100);
            uxNovelList.Columns.Add("Author", 50);
            uxNovelList.Columns.Add("Description", 75);
            uxNovelList.Columns.Add("Date Added", 50);
        }

        private void AddNovels() 
        {
            uxNovelList.Items.Clear();

            foreach (var novel in _novels)
            {
                var item = new ListViewItem(novel.NovelName);

                item.SubItems.Add(novel.AuthorName);
                item.SubItems.Add(novel.Description);
                item.SubItems.Add(novel.DatePosted.ToShortDateString());

                item.Tag = novel; // for later retrieval

                uxNovelList.Items.Add(item);
            }
        }

        private void AddNewButtonClick(object sender, EventArgs e)
        {

            _navigate(new NovelEditPage.NovelEditView());
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            if (uxNovelList.SelectedItems.Count > 0)
            {
                Novel selectedNovel = (Novel )uxNovelList.SelectedItems[0].Tag;

                _navigate(new NovelEditPage.NovelEditView(selectedNovel));
            }
        }

        private void ReadButtonClick(object sender, EventArgs e)
        {
            if (uxNovelList.SelectedItems.Count > 0)
            {
                Novel selectedNovel = (Novel)uxNovelList.SelectedItems[0].Tag;

                _navigate(new NovelView(selectedNovel));
            }
        }
    }
}
