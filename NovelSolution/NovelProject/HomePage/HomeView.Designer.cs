namespace NovelProject.HomePage
{
    partial class HomeView
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
            WelcomeLabel = new System.Windows.Forms.Label();
            UxLastReadTB = new System.Windows.Forms.Label();
            UxLastReadListBox = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            similarUsersPanel = new System.Windows.Forms.FlowLayoutPanel();
            newestAdditionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new System.Drawing.Point(19, 16);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new System.Drawing.Size(306, 58);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome, user";
            // 
            // UxLastReadTB
            // 
            UxLastReadTB.AutoSize = true;
            UxLastReadTB.Location = new System.Drawing.Point(19, 88);
            UxLastReadTB.Name = "UxLastReadTB";
            UxLastReadTB.Size = new System.Drawing.Size(211, 20);
            UxLastReadTB.TabIndex = 1;
            UxLastReadTB.Text = "Pick up where you last left off?";
            // 
            // UxLastReadListBox
            // 
            UxLastReadListBox.FormattingEnabled = true;
            UxLastReadListBox.Location = new System.Drawing.Point(19, 111);
            UxLastReadListBox.Name = "UxLastReadListBox";
            UxLastReadListBox.Size = new System.Drawing.Size(286, 604);
            UxLastReadListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(311, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 20);
            label1.TabIndex = 4;
            label1.Text = "Or try something new?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(311, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 20);
            label2.TabIndex = 5;
            label2.Text = "Similar users liked:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(713, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 20);
            label3.TabIndex = 6;
            label3.Text = "Newest additions:";
            // 
            // similarUsersPanel
            // 
            similarUsersPanel.AutoScroll = true;
            similarUsersPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            similarUsersPanel.WrapContents = false;
            similarUsersPanel.Location = new System.Drawing.Point(311, 111);
            similarUsersPanel.Name = "similarUsersPanel";
            similarUsersPanel.Size = new System.Drawing.Size(396, 604);
            similarUsersPanel.TabIndex = 7;
            // 
            // newestAdditionsPanel
            // 
            newestAdditionsPanel.AutoScroll = true;
            newestAdditionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            newestAdditionsPanel.WrapContents = false;
            newestAdditionsPanel.Location = new System.Drawing.Point(713, 111);
            newestAdditionsPanel.Name = "newestAdditionsPanel";
            newestAdditionsPanel.Size = new System.Drawing.Size(380, 604);
            newestAdditionsPanel.TabIndex = 8;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(newestAdditionsPanel);
            Controls.Add(similarUsersPanel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UxLastReadListBox);
            Controls.Add(UxLastReadTB);
            Controls.Add(WelcomeLabel);
            Name = "HomeView";
            Size = new System.Drawing.Size(1184, 740);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UxLastReadTB;
        private System.Windows.Forms.ListBox UxLastReadListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel similarUsersPanel;
        private System.Windows.Forms.FlowLayoutPanel newestAdditionsPanel;
    }
}