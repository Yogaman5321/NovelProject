namespace NovelProject.BrowserPage
{
    partial class BrowserView
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
            uxSearchLabel = new System.Windows.Forms.Label();
            uxSearchBar = new System.Windows.Forms.TextBox();
            uxRadio1 = new System.Windows.Forms.RadioButton();
            uxRadio2 = new System.Windows.Forms.RadioButton();
            resultsPanel = new System.Windows.Forms.FlowLayoutPanel();
            uxSearchButton = new System.Windows.Forms.Button();
            otherFilterBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tagBox = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // uxSearchLabel
            // 
            uxSearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxSearchLabel.AutoSize = true;
            uxSearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxSearchLabel.Location = new System.Drawing.Point(3, 0);
            uxSearchLabel.Name = "uxSearchLabel";
            uxSearchLabel.Size = new System.Drawing.Size(81, 37);
            uxSearchLabel.TabIndex = 0;
            uxSearchLabel.Text = "Search By:";
            uxSearchLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // uxSearchBar
            // 
            uxSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            uxSearchBar.Location = new System.Drawing.Point(3, 40);
            uxSearchBar.Name = "uxSearchBar";
            uxSearchBar.Size = new System.Drawing.Size(523, 23);
            uxSearchBar.TabIndex = 1;
            // 
            // uxRadio1
            // 
            uxRadio1.AutoSize = true;
            uxRadio1.Location = new System.Drawing.Point(3, 3);
            uxRadio1.Name = "uxRadio1";
            uxRadio1.Size = new System.Drawing.Size(48, 19);
            uxRadio1.TabIndex = 2;
            uxRadio1.TabStop = true;
            uxRadio1.Text = "Title";
            uxRadio1.UseVisualStyleBackColor = true;
            // 
            // uxRadio2
            // 
            uxRadio2.AutoSize = true;
            uxRadio2.Location = new System.Drawing.Point(71, 3);
            uxRadio2.Name = "uxRadio2";
            uxRadio2.Size = new System.Drawing.Size(62, 19);
            uxRadio2.TabIndex = 3;
            uxRadio2.TabStop = true;
            uxRadio2.Text = "Author";
            uxRadio2.UseVisualStyleBackColor = true;
            // 
            // resultsPanel
            // 
            resultsPanel.AutoScroll = true;
            resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            resultsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            resultsPanel.Location = new System.Drawing.Point(36, 79);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new System.Drawing.Size(650, 447);
            resultsPanel.TabIndex = 5;
            resultsPanel.WrapContents = false;
            // 
            // uxSearchButton
            // 
            uxSearchButton.Location = new System.Drawing.Point(532, 40);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new System.Drawing.Size(92, 23);
            uxSearchButton.TabIndex = 6;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = true;
            uxSearchButton.Click += SearchButtonClick;
            // 
            // otherFilterBox
            // 
            otherFilterBox.FormattingEnabled = true;
            otherFilterBox.Location = new System.Drawing.Point(83, 80);
            otherFilterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            otherFilterBox.Name = "otherFilterBox";
            otherFilterBox.Size = new System.Drawing.Size(133, 23);
            otherFilterBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(3, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 21);
            label1.TabIndex = 8;
            label1.Text = "Other:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(3, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 21);
            label2.TabIndex = 10;
            label2.Text = "Genre:";
            // 
            // tagBox
            // 
            tagBox.FormattingEnabled = true;
            tagBox.Location = new System.Drawing.Point(83, 41);
            tagBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tagBox.Name = "tagBox";
            tagBox.Size = new System.Drawing.Size(133, 23);
            tagBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 21);
            label3.TabIndex = 11;
            label3.Text = "Using:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.911181F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.08882F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(resultsPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36673F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.63327F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new System.Drawing.Size(978, 565);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.50944F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.4905663F));
            tableLayoutPanel2.Controls.Add(uxSearchBar, 0, 1);
            tableLayoutPanel2.Controls.Add(uxSearchButton, 1, 1);
            tableLayoutPanel2.Controls.Add(uxSearchLabel, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(36, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.8571434F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.1428566F));
            tableLayoutPanel2.Size = new System.Drawing.Size(650, 70);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.26855F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.7314453F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 2);
            tableLayoutPanel3.Controls.Add(otherFilterBox, 1, 2);
            tableLayoutPanel3.Controls.Add(tagBox, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(692, 79);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 369F));
            tableLayoutPanel3.Size = new System.Drawing.Size(283, 447);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(uxRadio2, 1, 0);
            tableLayoutPanel4.Controls.Add(uxRadio1, 0, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(83, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(136, 33);
            tableLayoutPanel4.TabIndex = 12;
            // 
            // BrowserView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "BrowserView";
            Size = new System.Drawing.Size(978, 565);
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

        private System.Windows.Forms.Label uxSearchLabel;
        private System.Windows.Forms.TextBox uxSearchBar;
        private System.Windows.Forms.RadioButton uxRadio1;
        private System.Windows.Forms.RadioButton uxRadio2;
        private System.Windows.Forms.FlowLayoutPanel resultsPanel;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.ComboBox otherFilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tagBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}