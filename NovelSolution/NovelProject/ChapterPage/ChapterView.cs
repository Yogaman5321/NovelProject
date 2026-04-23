using NovelProject.CommentPage;
using NovelProject.Models;
using NovelProject.Navigation;
using NovelProject.NovelPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject.ChapterPage
{
    public partial class ChapterView : UserControl, INavigatable
    {
        public ChapterHandler handler;

        private Novel _novel;
        private int _initialChapter;
        private int _currentChapter;
        private int _maxChapters;
        private Action<UserControl> _navigate;

        public ChapterView(Novel novel, int chapter)
        {
            InitializeComponent();
            _novel = novel;
            _initialChapter = chapter;
            _currentChapter = chapter;
            this.Load += LoadChapter;
        }

        
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }

        public void SetChapterHandler(ChapterHandler handler)
        {
            this.handler = handler;
        }

        public void SetMaxChapters(int maxChapters)
        {
            _maxChapters = maxChapters;
        }

        public void DisplayState(ChapterState s, string text, int currentChapter)
        {
            switch (s)
            {
                case ChapterState.GotChapter:
                    _currentChapter = currentChapter;
                    uxTextBox.Text = text;
                    uxChapterLabel.Text = $"Chapter {currentChapter}";
                    uxBackButton.Enabled = currentChapter > 1;
                    uxForwardButton.Enabled = currentChapter < _maxChapters;
                    handler(ChapterState.UpdateReadHistory, 0);
                    break;
                case ChapterState.GotError:
                    throw new Exception("Could not load chapter.");
                default:
                    break;
            }
        }

        private void LoadChapter(object sender, EventArgs e)
        {
            handler(ChapterState.SetChapter, _initialChapter);
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            handler(ChapterState.ChangeChapter, 1);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            handler(ChapterState.ChangeChapter, -1);
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            var view = new NovelView(_novel);
            var controller = new NovelController(view.DisplayState);
            view.SetNovelHandler(controller.HandleEvents);
            _navigate?.Invoke(view);
        }

        private void ViewCommentsButtonClick(object sender, EventArgs e)
        {
            string query = $@"
                SELECT ChapterId
                FROM Chapters
                WHERE NovelId = {_novel.NovelId} AND ChapterNumber = {_currentChapter};
            ";

            var chapterId = DatabaseHelper.ExecuteScalar<int>(query);
            var view = new CommentView(chapterId);
            var controller = new CommentController(view.DisplayState);
            view.SetCommentHandler(controller.HandleEvents);
            view.SetNavigator(_navigate);
            _navigate?.Invoke(view);
        }
    }
}
