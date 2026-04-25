namespace NovelProject.LeaderboardPage
{
    partial class LeaderboardView
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
            uxTabControl = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            uxTopReadList = new System.Windows.Forms.ListView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            uxTopRatedList = new System.Windows.Forms.ListView();
            tabPage2 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            uxNovelsPostedList = new System.Windows.Forms.ListView();
            uxTopChaptersGroup = new System.Windows.Forms.GroupBox();
            uxChaptersReadList = new System.Windows.Forms.ListView();
            uxTopNovelsGroup = new System.Windows.Forms.GroupBox();
            uxNovelsReadList = new System.Windows.Forms.ListView();
            uxTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            uxTopChaptersGroup.SuspendLayout();
            uxTopNovelsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // uxTabControl
            // 
            uxTabControl.Controls.Add(tabPage1);
            uxTabControl.Controls.Add(tabPage2);
            uxTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            uxTabControl.Location = new System.Drawing.Point(12, 3);
            uxTabControl.Name = "uxTabControl";
            uxTabControl.SelectedIndex = 0;
            uxTabControl.Size = new System.Drawing.Size(1011, 547);
            uxTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1003, 519);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Novels Leaderboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(uxTopReadList);
            groupBox2.Location = new System.Drawing.Point(523, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(491, 516);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Most Read Novels";
            // 
            // uxTopReadList
            // 
            uxTopReadList.Location = new System.Drawing.Point(0, 22);
            uxTopReadList.Name = "uxTopReadList";
            uxTopReadList.Size = new System.Drawing.Size(480, 494);
            uxTopReadList.TabIndex = 1;
            uxTopReadList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(uxTopRatedList);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(486, 516);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top Rated Novels";
            // 
            // uxTopRatedList
            // 
            uxTopRatedList.Location = new System.Drawing.Point(0, 22);
            uxTopRatedList.Name = "uxTopRatedList";
            uxTopRatedList.Size = new System.Drawing.Size(486, 494);
            uxTopRatedList.TabIndex = 0;
            uxTopRatedList.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(uxTopChaptersGroup);
            tabPage2.Controls.Add(uxTopNovelsGroup);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1003, 519);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User Leaderboard";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(uxNovelsPostedList);
            groupBox3.Location = new System.Drawing.Point(673, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(327, 519);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Top Novels Posted";
            // 
            // uxNovelsPostedList
            // 
            uxNovelsPostedList.Location = new System.Drawing.Point(0, 23);
            uxNovelsPostedList.Name = "uxNovelsPostedList";
            uxNovelsPostedList.Size = new System.Drawing.Size(326, 495);
            uxNovelsPostedList.TabIndex = 2;
            uxNovelsPostedList.UseCompatibleStateImageBehavior = false;
            // 
            // uxTopChaptersGroup
            // 
            uxTopChaptersGroup.Controls.Add(uxChaptersReadList);
            uxTopChaptersGroup.Location = new System.Drawing.Point(336, 1);
            uxTopChaptersGroup.Name = "uxTopChaptersGroup";
            uxTopChaptersGroup.Size = new System.Drawing.Size(330, 519);
            uxTopChaptersGroup.TabIndex = 3;
            uxTopChaptersGroup.TabStop = false;
            uxTopChaptersGroup.Text = "Top Chapters Read";
            // 
            // uxChaptersReadList
            // 
            uxChaptersReadList.Location = new System.Drawing.Point(0, 23);
            uxChaptersReadList.Name = "uxChaptersReadList";
            uxChaptersReadList.Size = new System.Drawing.Size(330, 495);
            uxChaptersReadList.TabIndex = 1;
            uxChaptersReadList.UseCompatibleStateImageBehavior = false;
            // 
            // uxTopNovelsGroup
            // 
            uxTopNovelsGroup.Controls.Add(uxNovelsReadList);
            uxTopNovelsGroup.Location = new System.Drawing.Point(0, 1);
            uxTopNovelsGroup.Name = "uxTopNovelsGroup";
            uxTopNovelsGroup.Size = new System.Drawing.Size(330, 518);
            uxTopNovelsGroup.TabIndex = 2;
            uxTopNovelsGroup.TabStop = false;
            uxTopNovelsGroup.Text = "Top Novels Read";
            // 
            // uxNovelsReadList
            // 
            uxNovelsReadList.Location = new System.Drawing.Point(0, 22);
            uxNovelsReadList.Name = "uxNovelsReadList";
            uxNovelsReadList.Size = new System.Drawing.Size(330, 496);
            uxNovelsReadList.TabIndex = 0;
            uxNovelsReadList.UseCompatibleStateImageBehavior = false;
            // 
            // LeaderboardView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxTabControl);
            Name = "LeaderboardView";
            Size = new System.Drawing.Size(1040, 567);
            uxTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            uxTopChaptersGroup.ResumeLayout(false);
            uxTopNovelsGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl uxTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox uxTopChaptersGroup;
        private System.Windows.Forms.GroupBox uxTopNovelsGroup;
        private System.Windows.Forms.ListView uxNovelsPostedList;
        private System.Windows.Forms.ListView uxChaptersReadList;
        private System.Windows.Forms.ListView uxNovelsReadList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView uxTopRatedList;
        private System.Windows.Forms.ListView uxTopReadList;
    }
}
