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
            browserListView = new System.Windows.Forms.ListView();
            uxSearchButton = new System.Windows.Forms.Button();
            otherFilterBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tagBox = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // uxSearchLabel
            // 
            uxSearchLabel.AutoSize = true;
            uxSearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxSearchLabel.Location = new System.Drawing.Point(19, 25);
            uxSearchLabel.Name = "uxSearchLabel";
            uxSearchLabel.Size = new System.Drawing.Size(100, 28);
            uxSearchLabel.TabIndex = 0;
            uxSearchLabel.Text = "Search By:";
            // 
            // uxSearchBar
            // 
            uxSearchBar.Location = new System.Drawing.Point(19, 57);
            uxSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxSearchBar.Name = "uxSearchBar";
            uxSearchBar.Size = new System.Drawing.Size(507, 27);
            uxSearchBar.TabIndex = 1;
            // 
            // uxRadio1
            // 
            uxRadio1.AutoSize = true;
            uxRadio1.Location = new System.Drawing.Point(720, 64);
            uxRadio1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxRadio1.Name = "uxRadio1";
            uxRadio1.Size = new System.Drawing.Size(59, 24);
            uxRadio1.TabIndex = 2;
            uxRadio1.TabStop = true;
            uxRadio1.Text = "Title";
            uxRadio1.UseVisualStyleBackColor = true;
            // 
            // uxRadio2
            // 
            uxRadio2.AutoSize = true;
            uxRadio2.Location = new System.Drawing.Point(785, 64);
            uxRadio2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxRadio2.Name = "uxRadio2";
            uxRadio2.Size = new System.Drawing.Size(75, 24);
            uxRadio2.TabIndex = 3;
            uxRadio2.TabStop = true;
            uxRadio2.Text = "Author";
            uxRadio2.UseVisualStyleBackColor = true;
            // 
            // browserListView
            // 
            browserListView.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            browserListView.Location = new System.Drawing.Point(19, 96);
            browserListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            browserListView.Name = "browserListView";
            browserListView.Size = new System.Drawing.Size(630, 425);
            browserListView.TabIndex = 5;
            browserListView.UseCompatibleStateImageBehavior = false;
            // 
            // uxSearchButton
            // 
            uxSearchButton.Location = new System.Drawing.Point(544, 57);
            uxSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new System.Drawing.Size(105, 31);
            uxSearchButton.TabIndex = 6;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = true;
            uxSearchButton.Click += SearchButtonClick;
            // 
            // otherFilterBox
            // 
            otherFilterBox.FormattingEnabled = true;
            otherFilterBox.Location = new System.Drawing.Point(731, 345);
            otherFilterBox.Name = "otherFilterBox";
            otherFilterBox.Size = new System.Drawing.Size(151, 28);
            otherFilterBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(655, 345);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 28);
            label1.TabIndex = 8;
            label1.Text = "Other:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(655, 138);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 28);
            label2.TabIndex = 10;
            label2.Text = "Genre:";
            // 
            // tagBox
            // 
            tagBox.FormattingEnabled = true;
            tagBox.Location = new System.Drawing.Point(731, 138);
            tagBox.Name = "tagBox";
            tagBox.Size = new System.Drawing.Size(151, 28);
            tagBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(713, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 28);
            label3.TabIndex = 11;
            label3.Text = "Using:";
            // 
            // BrowserView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tagBox);
            Controls.Add(label1);
            Controls.Add(otherFilterBox);
            Controls.Add(uxSearchButton);
            Controls.Add(browserListView);
            Controls.Add(uxRadio2);
            Controls.Add(uxRadio1);
            Controls.Add(uxSearchBar);
            Controls.Add(uxSearchLabel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "BrowserView";
            Size = new System.Drawing.Size(914, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label uxSearchLabel;
        private System.Windows.Forms.TextBox uxSearchBar;
        private System.Windows.Forms.RadioButton uxRadio1;
        private System.Windows.Forms.RadioButton uxRadio2;
        private System.Windows.Forms.ListView browserListView;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.ComboBox otherFilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tagBox;
        private System.Windows.Forms.Label label3;
    }
}