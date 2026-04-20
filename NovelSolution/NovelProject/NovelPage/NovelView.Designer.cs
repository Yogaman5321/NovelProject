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
            SuspendLayout();
            // 
            // uxTitleLabel
            // 
            uxTitleLabel.AutoSize = true;
            uxTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            uxTitleLabel.Location = new System.Drawing.Point(23, 18);
            uxTitleLabel.Name = "uxTitleLabel";
            uxTitleLabel.Size = new System.Drawing.Size(234, 54);
            uxTitleLabel.TabIndex = 0;
            uxTitleLabel.Text = "uxTitleLabel";
            // 
            // uxAuthorLink
            // 
            uxAuthorLink.AutoSize = true;
            uxAuthorLink.Font = new System.Drawing.Font("Segoe UI", 18F);
            uxAuthorLink.LinkColor = System.Drawing.Color.Black;
            uxAuthorLink.Location = new System.Drawing.Point(23, 72);
            uxAuthorLink.Name = "uxAuthorLink";
            uxAuthorLink.Size = new System.Drawing.Size(109, 41);
            uxAuthorLink.TabIndex = 6;
            uxAuthorLink.TabStop = true;
            uxAuthorLink.Text = "Author";
            uxAuthorLink.VisitedLinkColor = System.Drawing.Color.Black;
            uxAuthorLink.LinkClicked += AuthorLinkLinkClicked;
            // 
            // uxDescriptionBox
            // 
            uxDescriptionBox.Location = new System.Drawing.Point(484, 173);
            uxDescriptionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.ReadOnly = true;
            uxDescriptionBox.Size = new System.Drawing.Size(206, 253);
            uxDescriptionBox.TabIndex = 7;
            uxDescriptionBox.Text = "";
            // 
            // uxReadButton
            // 
            uxReadButton.Location = new System.Drawing.Point(555, 443);
            uxReadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxReadButton.Name = "uxReadButton";
            uxReadButton.Size = new System.Drawing.Size(86, 31);
            uxReadButton.TabIndex = 8;
            uxReadButton.Text = "Read ->";
            uxReadButton.UseVisualStyleBackColor = true;
            uxReadButton.Click += ReadButtonClick;
            // 
            // uxChapterList
            // 
            uxChapterList.Location = new System.Drawing.Point(23, 119);
            uxChapterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxChapterList.Name = "uxChapterList";
            uxChapterList.Size = new System.Drawing.Size(443, 443);
            uxChapterList.TabIndex = 9;
            uxChapterList.UseCompatibleStateImageBehavior = false;
            // 
            // reviewsPanel
            // 
            reviewsPanel.Location = new System.Drawing.Point(720, 3);
            reviewsPanel.Name = "reviewsPanel";
            reviewsPanel.Size = new System.Drawing.Size(356, 597);
            reviewsPanel.TabIndex = 10;
            // 
            // NovelView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(reviewsPanel);
            Controls.Add(uxChapterList);
            Controls.Add(uxReadButton);
            Controls.Add(uxDescriptionBox);
            Controls.Add(uxAuthorLink);
            Controls.Add(uxTitleLabel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "NovelView";
            Size = new System.Drawing.Size(1076, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.LinkLabel uxAuthorLink;
        private System.Windows.Forms.RichTextBox uxDescriptionBox;
        private System.Windows.Forms.Button uxReadButton;
        private System.Windows.Forms.ListView uxChapterList;
        private System.Windows.Forms.Panel reviewsPanel;
    }
}