using NovelProject.ChapterPage;
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

namespace NovelProject.CommentPage
{
    public partial class CommentView : UserControl, INavigatable
    {
        public CommentHandler handler;

        private int _chapterId;
        private Action<UserControl> _navigate;

        public CommentView(int chapterId)
        {
            InitializeComponent();
            _chapterId = chapterId;

            SetUpTable();

            this.Load += LoadComments;

            if(!EnvironmentVars.IsLoggedIn)
            {
                uxAddCommentButton.Enabled = false;
            }
        }

        public void SetCommentHandler(CommentHandler handler)
        {
            this.handler = handler;
        }

        public void DisplayState(CommentState s, List<string> comments, Novel novel, int chapterNumber)
        {
            switch (s)
            {
                case CommentState.GotComments:
                    uxCommentBox.Items.Clear();
                    foreach (var comment in comments)
                        uxCommentBox.Items.Add(comment);
                    break;
                case CommentState.CommentAdded:
                    handler(CommentState.LoadComments, _chapterId, null);
                    break;
                case CommentState.GotChapter:
                    var view = new ChapterView(novel, chapterNumber);
                    var controller = new ChapterController(view.DisplayState, novel.NovelId.ToString());
                    view.SetChapterHandler(controller.HandleEvents);
                    _navigate.Invoke(view);
                    break;
                default:
                    break;
            }
        }

        private void LoadComments(object sender, EventArgs e)
        {
            handler(CommentState.LoadComments, _chapterId, null);
        }

        private void SetUpTable()
        {
            uxCommentBox.DrawMode = DrawMode.OwnerDrawVariable;

            uxCommentBox.MeasureItem += (s, e) =>
            {
                string text = uxCommentBox.Items[e.Index].ToString();
                SizeF size = e.Graphics.MeasureString(text, uxCommentBox.Font, uxCommentBox.Width);
                e.ItemHeight = (int)size.Height;
            };

            uxCommentBox.DrawItem += (s, e) =>
            {
                e.DrawBackground();

                if (e.Index < 0) return;

                string text = uxCommentBox.Items[e.Index].ToString();

                e.Graphics.DrawString(
                    text,
                    uxCommentBox.Font,
                    Brushes.Black,
                    new RectangleF(e.Bounds.X + 5, e.Bounds.Y + 2, e.Bounds.Width - 10, e.Bounds.Height - 4)
                );

                // separator line
                e.Graphics.DrawLine(
                    Pens.LightGray,
                    e.Bounds.Left,
                    e.Bounds.Bottom - 1,
                    e.Bounds.Right,
                    e.Bounds.Bottom - 1
                );

                e.DrawFocusRectangle();
            };
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            handler(CommentState.GetChapterForBack, _chapterId, null);
        }

        private void AddCommentButtonClick(object sender, EventArgs e)
        {
            string result = Prompt.ShowDialog("Enter Description", "Please enter text:");

            if (result == null)
                return;

            handler(CommentState.AddComment, _chapterId, result);
        }

        
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }
    }
}
