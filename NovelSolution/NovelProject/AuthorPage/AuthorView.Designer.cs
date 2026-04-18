namespace NovelProject.AuthorPage
{
    partial class AuthorView
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
            uxNovelsLabel = new System.Windows.Forms.Label();
            uxAddNewButton = new System.Windows.Forms.Button();
            uxReadButton = new System.Windows.Forms.Button();
            uxEditButton = new System.Windows.Forms.Button();
            uxNovelList = new System.Windows.Forms.ListView();
            SuspendLayout();
            // 
            // uxNovelsLabel
            // 
            uxNovelsLabel.AutoSize = true;
            uxNovelsLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            uxNovelsLabel.Location = new System.Drawing.Point(17, 24);
            uxNovelsLabel.Name = "uxNovelsLabel";
            uxNovelsLabel.Size = new System.Drawing.Size(141, 32);
            uxNovelsLabel.TabIndex = 1;
            uxNovelsLabel.Text = "Your Novels";
            // 
            // uxAddNewButton
            // 
            uxAddNewButton.Location = new System.Drawing.Point(533, 415);
            uxAddNewButton.Name = "uxAddNewButton";
            uxAddNewButton.Size = new System.Drawing.Size(75, 23);
            uxAddNewButton.TabIndex = 2;
            uxAddNewButton.Text = "Add New";
            uxAddNewButton.UseVisualStyleBackColor = true;
            uxAddNewButton.Click += AddNewButtonClick;
            // 
            // uxReadButton
            // 
            uxReadButton.Location = new System.Drawing.Point(695, 415);
            uxReadButton.Name = "uxReadButton";
            uxReadButton.Size = new System.Drawing.Size(75, 23);
            uxReadButton.TabIndex = 3;
            uxReadButton.Text = "Read";
            uxReadButton.UseVisualStyleBackColor = true;
            uxReadButton.Click += ReadButtonClick;
            // 
            // uxEditButton
            // 
            uxEditButton.Location = new System.Drawing.Point(614, 415);
            uxEditButton.Name = "uxEditButton";
            uxEditButton.Size = new System.Drawing.Size(75, 23);
            uxEditButton.TabIndex = 4;
            uxEditButton.Text = "Edit";
            uxEditButton.UseVisualStyleBackColor = true;
            uxEditButton.Click += EditButtonClick;
            // 
            // uxNovelList
            // 
            uxNovelList.Location = new System.Drawing.Point(17, 59);
            uxNovelList.Name = "uxNovelList";
            uxNovelList.Size = new System.Drawing.Size(510, 379);
            uxNovelList.TabIndex = 5;
            uxNovelList.UseCompatibleStateImageBehavior = false;
            // 
            // AuthorView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxNovelList);
            Controls.Add(uxEditButton);
            Controls.Add(uxReadButton);
            Controls.Add(uxAddNewButton);
            Controls.Add(uxNovelsLabel);
            Name = "AuthorView";
            Size = new System.Drawing.Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label uxNovelsLabel;
        private System.Windows.Forms.Button uxAddNewButton;
        private System.Windows.Forms.Button uxReadButton;
        private System.Windows.Forms.Button uxEditButton;
        private System.Windows.Forms.ListView uxNovelList;
    }
}