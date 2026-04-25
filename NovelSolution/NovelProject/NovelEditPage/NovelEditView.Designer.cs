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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // uxEditChapterButton
            // 
            uxEditChapterButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            uxEditChapterButton.Location = new System.Drawing.Point(242, 3);
            uxEditChapterButton.Name = "uxEditChapterButton";
            uxEditChapterButton.Size = new System.Drawing.Size(91, 23);
            uxEditChapterButton.TabIndex = 15;
            uxEditChapterButton.Text = "Edit Chapter";
            uxEditChapterButton.UseVisualStyleBackColor = true;
            uxEditChapterButton.Click += EditChapterButtonClick;
            // 
            // uxDescriptionBox
            // 
            uxDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            uxDescriptionBox.Location = new System.Drawing.Point(3, 56);
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.Size = new System.Drawing.Size(338, 220);
            uxDescriptionBox.TabIndex = 14;
            uxDescriptionBox.Text = "";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 16;
            label1.Text = "Description";
            // 
            // uxAddChapterButton
            // 
            uxAddChapterButton.Location = new System.Drawing.Point(339, 3);
            uxAddChapterButton.Name = "uxAddChapterButton";
            uxAddChapterButton.Size = new System.Drawing.Size(91, 23);
            uxAddChapterButton.TabIndex = 17;
            uxAddChapterButton.Text = "Add Chapter";
            uxAddChapterButton.UseVisualStyleBackColor = true;
            uxAddChapterButton.Click += AddChapterButtonClick;
            // 
            // uxTagsBox
            // 
            uxTagsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            uxTagsBox.FormattingEnabled = true;
            uxTagsBox.Location = new System.Drawing.Point(172, 22);
            uxTagsBox.Name = "uxTagsBox";
            uxTagsBox.Size = new System.Drawing.Size(163, 168);
            uxTagsBox.TabIndex = 18;
            // 
            // uxAddTagButton
            // 
            uxAddTagButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            uxAddTagButton.Location = new System.Drawing.Point(34, 3);
            uxAddTagButton.Name = "uxAddTagButton";
            uxAddTagButton.Size = new System.Drawing.Size(100, 23);
            uxAddTagButton.TabIndex = 19;
            uxAddTagButton.Text = "Add Tag";
            uxAddTagButton.UseVisualStyleBackColor = true;
            uxAddTagButton.Click += AddTagButtonClick;
            // 
            // uxDeleteButton
            // 
            uxDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            uxDeleteButton.Location = new System.Drawing.Point(305, 3);
            uxDeleteButton.Name = "uxDeleteButton";
            uxDeleteButton.Size = new System.Drawing.Size(30, 23);
            uxDeleteButton.TabIndex = 20;
            uxDeleteButton.Text = "🗑";
            uxDeleteButton.UseVisualStyleBackColor = true;
            uxDeleteButton.Click += DeleteButtonClick;
            // 
            // uxTitleTextBox
            // 
            uxTitleTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            uxTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            uxTitleTextBox.Location = new System.Drawing.Point(3, 35);
            uxTitleTextBox.Name = "uxTitleTextBox";
            uxTitleTextBox.Size = new System.Drawing.Size(505, 32);
            uxTitleTextBox.TabIndex = 22;
            // 
            // uxSaveExitButton
            // 
            uxSaveExitButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            uxSaveExitButton.Location = new System.Drawing.Point(253, 3);
            uxSaveExitButton.Name = "uxSaveExitButton";
            uxSaveExitButton.Size = new System.Drawing.Size(88, 23);
            uxSaveExitButton.TabIndex = 23;
            uxSaveExitButton.Text = "Save and Exit";
            uxSaveExitButton.UseVisualStyleBackColor = true;
            uxSaveExitButton.Click += SaveExitButtonClick;
            // 
            // uxTitleLabel
            // 
            uxTitleLabel.AutoSize = true;
            uxTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            uxTitleLabel.Location = new System.Drawing.Point(3, 0);
            uxTitleLabel.Name = "uxTitleLabel";
            uxTitleLabel.Size = new System.Drawing.Size(60, 32);
            uxTitleLabel.TabIndex = 25;
            uxTitleLabel.Text = "Title";
            // 
            // uxChapterList
            // 
            uxChapterList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxChapterList.Location = new System.Drawing.Point(3, 3);
            uxChapterList.Name = "uxChapterList";
            uxChapterList.Size = new System.Drawing.Size(505, 388);
            uxChapterList.TabIndex = 26;
            uxChapterList.UseCompatibleStateImageBehavior = false;
            // 
            // uxUpButton
            // 
            uxUpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxUpButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            uxUpButton.Location = new System.Drawing.Point(3, 158);
            uxUpButton.Name = "uxUpButton";
            uxUpButton.Size = new System.Drawing.Size(36, 33);
            uxUpButton.TabIndex = 27;
            uxUpButton.Text = "⬆";
            uxUpButton.UseVisualStyleBackColor = true;
            uxUpButton.Click += UpButtonClick;
            // 
            // uxDownButton
            // 
            uxDownButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            uxDownButton.Location = new System.Drawing.Point(3, 197);
            uxDownButton.Name = "uxDownButton";
            uxDownButton.Size = new System.Drawing.Size(36, 33);
            uxDownButton.TabIndex = 28;
            uxDownButton.Text = "⬇";
            uxDownButton.UseVisualStyleBackColor = true;
            uxDownButton.Click += DownButtonClick;
            // 
            // uxChapterDelete
            // 
            uxChapterDelete.Location = new System.Drawing.Point(436, 3);
            uxChapterDelete.Name = "uxChapterDelete";
            uxChapterDelete.Size = new System.Drawing.Size(30, 23);
            uxChapterDelete.TabIndex = 29;
            uxChapterDelete.Text = "🗑";
            uxChapterDelete.UseVisualStyleBackColor = true;
            uxChapterDelete.Click += ChapterDeleteClick;
            // 
            // uxTagsToAddBox
            // 
            uxTagsToAddBox.Dock = System.Windows.Forms.DockStyle.Fill;
            uxTagsToAddBox.FormattingEnabled = true;
            uxTagsToAddBox.Location = new System.Drawing.Point(3, 22);
            uxTagsToAddBox.Name = "uxTagsToAddBox";
            uxTagsToAddBox.Size = new System.Drawing.Size(163, 168);
            uxTagsToAddBox.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 31;
            label2.Text = "Add Tags:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(172, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 15);
            label3.TabIndex = 32;
            label3.Text = "Current Tags:";
            // 
            // authorTextBox
            // 
            authorTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            authorTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            authorTextBox.Location = new System.Drawing.Point(143, 3);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new System.Drawing.Size(362, 32);
            authorTextBox.TabIndex = 33;
            // 
            // authorCheckBox
            // 
            authorCheckBox.AutoSize = true;
            authorCheckBox.Location = new System.Drawing.Point(3, 2);
            authorCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            authorCheckBox.Name = "authorCheckBox";
            authorCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            authorCheckBox.Size = new System.Drawing.Size(111, 19);
            authorCheckBox.TabIndex = 34;
            authorCheckBox.Text = "Not the Author?";
            authorCheckBox.UseVisualStyleBackColor = true;
            authorCheckBox.CheckedChanged += authorCheckBox_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.79505539F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.40677F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.798172F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 2, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(994, 564);
            tableLayoutPanel1.TabIndex = 35;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(uxTitleLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel2.Controls.Add(uxTitleTextBox, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(33, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(576, 558);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92307F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0769253F));
            tableLayoutPanel4.Controls.Add(uxEditChapterButton, 0, 0);
            tableLayoutPanel4.Controls.Add(uxAddChapterButton, 1, 0);
            tableLayoutPanel4.Controls.Add(uxChapterDelete, 2, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 518);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(570, 37);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.6963558F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.30364F));
            tableLayoutPanel3.Controls.Add(authorTextBox, 1, 0);
            tableLayoutPanel3.Controls.Add(authorCheckBox, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 73);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(570, 39);
            tableLayoutPanel3.TabIndex = 26;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.67612F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.3238869F));
            tableLayoutPanel5.Controls.Add(uxChapterList, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 118);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new System.Drawing.Size(570, 394);
            tableLayoutPanel5.TabIndex = 27;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(uxUpButton, 0, 0);
            tableLayoutPanel6.Controls.Add(uxDownButton, 0, 1);
            tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(514, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new System.Drawing.Size(53, 388);
            tableLayoutPanel6.TabIndex = 27;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(uxSaveExitButton, 0, 0);
            tableLayoutPanel7.Controls.Add(label1, 0, 1);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel9, 0, 4);
            tableLayoutPanel7.Controls.Add(uxDescriptionBox, 0, 2);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 3);
            tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel7.Location = new System.Drawing.Point(615, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 6;
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.15094F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.8490562F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new System.Drawing.Size(344, 558);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(uxDeleteButton, 1, 0);
            tableLayoutPanel9.Controls.Add(uxAddTagButton, 0, 0);
            tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel9.Location = new System.Drawing.Point(3, 481);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new System.Drawing.Size(338, 53);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label3, 1, 0);
            tableLayoutPanel8.Controls.Add(uxTagsBox, 1, 1);
            tableLayoutPanel8.Controls.Add(label2, 0, 0);
            tableLayoutPanel8.Controls.Add(uxTagsToAddBox, 0, 1);
            tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel8.Location = new System.Drawing.Point(3, 282);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.868421F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.13158F));
            tableLayoutPanel8.Size = new System.Drawing.Size(338, 193);
            tableLayoutPanel8.TabIndex = 24;
            // 
            // NovelEditView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "NovelEditView";
            Size = new System.Drawing.Size(994, 564);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    }
}
