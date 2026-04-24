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
            uxEditChapterButton = new System.Windows.Forms.Button();
            uxDescriptionBox = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            uxAddChapterButton = new System.Windows.Forms.Button();
            uxTagsBox = new System.Windows.Forms.ListBox();
            uxAddTagButton = new System.Windows.Forms.Button();
            uxDeleteButton = new System.Windows.Forms.Button();
            uxTitleTextBox = new System.Windows.Forms.TextBox();
            uxSaveExitButton = new System.Windows.Forms.Button();
            uxTitleLabel = new System.Windows.Forms.Label();
            uxChapterList = new System.Windows.Forms.ListView();
            uxUpButton = new System.Windows.Forms.Button();
            uxDownButton = new System.Windows.Forms.Button();
            uxChapterDelete = new System.Windows.Forms.Button();
            uxTagsToAddBox = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            authorTextBox = new System.Windows.Forms.TextBox();
            authorCheckBox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // uxEditChapterButton
            // 
            uxEditChapterButton.Location = new System.Drawing.Point(289, 593);
            uxEditChapterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxEditChapterButton.Name = "uxEditChapterButton";
            uxEditChapterButton.Size = new System.Drawing.Size(104, 31);
            uxEditChapterButton.TabIndex = 15;
            uxEditChapterButton.Text = "Edit Chapter";
            uxEditChapterButton.UseVisualStyleBackColor = true;
            uxEditChapterButton.Click += EditChapterButtonClick;
            // 
            // uxDescriptionBox
            // 
            uxDescriptionBox.Location = new System.Drawing.Point(691, 99);
            uxDescriptionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.Size = new System.Drawing.Size(322, 202);
            uxDescriptionBox.TabIndex = 14;
            uxDescriptionBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(691, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 20);
            label1.TabIndex = 16;
            label1.Text = "Description";
            // 
            // uxAddChapterButton
            // 
            uxAddChapterButton.Location = new System.Drawing.Point(400, 593);
            uxAddChapterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxAddChapterButton.Name = "uxAddChapterButton";
            uxAddChapterButton.Size = new System.Drawing.Size(104, 31);
            uxAddChapterButton.TabIndex = 17;
            uxAddChapterButton.Text = "Add Chapter";
            uxAddChapterButton.UseVisualStyleBackColor = true;
            uxAddChapterButton.Click += AddChapterButtonClick;
            // 
            // uxTagsBox
            // 
            uxTagsBox.FormattingEnabled = true;
            uxTagsBox.Location = new System.Drawing.Point(856, 345);
            uxTagsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxTagsBox.Name = "uxTagsBox";
            uxTagsBox.Size = new System.Drawing.Size(157, 224);
            uxTagsBox.TabIndex = 18;
            // 
            // uxAddTagButton
            // 
            uxAddTagButton.Location = new System.Drawing.Point(736, 577);
            uxAddTagButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxAddTagButton.Name = "uxAddTagButton";
            uxAddTagButton.Size = new System.Drawing.Size(114, 31);
            uxAddTagButton.TabIndex = 19;
            uxAddTagButton.Text = "Add Tag";
            uxAddTagButton.UseVisualStyleBackColor = true;
            uxAddTagButton.Click += AddTagButtonClick;
            // 
            // uxDeleteButton
            // 
            uxDeleteButton.Location = new System.Drawing.Point(856, 577);
            uxDeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxDeleteButton.Name = "uxDeleteButton";
            uxDeleteButton.Size = new System.Drawing.Size(34, 31);
            uxDeleteButton.TabIndex = 20;
            uxDeleteButton.Text = "🗑";
            uxDeleteButton.UseVisualStyleBackColor = true;
            uxDeleteButton.Click += DeleteButtonClick;
            // 
            // uxTitleTextBox
            // 
            uxTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            uxTitleTextBox.Location = new System.Drawing.Point(24, 53);
            uxTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxTitleTextBox.Name = "uxTitleTextBox";
            uxTitleTextBox.Size = new System.Drawing.Size(521, 38);
            uxTitleTextBox.TabIndex = 22;
            // 
            // uxSaveExitButton
            // 
            uxSaveExitButton.Location = new System.Drawing.Point(913, 39);
            uxSaveExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxSaveExitButton.Name = "uxSaveExitButton";
            uxSaveExitButton.Size = new System.Drawing.Size(101, 31);
            uxSaveExitButton.TabIndex = 23;
            uxSaveExitButton.Text = "Save and Exit";
            uxSaveExitButton.UseVisualStyleBackColor = true;
            uxSaveExitButton.Click += SaveExitButtonClick;
            // 
            // uxTitleLabel
            // 
            uxTitleLabel.AutoSize = true;
            uxTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            uxTitleLabel.Location = new System.Drawing.Point(24, 6);
            uxTitleLabel.Name = "uxTitleLabel";
            uxTitleLabel.Size = new System.Drawing.Size(74, 41);
            uxTitleLabel.TabIndex = 25;
            uxTitleLabel.Text = "Title";
            // 
            // uxChapterList
            // 
            uxChapterList.Location = new System.Drawing.Point(24, 159);
            uxChapterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxChapterList.Name = "uxChapterList";
            uxChapterList.Size = new System.Drawing.Size(521, 425);
            uxChapterList.TabIndex = 26;
            uxChapterList.UseCompatibleStateImageBehavior = false;
            // 
            // uxUpButton
            // 
            uxUpButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            uxUpButton.Location = new System.Drawing.Point(552, 257);
            uxUpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxUpButton.Name = "uxUpButton";
            uxUpButton.Size = new System.Drawing.Size(41, 44);
            uxUpButton.TabIndex = 27;
            uxUpButton.Text = "⬆";
            uxUpButton.UseVisualStyleBackColor = true;
            uxUpButton.Click += UpButtonClick;
            // 
            // uxDownButton
            // 
            uxDownButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            uxDownButton.Location = new System.Drawing.Point(552, 309);
            uxDownButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxDownButton.Name = "uxDownButton";
            uxDownButton.Size = new System.Drawing.Size(41, 44);
            uxDownButton.TabIndex = 28;
            uxDownButton.Text = "⬇";
            uxDownButton.UseVisualStyleBackColor = true;
            uxDownButton.Click += DownButtonClick;
            // 
            // uxChapterDelete
            // 
            uxChapterDelete.Location = new System.Drawing.Point(511, 593);
            uxChapterDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxChapterDelete.Name = "uxChapterDelete";
            uxChapterDelete.Size = new System.Drawing.Size(34, 31);
            uxChapterDelete.TabIndex = 29;
            uxChapterDelete.Text = "🗑";
            uxChapterDelete.UseVisualStyleBackColor = true;
            uxChapterDelete.Click += ChapterDeleteClick;
            // 
            // uxTagsToAddBox
            // 
            uxTagsToAddBox.FormattingEnabled = true;
            uxTagsToAddBox.Location = new System.Drawing.Point(691, 345);
            uxTagsToAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxTagsToAddBox.Name = "uxTagsToAddBox";
            uxTagsToAddBox.Size = new System.Drawing.Size(159, 224);
            uxTagsToAddBox.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(691, 321);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 20);
            label2.TabIndex = 31;
            label2.Text = "Add Tags:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(856, 321);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 20);
            label3.TabIndex = 32;
            label3.Text = "Current Tags:";
            // 
            // authorTextBox
            // 
            authorTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            authorTextBox.Location = new System.Drawing.Point(164, 108);
            authorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new System.Drawing.Size(381, 38);
            authorTextBox.TabIndex = 33;
            // 
            // authorCheckBox
            // 
            authorCheckBox.AutoSize = true;
            authorCheckBox.Location = new System.Drawing.Point(24, 108);
            authorCheckBox.Name = "authorCheckBox";
            authorCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            authorCheckBox.Size = new System.Drawing.Size(137, 24);
            authorCheckBox.TabIndex = 34;
            authorCheckBox.Text = "Not the Author?";
            authorCheckBox.UseVisualStyleBackColor = true;
            authorCheckBox.CheckedChanged += authorCheckBox_CheckedChanged;
            // 
            // NovelEditView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(authorCheckBox);
            Controls.Add(authorTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(uxTagsToAddBox);
            Controls.Add(uxChapterDelete);
            Controls.Add(uxDownButton);
            Controls.Add(uxUpButton);
            Controls.Add(uxChapterList);
            Controls.Add(uxTitleLabel);
            Controls.Add(uxSaveExitButton);
            Controls.Add(uxTitleTextBox);
            Controls.Add(uxDeleteButton);
            Controls.Add(uxAddTagButton);
            Controls.Add(uxTagsBox);
            Controls.Add(uxAddChapterButton);
            Controls.Add(label1);
            Controls.Add(uxEditChapterButton);
            Controls.Add(uxDescriptionBox);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "NovelEditView";
            Size = new System.Drawing.Size(1136, 752);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button uxEditChapterButton;
        private System.Windows.Forms.RichTextBox uxDescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxAddChapterButton;
        private System.Windows.Forms.ListBox uxTagsBox;
        private System.Windows.Forms.Button uxAddTagButton;
        private System.Windows.Forms.Button uxDeleteButton;
        private System.Windows.Forms.TextBox uxTitleTextBox;
        private System.Windows.Forms.Button uxSaveExitButton;
        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.ListView uxChapterList;
        private System.Windows.Forms.Button uxUpButton;
        private System.Windows.Forms.Button uxDownButton;
        private System.Windows.Forms.Button uxChapterDelete;
        private System.Windows.Forms.ListBox uxTagsToAddBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.CheckBox authorCheckBox;
    }
}
