using Microsoft.Data.SqlClient;
using NovelProject.Models;
using NovelProject.Navigation;
using NovelProject.UserPage;
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

namespace NovelProject
{
    public partial class NovelDisplayCard : UserControl, INavigatable
    {
        private static readonly Color DefaultBackground = SystemColors.Control;
        private static readonly Color HoverBackground = Color.FromArgb(220, 235, 252);
        private Novel _novel;
        private Action<UserControl> _navigate;
        public NovelDisplayCard()
        {
            InitializeComponent();

            this.Margin = new Padding(0, 2, 0, 2);
            this.Cursor = Cursors.Hand;

            AttachHoverHandlers(this);
        }

        
        public void Populate(Novel novel)
        {
            _novel = novel;
            novelNameLabel.Text = novel.NovelName;
            authorLinkLabel.Text = novel.AuthorName;

            // Average rating + chapter count + total views in a single query
            using (var reader = DatabaseHelper.ExecuteReader(
                @"SELECT
                    ISNULL(AVG(CAST(r.Rating AS FLOAT)), 0) AS AvgRating,
                    (SELECT COUNT(*) FROM Chapters WHERE NovelId = @novelId) AS ChapterCount,
                    (SELECT COUNT(*) FROM ReadHistories rh
                     INNER JOIN Chapters c ON rh.ChapterId = c.ChapterId
                     WHERE c.NovelId = @novelId) AS ViewCount
                  FROM Reviews r
                  WHERE r.NovelId = @novelId",
                new SqlParameter("@novelId", novel.NovelId)))
            {
                if (reader.Read())
                {
                    ratingLabel.Text = reader.GetDouble(0).ToString("0.0");
                    chapterCountLabel.Text = reader.GetInt32(1).ToString();
                    viewsLabel.Text = reader.GetInt32(2).ToString("N0");
                }
            }

            // Tags
            tagsFlowLayoutPanel.Controls.Clear();
            using (var reader = DatabaseHelper.ExecuteReader(
                "SELECT t.TagName FROM Tags t " +
                "INNER JOIN NovelTags nt ON t.TagId = nt.TagId " +
                "WHERE nt.NovelId = @novelId",
                new SqlParameter("@novelId", novel.NovelId)))
            {
                while (reader.Read())
                {
                    tagsFlowLayoutPanel.Controls.Add(new Label
                    {
                        Text = reader.GetString(0),
                        AutoSize = true,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(2)
                    });
                }
            }
        }

        private void AttachHoverHandlers(Control control)
        {
            control.MouseEnter += OnCardMouseEnter;
            control.MouseLeave += OnCardMouseLeave;

            foreach (Control child in control.Controls)
            {
                AttachHoverHandlers(child);
            }
        }

        private void OnCardMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = HoverBackground;
        }

        private void OnCardMouseLeave(object sender, EventArgs e)
        {
            // Only reset when the mouse has truly left the card boundary
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                this.BackColor = DefaultBackground;
            }
        }

        private void authorLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = DatabaseHelper.ExecuteScalar<string>(
            @"SELECT u.Username
                          FROM Novels n
                          JOIN Users u ON n.UploadedByUserId = u.UserId
                          WHERE n.NovelId = @NovelId",
            new SqlParameter("@NovelId", _novel.NovelId)
            );

            Debug.WriteLine(_navigate == null ? "NULL NAVIGATE" : "NAVIGATE OK");

            if (!string.IsNullOrEmpty(username))
            {
                var view = new UserView(username);
                var controller = new UserController(view.DisplayState);
                view.SetUserHandler(controller.HandleEvents);
                _navigate?.Invoke(view);
            }
        }

        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }
    }
}
