using NovelProject.AuthorPage;
using NovelProject.ChapterPage;
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

        public NovelView(string novelTitle)
        {
            InitializeComponent();
            SetController(new NovelController(novelTitle));
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }

        public void SetController(NovelController controller)
        {
            _controller = controller;

            _controller.OnNovelInfoLoaded += PopulateNovelInfo;
            _controller.OnChaptersLoaded += PopulateChapters;

            _controller.SetUpPage();
        }

        private string _novelTitle;
        private string _author;
        public void PopulateNovelInfo(string title, string author, string description)
        {
            uxTitleLabel.Text = title;
                _novelTitle = title;
            uxAuthorLink.Text = author;
                _author = author;
            uxDescriptionBox.Text = description;
        }

        private void PopulateChapters(List<string> chapterTitles)
        {
            uxChapterList.Items.Clear();

            foreach (var chapter in chapterTitles)
            {
                uxChapterList.Items.Add(chapter);
            }
        }


        private void AuthorLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _navigate?.Invoke(new AuthorView(_author));
        }

        private void ReadButtonClick(object sender, EventArgs e)
        {

            if (uxChapterList.SelectedIndex < 0)
                return;

            int chapterNumber = uxChapterList.SelectedIndex;

            _navigate?.Invoke(new ChapterView(_novelTitle, chapterNumber));
        }

    }
}
