using NovelProject.AuthorPage;
using NovelProject.ChapterPage;
using NovelProject.Models;
using NovelProject.Navigation;
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

        private NovelController _controller;

        Novel _novel;
        public NovelView(Novel novel)
        {
            InitializeComponent();
            _novel = novel;
            SetController(new NovelController(novel));
            SetupListView();
            PopulateNovelInfo();
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }

        public void SetController(NovelController controller)
        {
            _controller = controller;

            _controller.OnChaptersLoaded += PopulateChapters;

            _controller.SetUpPage();
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

                item.Tag = chapter; // for later retrieval

                uxChapterList.Items.Add(item);
            }
        }


        private void AuthorLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //_navigate?.Invoke();
        }

        private void ReadButtonClick(object sender, EventArgs e)
        {

            if (uxChapterList.SelectedItems.Count > 0)
            {
                Chapter selectedChapter = (Chapter)uxChapterList.SelectedItems[0].Tag;
                _navigate?.Invoke(new ChapterView(_novel, selectedChapter.ChapterNumber));
            }
        }

    }
}
