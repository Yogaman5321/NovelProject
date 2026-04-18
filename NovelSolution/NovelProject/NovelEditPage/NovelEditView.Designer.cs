namespace NovelProject.NovelEditPage
{
    partial class NovelEditView
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
            uxChapterList = new System.Windows.Forms.ListBox();
            uxEditChapterButton = new System.Windows.Forms.Button();
            uxDescriptionBox = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            uxAddChapterButton = new System.Windows.Forms.Button();
            uxTagsBox = new System.Windows.Forms.ListBox();
            uxAddTagButton = new System.Windows.Forms.Button();
            uxDeleteButton = new System.Windows.Forms.Button();
            uxTagTexbox = new System.Windows.Forms.TextBox();
            uxTitleTextBox = new System.Windows.Forms.TextBox();
            uxSaveExitButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // uxChapterList
            // 
            uxChapterList.FormattingEnabled = true;
            uxChapterList.Location = new System.Drawing.Point(22, 79);
            uxChapterList.Name = "uxChapterList";
            uxChapterList.Size = new System.Drawing.Size(456, 319);
            uxChapterList.TabIndex = 10;
            // 
            // uxEditChapterButton
            // 
            uxEditChapterButton.Location = new System.Drawing.Point(290, 404);
            uxEditChapterButton.Name = "uxEditChapterButton";
            uxEditChapterButton.Size = new System.Drawing.Size(91, 23);
            uxEditChapterButton.TabIndex = 15;
            uxEditChapterButton.Text = "Edit Chapter";
            uxEditChapterButton.UseVisualStyleBackColor = true;
            uxEditChapterButton.Click += EditChapterButtonClick;
            // 
            // uxDescriptionBox
            // 
            uxDescriptionBox.Location = new System.Drawing.Point(497, 59);
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.Size = new System.Drawing.Size(282, 199);
            uxDescriptionBox.TabIndex = 14;
            uxDescriptionBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(497, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 16;
            label1.Text = "Description";
            // 
            // uxAddChapterButton
            // 
            uxAddChapterButton.Location = new System.Drawing.Point(387, 404);
            uxAddChapterButton.Name = "uxAddChapterButton";
            uxAddChapterButton.Size = new System.Drawing.Size(91, 23);
            uxAddChapterButton.TabIndex = 17;
            uxAddChapterButton.Text = "Add Chapter";
            uxAddChapterButton.UseVisualStyleBackColor = true;
            uxAddChapterButton.Click += AddChapterButtonClick;
            // 
            // uxTagsBox
            // 
            uxTagsBox.FormattingEnabled = true;
            uxTagsBox.Location = new System.Drawing.Point(497, 259);
            uxTagsBox.Name = "uxTagsBox";
            uxTagsBox.Size = new System.Drawing.Size(175, 139);
            uxTagsBox.TabIndex = 18;
            // 
            // uxAddTagButton
            // 
            uxAddTagButton.Location = new System.Drawing.Point(678, 324);
            uxAddTagButton.Name = "uxAddTagButton";
            uxAddTagButton.Size = new System.Drawing.Size(100, 23);
            uxAddTagButton.TabIndex = 19;
            uxAddTagButton.Text = "Add Tag";
            uxAddTagButton.UseVisualStyleBackColor = true;
            uxAddTagButton.Click += AddTagButtonClick;
            // 
            // uxDeleteButton
            // 
            uxDeleteButton.Location = new System.Drawing.Point(678, 375);
            uxDeleteButton.Name = "uxDeleteButton";
            uxDeleteButton.Size = new System.Drawing.Size(30, 23);
            uxDeleteButton.TabIndex = 20;
            uxDeleteButton.Text = "🗑";
            uxDeleteButton.UseVisualStyleBackColor = true;
            uxDeleteButton.Click += DeleteButtonClick;
            // 
            // uxTagTexbox
            // 
            uxTagTexbox.Location = new System.Drawing.Point(678, 295);
            uxTagTexbox.Name = "uxTagTexbox";
            uxTagTexbox.Size = new System.Drawing.Size(100, 23);
            uxTagTexbox.TabIndex = 21;
            // 
            // uxTitleTextBox
            // 
            uxTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            uxTitleTextBox.Location = new System.Drawing.Point(22, 33);
            uxTitleTextBox.Name = "uxTitleTextBox";
            uxTitleTextBox.Size = new System.Drawing.Size(456, 39);
            uxTitleTextBox.TabIndex = 22;
            // 
            // uxSaveExitButton
            // 
            uxSaveExitButton.Location = new System.Drawing.Point(691, 14);
            uxSaveExitButton.Name = "uxSaveExitButton";
            uxSaveExitButton.Size = new System.Drawing.Size(88, 23);
            uxSaveExitButton.TabIndex = 23;
            uxSaveExitButton.Text = "Save and Exit";
            uxSaveExitButton.UseVisualStyleBackColor = true;
            uxSaveExitButton.Click += SaveExitButtonClick;
            // 
            // NovelEditView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxSaveExitButton);
            Controls.Add(uxTitleTextBox);
            Controls.Add(uxTagTexbox);
            Controls.Add(uxDeleteButton);
            Controls.Add(uxAddTagButton);
            Controls.Add(uxTagsBox);
            Controls.Add(uxAddChapterButton);
            Controls.Add(label1);
            Controls.Add(uxEditChapterButton);
            Controls.Add(uxDescriptionBox);
            Controls.Add(uxChapterList);
            Name = "NovelEditView";
            Size = new System.Drawing.Size(800, 445);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListBox uxChapterList;
        private System.Windows.Forms.Button uxEditChapterButton;
        private System.Windows.Forms.RichTextBox uxDescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxAddChapterButton;
        private System.Windows.Forms.ListBox uxTagsBox;
        private System.Windows.Forms.Button uxAddTagButton;
        private System.Windows.Forms.Button uxDeleteButton;
        private System.Windows.Forms.TextBox uxTagTexbox;
        private System.Windows.Forms.TextBox uxTitleTextBox;
        private System.Windows.Forms.Button uxSaveExitButton;
    }
}
