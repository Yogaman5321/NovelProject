using Microsoft.Data.SqlClient;
using NovelProject.AuthorPage;
using NovelProject.ChapterPage;
using NovelProject.Models;
using NovelProject.Navigation;
using NovelProject.ReviewControl;
using NovelProject.UserPage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NovelProject.NovelPage
{
    public partial class NovelView : UserControl, INavigatable
    {
        public NovelPageHandler handler;
        private Action<UserControl> _navigate;
        public Novel _novel;

        public NovelView(Novel novel)
        {
            InitializeComponent();
            _novel = novel;
            SetupListView();
            PopulateNovelInfo();
            this.Load += LoadChapters;

            if (EnvironmentVars.IsLoggedIn == true)
            {
                var reviewView = new ReviewView(_novel);
                var reviewController = new ReviewController(reviewView.DisplayState);
                reviewView.SetHandler(reviewController.HandleEvents);

                reviewView.Show();
                reviewsPanel.Controls.Add(reviewView);
            }
        }

        
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }

        public void SetNovelHandler(NovelPageHandler handler)
        {
            this.handler = handler;
        }

        public void DisplayState(NovelPageState s, List<Chapter> chapters)
        {
            switch (s)
            {
                case NovelPageState.GotChapters:
                    PopulateChapters(chapters);
                    break;
                case NovelPageState.GotError:
                    throw new Exception("Could not load chapters.");
                default:
                    break;
            }
        }

        private void LoadChapters(object sender, EventArgs e)
        {
            handler(NovelPageState.SetupPage, _novel);
        }

        public void PopulateNovelInfo()
        {
            uxTitleLabel.Text = _novel.NovelName;
            uxAuthorLink.Text = _novel.AuthorName;
            uxDescriptionBox.Text = _novel.Description;
        }

        private void SetupListView()
        {
            uxChapterList.View = View.Details;
            uxChapterList.FullRowSelect = true;

            uxChapterList.Columns.Add("Chapter Number", 50);
            uxChapterList.Columns.Add("Chapter Title", 200);
            uxChapterList.Columns.Add("Date Added", 100);
        }

        private void PopulateChapters(List<Chapter> chapters)
        {
            uxChapterList.Items.Clear();

            foreach (var chapter in chapters)
            {
                var item = new ListViewItem(chapter.ChapterNumber.ToString());

                item.SubItems.Add(chapter.ChapterName);
                item.SubItems.Add(chapter.DateAdded.ToString());

                item.Tag = chapter;

                uxChapterList.Items.Add(item);
            }
        }

        private void AuthorLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = DatabaseHelper.ExecuteScalar<string>(
                @"SELECT u.Username
                  FROM Novels n
                  JOIN Users u ON n.UploadedByUserId = u.UserId
                  WHERE n.NovelId = @NovelId",
                new SqlParameter("@NovelId", _novel.NovelId)
            );

            if (!string.IsNullOrEmpty(username))
            {
                var view = new UserView(username);
                var controller = new UserController(view.DisplayState);
                view.SetUserHandler(controller.HandleEvents);
                _navigate?.Invoke(view);
            }
        }

        private void ReadButtonClick(object sender, EventArgs e)
        {
            if (uxChapterList.SelectedItems.Count > 0)
            {
                Chapter selectedChapter = (Chapter)uxChapterList.SelectedItems[0].Tag;
                var view = new ChapterView(_novel, selectedChapter.ChapterNumber);
                var controller = new ChapterController(view.DisplayState, _novel.NovelId.ToString());
                view.SetChapterHandler(controller.HandleEvents);
                view.SetMaxChapters(controller.MaxChapters);
                _navigate?.Invoke(view);
            }
        }
    }
}
