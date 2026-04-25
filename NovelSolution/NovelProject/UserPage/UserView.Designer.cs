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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // uxStatsLabel
            // 
            uxStatsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxStatsLabel.AutoSize = true;
            uxStatsLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            uxStatsLabel.Location = new System.Drawing.Point(3, 70);
            uxStatsLabel.Name = "uxStatsLabel";
            uxStatsLabel.Size = new System.Drawing.Size(58, 30);
            uxStatsLabel.TabIndex = 0;
            uxStatsLabel.Text = "Stats";
            // 
            // uxNovelsPostedLabel
            // 
            uxNovelsPostedLabel.AutoSize = true;
            uxNovelsPostedLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxNovelsPostedLabel.Location = new System.Drawing.Point(3, 142);
            uxNovelsPostedLabel.Name = "uxNovelsPostedLabel";
            uxNovelsPostedLabel.Size = new System.Drawing.Size(115, 21);
            uxNovelsPostedLabel.TabIndex = 1;
            uxNovelsPostedLabel.Text = "Novels Posted: ";
            // 
            // uxReveiewsPostedLabel
            // 
            uxReveiewsPostedLabel.AutoSize = true;
            uxReveiewsPostedLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxReveiewsPostedLabel.Location = new System.Drawing.Point(3, 121);
            uxReveiewsPostedLabel.Name = "uxReveiewsPostedLabel";
            uxReveiewsPostedLabel.Size = new System.Drawing.Size(124, 21);
            uxReveiewsPostedLabel.TabIndex = 2;
            uxReveiewsPostedLabel.Text = "Reviews Posted: ";
            // 
            // uxNovelsReadLabel
            // 
            uxNovelsReadLabel.AutoSize = true;
            uxNovelsReadLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxNovelsReadLabel.Location = new System.Drawing.Point(3, 100);
            uxNovelsReadLabel.Name = "uxNovelsReadLabel";
            uxNovelsReadLabel.Size = new System.Drawing.Size(104, 21);
            uxNovelsReadLabel.TabIndex = 3;
            uxNovelsReadLabel.Text = "Novels Read: ";
            // 
            // uxReadHistoryList
            // 
            uxReadHistoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxReadHistoryList.Location = new System.Drawing.Point(3, 3);
            uxReadHistoryList.Name = "uxReadHistoryList";
            uxReadHistoryList.Size = new System.Drawing.Size(520, 318);
            uxReadHistoryList.TabIndex = 4;
            uxReadHistoryList.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 16F);
            label5.Location = new System.Drawing.Point(3, 36);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 30);
            label5.TabIndex = 5;
            label5.Text = "Read History";
            // 
            // uxChangePasswordButton
            // 
            uxChangePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            uxChangePasswordButton.Location = new System.Drawing.Point(418, 3);
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
            uxUserNameLabel.Location = new System.Drawing.Point(3, 0);
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
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(3, 69);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(534, 352);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uxReadHistoryList);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(526, 324);
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
            tabPage2.Size = new System.Drawing.Size(526, 319);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Novels Uploaded";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // uxUploadedNovels
            // 
            uxUploadedNovels.Dock = System.Windows.Forms.DockStyle.Fill;
            uxUploadedNovels.Location = new System.Drawing.Point(3, 3);
            uxUploadedNovels.Name = "uxUploadedNovels";
            uxUploadedNovels.Size = new System.Drawing.Size(520, 313);
            uxUploadedNovels.TabIndex = 5;
            uxUploadedNovels.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(uxCommentBox);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(526, 319);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Comments";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // uxCommentBox
            // 
            uxCommentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            uxCommentBox.FormattingEnabled = true;
            uxCommentBox.Location = new System.Drawing.Point(3, 3);
            uxCommentBox.Name = "uxCommentBox";
            uxCommentBox.Size = new System.Drawing.Size(520, 313);
            uxCommentBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.875F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.125F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(uxUserNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            tableLayoutPanel2.Size = new System.Drawing.Size(227, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(uxStatsLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(uxReveiewsPostedLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(uxNovelsReadLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(uxNovelsPostedLabel, 0, 3);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 40);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            tableLayoutPanel3.Size = new System.Drawing.Size(221, 401);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(uxChangePasswordButton, 0, 0);
            tableLayoutPanel4.Controls.Add(tabControl1, 0, 2);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(236, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new System.Drawing.Size(540, 444);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // UserView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UserView";
            Size = new System.Drawing.Size(800, 450);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}