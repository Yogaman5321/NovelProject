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
            uxReadHistoryList.Location = new System.Drawing.Point(281, 88);
            uxReadHistoryList.Name = "uxReadHistoryList";
            uxReadHistoryList.Size = new System.Drawing.Size(486, 341);
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
            // UserView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxUserNameLabel);
            Controls.Add(uxChangePasswordButton);
            Controls.Add(label5);
            Controls.Add(uxReadHistoryList);
            Controls.Add(uxNovelsReadLabel);
            Controls.Add(uxReveiewsPostedLabel);
            Controls.Add(uxNovelsPostedLabel);
            Controls.Add(uxStatsLabel);
            Name = "UserView";
            Size = new System.Drawing.Size(800, 450);
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
    }
}