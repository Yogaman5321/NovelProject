using Microsoft.Data.SqlClient;
using NovelProject.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace NovelProject
{
    public partial class NovelDisplayCard : UserControl
    {
        private static readonly Color DefaultBackground = SystemColors.Control;
        private static readonly Color HoverBackground = Color.FromArgb(220, 235, 252);

        public NovelDisplayCard()
        {
            InitializeComponent();

            this.Margin = new Padding(0, 2, 0, 2);
            this.Cursor = Cursors.Hand;

            AttachHoverHandlers(this);
        }

        public void Populate(Novel novel)
        {
            novelNameLabel.Text = novel.NovelName;
            authorLinkLabel.Text = novel.AuthorName;

            // Views: not yet implemented (ReadHistory table pending)
            viewsLabel.Text = "N/A";

            // Average rating
            double rating = DatabaseHelper.ExecuteScalar<double>(
                "SELECT ISNULL(AVG(CAST(Rating AS FLOAT)), 0) FROM Reviews WHERE NovelId = @novelId",
                new SqlParameter("@novelId", novel.NovelId));
            ratingLabel.Text = rating.ToString("0.0");

            // Chapter count
            int chapterCount = DatabaseHelper.ExecuteScalar<int>(
                "SELECT COUNT(*) FROM Chapters WHERE NovelId = @novelId",
                new SqlParameter("@novelId", novel.NovelId));
            chapterCountLabel.Text = chapterCount.ToString();

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
    }
}
