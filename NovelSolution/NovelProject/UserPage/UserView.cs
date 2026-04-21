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

            SetupListView();
            AddNovels(UserController.getHistory(_currentUsername));
        }

        private void SetupListView()
        {
            uxReadHistoryList.View = View.Details;
            uxReadHistoryList.FullRowSelect = true;

            uxReadHistoryList.Columns.Add("Your Rating", 100);
            uxReadHistoryList.Columns.Add("Title", 200);
            uxReadHistoryList.Columns.Add("Author", 100);
            uxReadHistoryList.Columns.Add("Last Chapter", 100);
            uxReadHistoryList.Columns.Add("Last Read", 200);
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
