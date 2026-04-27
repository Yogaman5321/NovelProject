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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new System.Drawing.Point(3, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new System.Drawing.Size(250, 48);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome, user";
            // 
            // UxLastReadTB
            // 
            UxLastReadTB.AutoSize = true;
            UxLastReadTB.Location = new System.Drawing.Point(3, 48);
            UxLastReadTB.Name = "UxLastReadTB";
            UxLastReadTB.Size = new System.Drawing.Size(168, 15);
            UxLastReadTB.TabIndex = 1;
            UxLastReadTB.Text = "Pick up where you last left off?";
            // 
            // UxLastReadListBox
            // 
            UxLastReadListBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            UxLastReadListBox.FormattingEnabled = true;
            UxLastReadListBox.Location = new System.Drawing.Point(3, 65);
            UxLastReadListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            UxLastReadListBox.Name = "UxLastReadListBox";
            UxLastReadListBox.Size = new System.Drawing.Size(342, 514);
            UxLastReadListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(351, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 15);
            label1.TabIndex = 4;
            label1.Text = "Or try something new?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(351, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 15);
            label2.TabIndex = 5;
            label2.Text = "Similar users liked:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(699, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 15);
            label3.TabIndex = 6;
            label3.Text = "Newest additions:";
            // 
            // similarUsersPanel
            // 
            similarUsersPanel.AutoScroll = true;
            similarUsersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            similarUsersPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            similarUsersPanel.Location = new System.Drawing.Point(351, 65);
            similarUsersPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            similarUsersPanel.Name = "similarUsersPanel";
            similarUsersPanel.Size = new System.Drawing.Size(342, 518);
            similarUsersPanel.TabIndex = 7;
            similarUsersPanel.WrapContents = false;
            // 
            // newestAdditionsPanel
            // 
            newestAdditionsPanel.AutoScroll = true;
            newestAdditionsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            newestAdditionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newestAdditionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            newestAdditionsPanel.Location = new System.Drawing.Point(699, 65);
            newestAdditionsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            newestAdditionsPanel.Name = "newestAdditionsPanel";
            newestAdditionsPanel.Size = new System.Drawing.Size(342, 518);
            newestAdditionsPanel.TabIndex = 8;
            newestAdditionsPanel.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(UxLastReadTB, 0, 1);
            tableLayoutPanel1.Controls.Add(similarUsersPanel, 1, 2);
            tableLayoutPanel1.Controls.Add(UxLastReadListBox, 0, 2);
            tableLayoutPanel1.Controls.Add(newestAdditionsPanel, 2, 2);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(WelcomeLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1044, 585);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "HomeView";
            Size = new System.Drawing.Size(1044, 585);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}