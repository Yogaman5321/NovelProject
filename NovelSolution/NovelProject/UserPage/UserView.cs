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
    public partial class UserView : UserControl
    {
        public UserHandler handler;
        private string _currentUsername;

        public UserView(string username)
        {
            InitializeComponent();
            _currentUsername = username;

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
            this.Load += LoadUser;
        }

        public void SetUserHandler(UserHandler handler)
        {
            this.handler = handler;
        }

        public void DisplayState(UserState s, UserPageData data)
        {
            switch (s)
            {
                case UserState.GotUserData:
                    uxUserNameLabel.Text = $"{_currentUsername}";
                    uxNovelsPostedLabel.Text = $"Novels Posted: {data.NovelsPosted}";
                    uxNovelsReadLabel.Text = $"Novels Read: {data.NovelsRead}";
                    uxReveiewsPostedLabel.Text = $"Reviews Posted: {data.ReviewsPosted}";
                    AddNovels(data.History);
                    AddUploads(data.Uploads);
                    AddComments(data.Comments);
                    break;
                case UserState.PasswordChanged:
                    MessageBox.Show("Password changed successfully!");
                    break;
                default:
                    break;
            }
        }

        private void LoadUser(object sender, EventArgs e)
        {
            handler(UserState.LoadUser, _currentUsername, null);
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
                var item = new ListViewItem(rating == -1 ? "N/A" : $"{rating} / 10");

                item.SubItems.Add(novel.NovelName);
                item.SubItems.Add(novel.AuthorName);
                item.SubItems.Add(tuple.Item4[i].ToString());
                item.SubItems.Add(lastRead);

                item.Tag = novel;

                uxReadHistoryList.Items.Add(item);
            }
        }

        private void AddUploads(List<string> uploads)
        {
            uxUploadedNovels.Items.Clear();
            foreach (var entry in uploads)
            {
                var parts = entry.Split('|');
                var item = new ListViewItem(parts[0]);
                item.SubItems.Add(parts.Length > 1 ? parts[1] : "");
                uxUploadedNovels.Items.Add(item);
            }
        }

        private void AddComments(List<string> comments)
        {
            uxCommentBox.Items.Clear();
            foreach (var comment in comments)
            {
                uxCommentBox.Items.Add(comment);
            }
        }

        private void ChangePasswordButtonClick(object sender, EventArgs e)
        {
            string input = Interaction.InputBox(
                "New Password:",
                "Input Required",
                ""
            );

            if (!string.IsNullOrEmpty(input))
            {
                handler(UserState.ChangePassword, _currentUsername, input);
            }
        }
    }
}
