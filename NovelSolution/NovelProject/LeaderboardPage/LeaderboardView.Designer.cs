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
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            uxTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            uxTopChaptersGroup.SuspendLayout();
            uxTopNovelsGroup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uxTabControl
            // 
            uxTabControl.Controls.Add(tabPage1);
            uxTabControl.Controls.Add(tabPage2);
            uxTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            uxTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            uxTabControl.Location = new System.Drawing.Point(3, 3);
            uxTabControl.Name = "uxTabControl";
            uxTabControl.SelectedIndex = 0;
            uxTabControl.Size = new System.Drawing.Size(1034, 561);
            uxTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1026, 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Novels Leaderboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1020, 527);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(uxTopReadList);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(513, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(504, 521);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Most Read Novels";
            // 
            // uxTopReadList
            // 
            uxTopReadList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxTopReadList.Location = new System.Drawing.Point(3, 19);
            uxTopReadList.Name = "uxTopReadList";
            uxTopReadList.Size = new System.Drawing.Size(498, 499);
            uxTopReadList.TabIndex = 1;
            uxTopReadList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(uxTopRatedList);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(504, 521);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top Rated Novels";
            // 
            // uxTopRatedList
            // 
            uxTopRatedList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxTopRatedList.Location = new System.Drawing.Point(3, 19);
            uxTopRatedList.Name = "uxTopRatedList";
            uxTopRatedList.Size = new System.Drawing.Size(498, 499);
            uxTopRatedList.TabIndex = 0;
            uxTopRatedList.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1026, 533);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User Leaderboard";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(uxNovelsPostedList);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox3.Location = new System.Drawing.Point(683, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(334, 521);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Top Novels Posted";
            // 
            // uxNovelsPostedList
            // 
            uxNovelsPostedList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxNovelsPostedList.Location = new System.Drawing.Point(3, 19);
            uxNovelsPostedList.Name = "uxNovelsPostedList";
            uxNovelsPostedList.Size = new System.Drawing.Size(328, 499);
            uxNovelsPostedList.TabIndex = 2;
            uxNovelsPostedList.UseCompatibleStateImageBehavior = false;
            // 
            // uxTopChaptersGroup
            // 
            uxTopChaptersGroup.Controls.Add(uxChaptersReadList);
            uxTopChaptersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            uxTopChaptersGroup.Location = new System.Drawing.Point(343, 3);
            uxTopChaptersGroup.Name = "uxTopChaptersGroup";
            uxTopChaptersGroup.Size = new System.Drawing.Size(334, 521);
            uxTopChaptersGroup.TabIndex = 3;
            uxTopChaptersGroup.TabStop = false;
            uxTopChaptersGroup.Text = "Top Chapters Read";
            // 
            // uxChaptersReadList
            // 
            uxChaptersReadList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxChaptersReadList.Location = new System.Drawing.Point(3, 19);
            uxChaptersReadList.Name = "uxChaptersReadList";
            uxChaptersReadList.Size = new System.Drawing.Size(328, 499);
            uxChaptersReadList.TabIndex = 1;
            uxChaptersReadList.UseCompatibleStateImageBehavior = false;
            // 
            // uxTopNovelsGroup
            // 
            uxTopNovelsGroup.Controls.Add(uxNovelsReadList);
            uxTopNovelsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            uxTopNovelsGroup.Location = new System.Drawing.Point(3, 3);
            uxTopNovelsGroup.Name = "uxTopNovelsGroup";
            uxTopNovelsGroup.Size = new System.Drawing.Size(334, 521);
            uxTopNovelsGroup.TabIndex = 2;
            uxTopNovelsGroup.TabStop = false;
            uxTopNovelsGroup.Text = "Top Novels Read";
            // 
            // uxNovelsReadList
            // 
            uxNovelsReadList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxNovelsReadList.Location = new System.Drawing.Point(3, 19);
            uxNovelsReadList.Name = "uxNovelsReadList";
            uxNovelsReadList.Size = new System.Drawing.Size(328, 499);
            uxNovelsReadList.TabIndex = 0;
            uxNovelsReadList.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(uxTabControl, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1040, 567);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(groupBox3, 2, 0);
            tableLayoutPanel3.Controls.Add(uxTopNovelsGroup, 0, 0);
            tableLayoutPanel3.Controls.Add(uxTopChaptersGroup, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(1020, 527);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // LeaderboardView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LeaderboardView";
            Size = new System.Drawing.Size(1040, 567);
            uxTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            uxTopChaptersGroup.ResumeLayout(false);
            uxTopNovelsGroup.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
