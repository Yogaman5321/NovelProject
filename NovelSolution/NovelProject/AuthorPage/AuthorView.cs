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
using NovelProject.Models;

namespace NovelProject.AuthorPage
{
    public partial class AuthorView : UserControl, INavigatable
    {
        public AuthorHandler handler;
        private string _author;
        private List<Novel> _novels;
        private Action<UserControl> _navigate;

        public AuthorView()
        {
            InitializeComponent();
            _author = EnvironmentVars.username;
            SetupListView();
            this.Load += LoadNovels;
        }

        
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }

        public void SetAuthorHandler(AuthorHandler handler)
        {
            this.handler = handler;
        }

        public void DisplayState(AuthorState s, List<Novel> novels)
        {
            switch (s)
            {
                case AuthorState.GotNovels:
                    _novels = novels;
                    AddNovels();
                    break;
                case AuthorState.GotError:
                    // Replace this later
                    throw new Exception("Could not get novels.");
                default:
                    break;
            }
        }

        private void LoadNovels(object sender, EventArgs e)
        {
            handler(AuthorState.GetNovels, _author, null);
        }

        private void SetupListView()
        {
            uxNovelList.View = View.Details;
            uxNovelList.FullRowSelect = true;

            uxNovelList.Columns.Add("Title", 150);
            uxNovelList.Columns.Add("Author", 100);
            uxNovelList.Columns.Add("Description", 150);
            uxNovelList.Columns.Add("Date Added", 100);
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
            var view = new NovelEditPage.NovelEditView();
            var controller = new NovelEditPage.NovelEditController(view.DisplayState);
            view.SetNovelEditHandler(controller.HandleEvents);
            _navigate(view);
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            if (uxNovelList.SelectedItems.Count > 0)
            {
                Novel selectedNovel = (Novel)uxNovelList.SelectedItems[0].Tag;
                var view = new NovelEditPage.NovelEditView(selectedNovel);
                var controller = new NovelEditPage.NovelEditController(view.DisplayState);
                view.SetNovelEditHandler(controller.HandleEvents);
                _navigate(view);
            }
        }

        private void ReadButtonClick(object sender, EventArgs e)
        {
            if (uxNovelList.SelectedItems.Count > 0)
            {
                Novel selectedNovel = (Novel)uxNovelList.SelectedItems[0].Tag;
                var view = new NovelPage.NovelView(selectedNovel);
                var controller = new NovelPage.NovelController(view.DisplayState);
                view.SetNovelHandler(controller.HandleEvents);
                _navigate(view);
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (uxNovelList.SelectedItems.Count > 0)
            {
                Novel selectedNovel = (Novel)uxNovelList.SelectedItems[0].Tag;

                var result = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Confirm Delete",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    handler(AuthorState.DeleteNovel, null, selectedNovel);
                }
            }
        }

    }
}
