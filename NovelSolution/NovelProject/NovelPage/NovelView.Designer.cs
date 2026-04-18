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
            uxReviewBar = new System.Windows.Forms.TrackBar();
            label2 = new System.Windows.Forms.Label();
            uxAuthorLink = new System.Windows.Forms.LinkLabel();
            uxDescriptionBox = new System.Windows.Forms.RichTextBox();
            uxReadButton = new System.Windows.Forms.Button();
            uxChapterList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)uxReviewBar).BeginInit();
            SuspendLayout();
            // 
            // uxTitleLabel
            // 
            uxTitleLabel.AutoSize = true;
            uxTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            uxTitleLabel.Location = new System.Drawing.Point(20, 18);
            uxTitleLabel.Name = "uxTitleLabel";
            uxTitleLabel.Size = new System.Drawing.Size(189, 45);
            uxTitleLabel.TabIndex = 0;
            uxTitleLabel.Text = "uxTitleLabel";
            // 
            // uxReviewBar
            // 
            uxReviewBar.Location = new System.Drawing.Point(534, 377);
            uxReviewBar.Name = "uxReviewBar";
            uxReviewBar.Size = new System.Drawing.Size(209, 45);
            uxReviewBar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(534, 348);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "Leave a review";
            // 
            // uxAuthorLink
            // 
            uxAuthorLink.AutoSize = true;
            uxAuthorLink.Font = new System.Drawing.Font("Segoe UI", 18F);
            uxAuthorLink.LinkColor = System.Drawing.Color.Black;
            uxAuthorLink.Location = new System.Drawing.Point(20, 54);
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
            uxDescriptionBox.Location = new System.Drawing.Point(495, 54);
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.ReadOnly = true;
            uxDescriptionBox.Size = new System.Drawing.Size(282, 218);
            uxDescriptionBox.TabIndex = 7;
            uxDescriptionBox.Text = "";
            // 
            // uxReadButton
            // 
            uxReadButton.Location = new System.Drawing.Point(600, 298);
            uxReadButton.Name = "uxReadButton";
            uxReadButton.Size = new System.Drawing.Size(75, 23);
            uxReadButton.TabIndex = 8;
            uxReadButton.Text = "Read ->";
            uxReadButton.UseVisualStyleBackColor = true;
            uxReadButton.Click += ReadButtonClick;
            // 
            // uxChapterList
            // 
            uxChapterList.Location = new System.Drawing.Point(20, 89);
            uxChapterList.Name = "uxChapterList";
            uxChapterList.Size = new System.Drawing.Size(456, 333);
            uxChapterList.TabIndex = 9;
            uxChapterList.UseCompatibleStateImageBehavior = false;
            // 
            // NovelView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxChapterList);
            Controls.Add(uxReadButton);
            Controls.Add(uxDescriptionBox);
            Controls.Add(uxAuthorLink);
            Controls.Add(label2);
            Controls.Add(uxReviewBar);
            Controls.Add(uxTitleLabel);
            Name = "NovelView";
            Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)uxReviewBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.TrackBar uxReviewBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel uxAuthorLink;
        private System.Windows.Forms.RichTextBox uxDescriptionBox;
        private System.Windows.Forms.Button uxReadButton;
        private System.Windows.Forms.ListView uxChapterList;
    }
}