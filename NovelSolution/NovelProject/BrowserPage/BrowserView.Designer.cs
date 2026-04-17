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
            uxSerachBar = new System.Windows.Forms.TextBox();
            uxRadio1 = new System.Windows.Forms.RadioButton();
            uxRadio2 = new System.Windows.Forms.RadioButton();
            uxRadio3 = new System.Windows.Forms.RadioButton();
            uxListView = new System.Windows.Forms.ListView();
            uxSearchButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // uxSearchLabel
            // 
            uxSearchLabel.AutoSize = true;
            uxSearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxSearchLabel.Location = new System.Drawing.Point(17, 19);
            uxSearchLabel.Name = "uxSearchLabel";
            uxSearchLabel.Size = new System.Drawing.Size(57, 21);
            uxSearchLabel.TabIndex = 0;
            uxSearchLabel.Text = "Search";
            // 
            // uxSerachBar
            // 
            uxSerachBar.Location = new System.Drawing.Point(17, 43);
            uxSerachBar.Name = "uxSerachBar";
            uxSerachBar.Size = new System.Drawing.Size(484, 23);
            uxSerachBar.TabIndex = 1;
            // 
            // uxRadio1
            // 
            uxRadio1.AutoSize = true;
            uxRadio1.Location = new System.Drawing.Point(507, 44);
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
            uxRadio2.Location = new System.Drawing.Point(561, 44);
            uxRadio2.Name = "uxRadio2";
            uxRadio2.Size = new System.Drawing.Size(62, 19);
            uxRadio2.TabIndex = 3;
            uxRadio2.TabStop = true;
            uxRadio2.Text = "Author";
            uxRadio2.UseVisualStyleBackColor = true;
            // 
            // uxRadio3
            // 
            uxRadio3.AutoSize = true;
            uxRadio3.Location = new System.Drawing.Point(629, 44);
            uxRadio3.Name = "uxRadio3";
            uxRadio3.Size = new System.Drawing.Size(44, 19);
            uxRadio3.TabIndex = 4;
            uxRadio3.TabStop = true;
            uxRadio3.Text = "Tag";
            uxRadio3.UseVisualStyleBackColor = true;
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
            // uxListView
            // 
            uxListView.Location = new System.Drawing.Point(17, 72);
            uxListView.Name = "uxListView";
            uxListView.Size = new System.Drawing.Size(754, 320);
            uxListView.TabIndex = 5;
            uxListView.UseCompatibleStateImageBehavior = false;
            // 
            // uxSearchButton
            // 
            uxSearchButton.Location = new System.Drawing.Point(679, 42);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new System.Drawing.Size(92, 23);
            uxSearchButton.TabIndex = 6;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = true;
            uxSearchButton.Click += SearchButtonClick;
            // 
            // BrowserView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxSearchButton);
            Controls.Add(uxListView);
            Controls.Add(uxRadio3);
            Controls.Add(uxRadio2);
            Controls.Add(uxRadio1);
            Controls.Add(uxSerachBar);
            Controls.Add(uxSearchLabel);
            Name = "BrowserView";
            Size = new System.Drawing.Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label uxSearchLabel;
        private System.Windows.Forms.TextBox uxSerachBar;
        private System.Windows.Forms.RadioButton uxRadio1;
        private System.Windows.Forms.RadioButton uxRadio2;
        private System.Windows.Forms.RadioButton uxRadio3;
        private System.Windows.Forms.ListView uxListView;
        private System.Windows.Forms.Button uxSearchButton;
    }
}