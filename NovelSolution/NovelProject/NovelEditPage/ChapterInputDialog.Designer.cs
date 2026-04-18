namespace NovelProject.NovelEditPage
{
    partial class ChapterInputDialog
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
            uxTitleTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            uxFileTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            uxBrowseButton = new System.Windows.Forms.Button();
            uxCancelButton = new System.Windows.Forms.Button();
            uxOkButton = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // uxTitleTextBox
            // 
            uxTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxTitleTextBox.Location = new System.Drawing.Point(30, 48);
            uxTitleTextBox.Name = "uxTitleTextBox";
            uxTitleTextBox.Size = new System.Drawing.Size(372, 29);
            uxTitleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            label1.Location = new System.Drawing.Point(30, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // uxFileTextBox
            // 
            uxFileTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            uxFileTextBox.Location = new System.Drawing.Point(30, 112);
            uxFileTextBox.Name = "uxFileTextBox";
            uxFileTextBox.ReadOnly = true;
            uxFileTextBox.Size = new System.Drawing.Size(299, 29);
            uxFileTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            label2.Location = new System.Drawing.Point(30, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "File";
            // 
            // uxBrowseButton
            // 
            uxBrowseButton.Location = new System.Drawing.Point(335, 112);
            uxBrowseButton.Name = "uxBrowseButton";
            uxBrowseButton.Size = new System.Drawing.Size(67, 29);
            uxBrowseButton.TabIndex = 4;
            uxBrowseButton.Text = "Browse";
            uxBrowseButton.UseVisualStyleBackColor = true;
            uxBrowseButton.Click += BrowseButtonClick;
            // 
            // uxCancelButton
            // 
            uxCancelButton.Location = new System.Drawing.Point(80, 174);
            uxCancelButton.Name = "uxCancelButton";
            uxCancelButton.Size = new System.Drawing.Size(75, 29);
            uxCancelButton.TabIndex = 5;
            uxCancelButton.Text = "Cancel";
            uxCancelButton.UseVisualStyleBackColor = true;
            uxCancelButton.Click += CancelButtonClick;
            // 
            // uxOkButton
            // 
            uxOkButton.Location = new System.Drawing.Point(263, 174);
            uxOkButton.Name = "uxOkButton";
            uxOkButton.Size = new System.Drawing.Size(75, 29);
            uxOkButton.TabIndex = 6;
            uxOkButton.Text = "OK";
            uxOkButton.UseVisualStyleBackColor = true;
            uxOkButton.Click += OkButtonClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ChapterInputDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 222);
            Controls.Add(uxOkButton);
            Controls.Add(uxCancelButton);
            Controls.Add(uxBrowseButton);
            Controls.Add(label2);
            Controls.Add(uxFileTextBox);
            Controls.Add(label1);
            Controls.Add(uxTitleTextBox);
            Name = "ChapterInputDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox uxTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxFileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxBrowseButton;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Button uxOkButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
