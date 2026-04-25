namespace NovelProject.NovelPage
{
    partial class NovelView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxTitleLabel = new System.Windows.Forms.Label();
            uxAuthorLink = new System.Windows.Forms.LinkLabel();
            uxDescriptionBox = new System.Windows.Forms.RichTextBox();
            uxReadButton = new System.Windows.Forms.Button();
            uxChapterList = new System.Windows.Forms.ListView();
            reviewsPanel = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uxTitleLabel
            // 
            uxTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxTitleLabel.AutoSize = true;
            uxTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            uxTitleLabel.Location = new System.Drawing.Point(3, 0);
            uxTitleLabel.Name = "uxTitleLabel";
            uxTitleLabel.Size = new System.Drawing.Size(189, 45);
            uxTitleLabel.TabIndex = 0;
            uxTitleLabel.Text = "uxTitleLabel";
            // 
            // uxAuthorLink
            // 
            uxAuthorLink.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxAuthorLink.AutoSize = true;
            uxAuthorLink.Font = new System.Drawing.Font("Segoe UI", 18F);
            uxAuthorLink.LinkColor = System.Drawing.Color.Black;
            uxAuthorLink.Location = new System.Drawing.Point(3, 45);
            uxAuthorLink.Name = "uxAuthorLink";
            uxAuthorLink.Size = new System.Drawing.Size(87, 32);
            uxAuthorLink.TabIndex = 6;
            uxAuthorLink.TabStop = true;
            uxAuthorLink.Text = "Author";
            uxAuthorLink.VisitedLinkColor = System.Drawing.Color.Black;
            uxAuthorLink.LinkClicked += AuthorLinkLinkClicked;
            // 
            // uxDescriptionBox
            // 
            uxDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            uxDescriptionBox.Location = new System.Drawing.Point(3, 133);
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.ReadOnly = true;
            uxDescriptionBox.Size = new System.Drawing.Size(275, 248);
            uxDescriptionBox.TabIndex = 7;
            uxDescriptionBox.Text = "";
            // 
            // uxReadButton
            // 
            uxReadButton.Location = new System.Drawing.Point(3, 387);
            uxReadButton.Name = "uxReadButton";
            uxReadButton.Size = new System.Drawing.Size(75, 23);
            uxReadButton.TabIndex = 8;
            uxReadButton.Text = "Read ->";
            uxReadButton.UseVisualStyleBackColor = true;
            uxReadButton.Click += ReadButtonClick;
            // 
            // uxChapterList
            // 
            uxChapterList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxChapterList.Location = new System.Drawing.Point(3, 80);
            uxChapterList.Name = "uxChapterList";
            uxChapterList.Size = new System.Drawing.Size(321, 391);
            uxChapterList.TabIndex = 9;
            uxChapterList.UseCompatibleStateImageBehavior = false;
            // 
            // reviewsPanel
            // 
            reviewsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            reviewsPanel.Location = new System.Drawing.Point(661, 2);
            reviewsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            reviewsPanel.Name = "reviewsPanel";
            reviewsPanel.Size = new System.Drawing.Size(267, 521);
            reviewsPanel.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.310189F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.3796158F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.310189F));
            tableLayoutPanel1.Controls.Add(reviewsPanel, 3, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(970, 525);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(uxTitleLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(uxChapterList, 0, 2);
            tableLayoutPanel2.Controls.Add(uxAuthorLink, 0, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(41, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new System.Drawing.Size(327, 519);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(uxReadButton, 0, 2);
            tableLayoutPanel3.Controls.Add(uxDescriptionBox, 0, 1);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(374, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.8541679F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.1458359F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(281, 519);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // NovelView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "NovelView";
            Size = new System.Drawing.Size(970, 525);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.LinkLabel uxAuthorLink;
        private System.Windows.Forms.RichTextBox uxDescriptionBox;
        private System.Windows.Forms.Button uxReadButton;
        private System.Windows.Forms.ListView uxChapterList;
        private System.Windows.Forms.Panel reviewsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}