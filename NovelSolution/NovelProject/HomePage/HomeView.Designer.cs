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
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Location = new System.Drawing.Point(52, 54);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new System.Drawing.Size(105, 20);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome, user";
            // 
            // UxLastReadTB
            // 
            UxLastReadTB.AutoSize = true;
            UxLastReadTB.Location = new System.Drawing.Point(33, 181);
            UxLastReadTB.Name = "UxLastReadTB";
            UxLastReadTB.Size = new System.Drawing.Size(211, 20);
            UxLastReadTB.TabIndex = 1;
            UxLastReadTB.Text = "Pick up where you last left off?";
            // 
            // UxLastReadListBox
            // 
            UxLastReadListBox.FormattingEnabled = true;
            UxLastReadListBox.Location = new System.Drawing.Point(16, 213);
            UxLastReadListBox.Name = "UxLastReadListBox";
            UxLastReadListBox.Size = new System.Drawing.Size(1142, 504);
            UxLastReadListBox.TabIndex = 2;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}