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
        private int _chapterId;
        public CommentView(int chapterId)
        {
            InitializeComponent();
            _chapterId = chapterId;

            SetUpTable();

            DisplayComments();
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

        private void DisplayComments()
        {
            uxCommentBox.Items.Clear();

            string query = $@"
                SELECT c.CommentString, u.Username, c.CommentPostedDate
                FROM Comments c
                JOIN Users u ON c.UserId = u.UserId
                WHERE c.ChapterId = {_chapterId}
                ORDER BY c.CommentPostedDate ASC;
            ";

            var result = DatabaseHelper.ExecuteReader(query);
            while (result.Read())
            {
                string str = $" \n{result.GetString(0)} \nBy: {result.GetString(1)} on {result.GetDateTime(2)}\n ";
                uxCommentBox.Items.Add(str);
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            string novelQuery = $@"
                SELECT n.NovelId, n.NovelName, n.AuthorName, n.Description, n.DatePosted, n.UploadedByUserId
                FROM Novels n
                JOIN Chapters c ON c.NovelId = n.NovelId
                WHERE c.ChapterId = {_chapterId};
            ";
            Novel novel = null;
            var novelResult = DatabaseHelper.ExecuteReader(novelQuery);

            if (novelResult.Read())
            {
                novel = new Novel
                {
                    NovelId = novelResult.GetInt32(0),
                    NovelName = novelResult.GetString(1),
                    AuthorName = novelResult.GetString(2),
                    Description = novelResult.GetString(3),
                    DatePosted = novelResult.GetDateTime(4),
                    UploadedByUserId = novelResult.GetInt32(5)
                };
            }

            string chapterQuery = $@"
                SELECT ChapterNumber
                FROM Chapters
                WHERE ChapterId = {_chapterId};
            ";
            var chapterResult = DatabaseHelper.ExecuteScalar<int>(chapterQuery);

            _navigate.Invoke(new ChapterView(novel, chapterResult));
        }

        private void AddCommentButtonClick(object sender, EventArgs e)
        {
            string result = Prompt.ShowDialog("Enter Description", "Please enter text:");

            if (result == null)
            {
                return;
            }

            string query = $@"
                INSERT INTO Comments (ChapterId, UserId, CommentString)
                VALUES (
                    {_chapterId},
                    (SELECT UserId FROM Users WHERE Username = '{EnvironmentVars.username}'),
                    '{result}'
                );
            ";

            DatabaseHelper.ExecuteNonQuery(query);

            DisplayComments();
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }
    }
}
