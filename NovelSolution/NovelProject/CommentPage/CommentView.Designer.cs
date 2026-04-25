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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uxAddCommentButton
            // 
            uxAddCommentButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            uxAddCommentButton.Location = new System.Drawing.Point(609, 3);
            uxAddCommentButton.Name = "uxAddCommentButton";
            uxAddCommentButton.Size = new System.Drawing.Size(119, 27);
            uxAddCommentButton.TabIndex = 2;
            uxAddCommentButton.Text = "Add Comment";
            uxAddCommentButton.UseVisualStyleBackColor = true;
            uxAddCommentButton.Click += AddCommentButtonClick;
            // 
            // uxNovelName
            // 
            uxNovelName.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxNovelName.AutoSize = true;
            uxNovelName.Font = new System.Drawing.Font("Segoe UI", 14F);
            uxNovelName.Location = new System.Drawing.Point(23, 26);
            uxNovelName.Name = "uxNovelName";
            uxNovelName.Size = new System.Drawing.Size(225, 25);
            uxNovelName.TabIndex = 3;
            uxNovelName.Text = "Novel Name and Chapter";
            // 
            // uxBackButton
            // 
            uxBackButton.Location = new System.Drawing.Point(3, 3);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new System.Drawing.Size(80, 27);
            uxBackButton.TabIndex = 4;
            uxBackButton.Text = "Back";
            uxBackButton.UseVisualStyleBackColor = true;
            uxBackButton.Click += BackButtonClick;
            // 
            // uxCommentBox
            // 
            uxCommentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            uxCommentBox.FormattingEnabled = true;
            uxCommentBox.Location = new System.Drawing.Point(23, 54);
            uxCommentBox.Name = "uxCommentBox";
            uxCommentBox.Size = new System.Drawing.Size(731, 366);
            uxCommentBox.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 737F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(uxCommentBox, 1, 1);
            tableLayoutPanel1.Controls.Add(uxNovelName, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.1076231F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.89238F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel1.Size = new System.Drawing.Size(777, 467);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(uxAddCommentButton, 1, 0);
            tableLayoutPanel2.Controls.Add(uxBackButton, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(23, 426);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(731, 38);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // CommentView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CommentView";
            Size = new System.Drawing.Size(777, 467);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button uxAddCommentButton;
        private System.Windows.Forms.Label uxNovelName;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.ListBox uxCommentBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
