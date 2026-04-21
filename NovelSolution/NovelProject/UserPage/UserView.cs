using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
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

namespace NovelProject.UserPage
{
    public partial class UserView : UserControl, INavigatable
    {
        private string _currentUsername;

        public UserView(string username)
        {
            InitializeComponent();
            _currentUsername = username;
            updateStats();

            if (username == EnvironmentVars.username)
            {
                uxChangePasswordButton.Visible = true;
                uxChangePasswordButton.Enabled = true;
            }
            else 
            {
                uxChangePasswordButton.Visible = false;
                uxChangePasswordButton.Enabled = false;
            }

            SetupListViews();
            AddNovels(UserController.getHistory(_currentUsername));
            AddUploads();
            AddComments();
        }

        private void SetupListViews()
        {

            /* Read History */

            uxReadHistoryList.View = View.Details;
            uxReadHistoryList.FullRowSelect = true;

            uxReadHistoryList.Columns.Add("Your Rating", 100);
            uxReadHistoryList.Columns.Add("Title", 200);
            uxReadHistoryList.Columns.Add("Author", 100);
            uxReadHistoryList.Columns.Add("Last Chapter", 100);
            uxReadHistoryList.Columns.Add("Last Read", 200);

            /* Novels Uploaded */

            uxUploadedNovels.View = View.Details;
            uxUploadedNovels.FullRowSelect = true;

            uxUploadedNovels.Columns.Add("Title", 200);
            uxUploadedNovels.Columns.Add("Author", 100);


            /* Comments */

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

        private void AddNovels(Tuple<List<Novel>, List<decimal>, List<string>, List<int>> tuple)
        {
            uxReadHistoryList.Items.Clear();

            for (int i = 0; i < tuple.Item1.Count; i++)
            {
                var novel = tuple.Item1[i];
                var rating = tuple.Item2[i];
                var lastRead = tuple.Item3[i];
                var item = new ListViewItem(rating + " / 10");

                item.SubItems.Add(novel.NovelName);
                item.SubItems.Add(novel.AuthorName);
                item.SubItems.Add(tuple.Item4[i].ToString());
                item.SubItems.Add(lastRead);

                item.Tag = novel; 

                uxReadHistoryList.Items.Add(item);
            }
        }

        public void AddUploads() {
            uxUploadedNovels.Items.Clear();
            string query = $"SELECT NovelName, AuthorName FROM Novels WHERE UploadedByUserId = (SELECT UserId FROM Users WHERE Username = '{_currentUsername}')";
            var result = DatabaseHelper.ExecuteReader(query);

            while (result.Read())
            {
                var item = new ListViewItem(result.GetString(0));
                item.SubItems.Add(result.GetString(1));
                uxUploadedNovels.Items.Add(item);
            }

        }

        public void AddComments()
        {
            uxCommentBox.Items.Clear();
            string query = $@"SELECT n.NovelName, c.ChapterNumber, s.CommentString
                              FROM Comments s
                              JOIN Chapters c on c.ChapterId = s.ChapterId
                              JOIN Novels n on n.NovelId = c.NovelId
                              where s.UserId = (Select UserId FROM Users WHERE Username = '{_currentUsername}')
                               ";

            var result = DatabaseHelper.ExecuteReader(query);
            while (result.Read())
            {
                string str = $" \n{result.GetString(0)}, Chapter: {result.GetInt32(1)} \n{result.GetString(2)}\n ";
                uxCommentBox.Items.Add(str);
            }
        }

        public void updateStats()
        {

            string query = $@"
                SELECT 
                    (SELECT COUNT(*) FROM Novels WHERE UploadedByUserId = (SELECT UserId FROM Users WHERE Username = '{_currentUsername}')) AS NovelsPosted,
                    (SELECT COUNT(distinct NovelId) FROM ReadHistories h WHERE h.UserId = (SELECT UserId FROM Users WHERE Username = '{_currentUsername}')) AS NovelsRead,
                    (SELECT COUNT(*) FROM Reviews r JOIN Users u ON r.UserId = u.UserId WHERE u.Username = '{_currentUsername}') AS ReviewsPosted
            ";

            var result = DatabaseHelper.ExecuteReader(query);
            int novelsPosted = 0;
            int novelsRead = 0;
            int reviewsPosted = 0;
            if (result.Read())
            {
                novelsPosted = result.GetInt32(0);
                novelsRead = result.GetInt32(1);
                reviewsPosted = result.GetInt32(2);
            }

            uxUserNameLabel.Text = $"{_currentUsername}";
            uxNovelsPostedLabel.Text = $"Novels Posted: {novelsPosted}";
            uxNovelsReadLabel.Text = $"Novels Read: {novelsRead}";
            uxReveiewsPostedLabel.Text = $"Reviews Posted: {reviewsPosted}";
        }

        private void ChangePasswordButtonClick(object sender, EventArgs e)
        {
            string query = $"SELECT UserId FROM Users WHERE Username = '{_currentUsername}'";
            int userID = DatabaseHelper.ExecuteScalar<int>(query);

            string input = Interaction.InputBox(
                "New Password:",
                "Input Required",
                ""
            );

            if (!string.IsNullOrEmpty(input))
            {
                string newHash = BCrypt.Net.BCrypt.HashPassword(input);
                string updateQuery = $"UPDATE Users SET EncryptedPassword = '{newHash}' WHERE UserId = {userID}";
                DatabaseHelper.ExecuteNonQuery(updateQuery);
                MessageBox.Show("Password changed successfully!");
            }
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }
    }
}
