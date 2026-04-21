using System;

namespace NovelProject.CommentPage
{
    partial class CommentView
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
            uxAddCommentButton = new System.Windows.Forms.Button();
            uxNovelName = new System.Windows.Forms.Label();
            uxBackButton = new System.Windows.Forms.Button();
            uxCommentBox = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // uxAddCommentButton
            // 
            uxAddCommentButton.Location = new System.Drawing.Point(630, 421);
            uxAddCommentButton.Name = "uxAddCommentButton";
            uxAddCommentButton.Size = new System.Drawing.Size(119, 27);
            uxAddCommentButton.TabIndex = 2;
            uxAddCommentButton.Text = "Add Comment";
            uxAddCommentButton.UseVisualStyleBackColor = true;
            uxAddCommentButton.Click += AddCommentButtonClick;
            // 
            // uxNovelName
            // 
            uxNovelName.AutoSize = true;
            uxNovelName.Font = new System.Drawing.Font("Segoe UI", 14F);
            uxNovelName.Location = new System.Drawing.Point(20, 19);
            uxNovelName.Name = "uxNovelName";
            uxNovelName.Size = new System.Drawing.Size(225, 25);
            uxNovelName.TabIndex = 3;
            uxNovelName.Text = "Novel Name and Chapter";
            // 
            // uxBackButton
            // 
            uxBackButton.Location = new System.Drawing.Point(20, 421);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new System.Drawing.Size(80, 27);
            uxBackButton.TabIndex = 4;
            uxBackButton.Text = "Back";
            uxBackButton.UseVisualStyleBackColor = true;
            uxBackButton.Click += BackButtonClick;
            // 
            // uxCommentBox
            // 
            uxCommentBox.FormattingEnabled = true;
            uxCommentBox.Location = new System.Drawing.Point(20, 47);
            uxCommentBox.Name = "uxCommentBox";
            uxCommentBox.Size = new System.Drawing.Size(729, 364);
            uxCommentBox.TabIndex = 5;
            // 
            // CommentView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxCommentBox);
            Controls.Add(uxBackButton);
            Controls.Add(uxNovelName);
            Controls.Add(uxAddCommentButton);
            Name = "CommentView";
            Size = new System.Drawing.Size(777, 467);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button uxAddCommentButton;
        private System.Windows.Forms.Label uxNovelName;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.ListBox uxCommentBox;
    }
}
