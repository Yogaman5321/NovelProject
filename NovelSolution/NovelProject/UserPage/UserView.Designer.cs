namespace NovelProject.UserPage
{
    partial class UserView
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
            uxStatsLabel = new System.Windows.Forms.Label();
            uxNovelsPostedLabel = new System.Windows.Forms.Label();
            uxReveiewsPostedLabel = new System.Windows.Forms.Label();
            uxNovelsReadLabel = new System.Windows.Forms.Label();
            uxReadHistoryList = new System.Windows.Forms.ListView();
            label5 = new System.Windows.Forms.Label();
            uxChangePasswordButton = new System.Windows.Forms.Button();
            uxUserNameLabel = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            uxUploadedNovels = new System.Windows.Forms.ListView();
            tabPage3 = new System.Windows.Forms.TabPage();
            uxCommentBox = new System.Windows.Forms.ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // uxStatsLabel
            // 
            uxStatsLabel.AutoSize = true;
            uxStatsLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            uxStatsLabel.Location = new System.Drawing.Point(23, 58);
            uxStatsLabel.Name = "uxStatsLabel";
            uxStatsLabel.Size = new System.Drawing.Size(58, 30);
            uxStatsLabel.TabIndex = 0;
            uxStatsLabel.Text = "Stats";
            // 
            // uxNovelsPostedLabel
            // 
            uxNovelsPostedLabel.AutoSize = true;
            uxNovelsPostedLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxNovelsPostedLabel.Location = new System.Drawing.Point(23, 130);
            uxNovelsPostedLabel.Name = "uxNovelsPostedLabel";
            uxNovelsPostedLabel.Size = new System.Drawing.Size(115, 21);
            uxNovelsPostedLabel.TabIndex = 1;
            uxNovelsPostedLabel.Text = "Novels Posted: ";
            // 
            // uxReveiewsPostedLabel
            // 
            uxReveiewsPostedLabel.AutoSize = true;
            uxReveiewsPostedLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxReveiewsPostedLabel.Location = new System.Drawing.Point(23, 109);
            uxReveiewsPostedLabel.Name = "uxReveiewsPostedLabel";
            uxReveiewsPostedLabel.Size = new System.Drawing.Size(124, 21);
            uxReveiewsPostedLabel.TabIndex = 2;
            uxReveiewsPostedLabel.Text = "Reviews Posted: ";
            // 
            // uxNovelsReadLabel
            // 
            uxNovelsReadLabel.AutoSize = true;
            uxNovelsReadLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxNovelsReadLabel.Location = new System.Drawing.Point(23, 88);
            uxNovelsReadLabel.Name = "uxNovelsReadLabel";
            uxNovelsReadLabel.Size = new System.Drawing.Size(104, 21);
            uxNovelsReadLabel.TabIndex = 3;
            uxNovelsReadLabel.Text = "Novels Read: ";
            // 
            // uxReadHistoryList
            // 
            uxReadHistoryList.Location = new System.Drawing.Point(0, 0);
            uxReadHistoryList.Name = "uxReadHistoryList";
            uxReadHistoryList.Size = new System.Drawing.Size(497, 349);
            uxReadHistoryList.TabIndex = 4;
            uxReadHistoryList.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 16F);
            label5.Location = new System.Drawing.Point(281, 55);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 30);
            label5.TabIndex = 5;
            label5.Text = "Read History";
            // 
            // uxChangePasswordButton
            // 
            uxChangePasswordButton.Location = new System.Drawing.Point(667, 13);
            uxChangePasswordButton.Name = "uxChangePasswordButton";
            uxChangePasswordButton.Size = new System.Drawing.Size(119, 30);
            uxChangePasswordButton.TabIndex = 6;
            uxChangePasswordButton.Text = "Change Password";
            uxChangePasswordButton.UseVisualStyleBackColor = true;
            uxChangePasswordButton.Click += ChangePasswordButtonClick;
            // 
            // uxUserNameLabel
            // 
            uxUserNameLabel.AutoSize = true;
            uxUserNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            uxUserNameLabel.Location = new System.Drawing.Point(23, 13);
            uxUserNameLabel.Name = "uxUserNameLabel";
            uxUserNameLabel.Size = new System.Drawing.Size(212, 37);
            uxUserNameLabel.TabIndex = 7;
            uxUserNameLabel.Text = "UserName Label";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(281, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(505, 377);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uxReadHistoryList);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(497, 349);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Read History";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(uxUploadedNovels);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(497, 349);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Novels Uploaded";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // uxUploadedNovels
            // 
            uxUploadedNovels.Location = new System.Drawing.Point(0, 0);
            uxUploadedNovels.Name = "uxUploadedNovels";
            uxUploadedNovels.Size = new System.Drawing.Size(497, 349);
            uxUploadedNovels.TabIndex = 5;
            uxUploadedNovels.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(uxCommentBox);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(497, 349);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Comments";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // uxCommentBox
            // 
            uxCommentBox.FormattingEnabled = true;
            uxCommentBox.Location = new System.Drawing.Point(0, 0);
            uxCommentBox.Name = "uxCommentBox";
            uxCommentBox.Size = new System.Drawing.Size(497, 349);
            uxCommentBox.TabIndex = 0;
            // 
            // UserView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(uxUserNameLabel);
            Controls.Add(uxChangePasswordButton);
            Controls.Add(label5);
            Controls.Add(uxNovelsReadLabel);
            Controls.Add(uxReveiewsPostedLabel);
            Controls.Add(uxNovelsPostedLabel);
            Controls.Add(uxStatsLabel);
            Name = "UserView";
            Size = new System.Drawing.Size(800, 450);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label uxStatsLabel;
        private System.Windows.Forms.Label uxNovelsPostedLabel;
        private System.Windows.Forms.Label uxReveiewsPostedLabel;
        private System.Windows.Forms.Label uxNovelsReadLabel;
        private System.Windows.Forms.ListView uxReadHistoryList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uxChangePasswordButton;
        private System.Windows.Forms.Label uxUserNameLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView uxUploadedNovels;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox uxCommentBox;
    }
}