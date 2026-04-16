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
            UXNovelCardListBox = new System.Windows.Forms.ListBox();
            UXSearchBarTB = new System.Windows.Forms.TextBox();
            FilterComboBox = new System.Windows.Forms.ComboBox();
            UXFilterLabel = new System.Windows.Forms.Label();
            UxSearchLabel = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            UxTagLabel = new System.Windows.Forms.Label();
            UxIncludeTagCheckBox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // UXNovelCardListBox
            // 
            UXNovelCardListBox.FormattingEnabled = true;
            UXNovelCardListBox.Location = new System.Drawing.Point(3, 216);
            UXNovelCardListBox.Name = "UXNovelCardListBox";
            UXNovelCardListBox.Size = new System.Drawing.Size(1009, 624);
            UXNovelCardListBox.TabIndex = 0;
            // 
            // UXSearchBarTB
            // 
            UXSearchBarTB.Location = new System.Drawing.Point(621, 173);
            UXSearchBarTB.Name = "UXSearchBarTB";
            UXSearchBarTB.Size = new System.Drawing.Size(375, 27);
            UXSearchBarTB.TabIndex = 1;
            UXSearchBarTB.Text = "Search...";
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Items.AddRange(new object[] { "Most Read ", "Newest Releases", "Random Display ", "Highest Rating", "Recommended For You" });
            FilterComboBox.Location = new System.Drawing.Point(22, 173);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new System.Drawing.Size(151, 28);
            FilterComboBox.TabIndex = 4;
            // 
            // UXFilterLabel
            // 
            UXFilterLabel.AutoSize = true;
            UXFilterLabel.Location = new System.Drawing.Point(46, 146);
            UXFilterLabel.Name = "UXFilterLabel";
            UXFilterLabel.Size = new System.Drawing.Size(98, 20);
            UXFilterLabel.TabIndex = 5;
            UXFilterLabel.Text = "Filter Options";
            // 
            // UxSearchLabel
            // 
            UxSearchLabel.AutoSize = true;
            UxSearchLabel.Location = new System.Drawing.Point(720, 146);
            UxSearchLabel.Name = "UxSearchLabel";
            UxSearchLabel.Size = new System.Drawing.Size(195, 20);
            UxSearchLabel.TabIndex = 6;
            UxSearchLabel.Text = "Not including tag + filtering";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All Tags " });
            comboBox1.Location = new System.Drawing.Point(214, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // UxTagLabel
            // 
            UxTagLabel.AutoSize = true;
            UxTagLabel.Location = new System.Drawing.Point(271, 146);
            UxTagLabel.Name = "UxTagLabel";
            UxTagLabel.Size = new System.Drawing.Size(38, 20);
            UxTagLabel.TabIndex = 8;
            UxTagLabel.Text = "Tags";
            // 
            // UxIncludeTagCheckBox
            // 
            UxIncludeTagCheckBox.AutoSize = true;
            UxIncludeTagCheckBox.Location = new System.Drawing.Point(429, 176);
            UxIncludeTagCheckBox.Name = "UxIncludeTagCheckBox";
            UxIncludeTagCheckBox.Size = new System.Drawing.Size(176, 24);
            UxIncludeTagCheckBox.TabIndex = 9;
            UxIncludeTagCheckBox.Text = "Include Tags in Search";
            UxIncludeTagCheckBox.UseVisualStyleBackColor = true;
            UxIncludeTagCheckBox.CheckedChanged += UxIncludeTagCheckBox_CheckedChanged;
            // 
            // BrowserView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(UxIncludeTagCheckBox);
            Controls.Add(UxTagLabel);
            Controls.Add(comboBox1);
            Controls.Add(UxSearchLabel);
            Controls.Add(UXFilterLabel);
            Controls.Add(FilterComboBox);
            Controls.Add(UXSearchBarTB);
            Controls.Add(UXNovelCardListBox);
            Name = "BrowserView";
            Size = new System.Drawing.Size(1015, 843);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox UXNovelCardListBox;
        private System.Windows.Forms.TextBox UXSearchBarTB;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label UXFilterLabel;
        private System.Windows.Forms.Label UxSearchLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label UxTagLabel;
        private System.Windows.Forms.CheckBox UxIncludeTagCheckBox;
    }
}