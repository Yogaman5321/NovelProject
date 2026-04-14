namespace NovelProject
{
    partial class MainView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            homePageButton = new System.Windows.Forms.ToolStripButton();
            browseNovelsButton = new System.Windows.Forms.ToolStripButton();
            userProfileButton = new System.Windows.Forms.ToolStripButton();
            usernameLabel = new System.Windows.Forms.ToolStripLabel();
            logOutButton = new System.Windows.Forms.ToolStripButton();
            logInButton = new System.Windows.Forms.ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { homePageButton, browseNovelsButton, userProfileButton, usernameLabel, logOutButton, logInButton });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1036, 30);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // homePageButton
            // 
            homePageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            homePageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            homePageButton.Image = (System.Drawing.Image)resources.GetObject("homePageButton.Image");
            homePageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            homePageButton.Name = "homePageButton";
            homePageButton.Size = new System.Drawing.Size(61, 27);
            homePageButton.Text = "Home";
            // 
            // browseNovelsButton
            // 
            browseNovelsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            browseNovelsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            browseNovelsButton.Image = (System.Drawing.Image)resources.GetObject("browseNovelsButton.Image");
            browseNovelsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            browseNovelsButton.Name = "browseNovelsButton";
            browseNovelsButton.Size = new System.Drawing.Size(126, 27);
            browseNovelsButton.Text = "Browse Novels";
            // 
            // userProfileButton
            // 
            userProfileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            userProfileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            userProfileButton.Image = (System.Drawing.Image)resources.GetObject("userProfileButton.Image");
            userProfileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            userProfileButton.Name = "userProfileButton";
            userProfileButton.Size = new System.Drawing.Size(105, 27);
            userProfileButton.Text = "View Profile";
            // 
            // usernameLabel
            // 
            usernameLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(165, 27);
            usernameLabel.Text = "Username Goes Here";
            // 
            // logOutButton
            // 
            logOutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            logOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            logOutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            logOutButton.Image = (System.Drawing.Image)resources.GetObject("logOutButton.Image");
            logOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new System.Drawing.Size(76, 27);
            logOutButton.Text = "Log Out";
            // 
            // logInButton
            // 
            logInButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            logInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            logInButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            logInButton.Image = (System.Drawing.Image)resources.GetObject("logInButton.Image");
            logInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            logInButton.Name = "logInButton";
            logInButton.Size = new System.Drawing.Size(62, 27);
            logInButton.Text = "Log In";
            // 
            // MainView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1036, 600);
            Controls.Add(toolStrip1);
            Name = "MainView";
            Text = "MainView";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton homePageButton;
        private System.Windows.Forms.ToolStripButton browseNovelsButton;
        private System.Windows.Forms.ToolStripButton userProfileButton;
        private System.Windows.Forms.ToolStripLabel usernameLabel;
        private System.Windows.Forms.ToolStripButton logInButton;
        private System.Windows.Forms.ToolStripButton logOutButton;
    }
}