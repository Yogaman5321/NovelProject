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
            uxDeleteButton = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uxNovelsLabel
            // 
            uxNovelsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxNovelsLabel.AutoSize = true;
            uxNovelsLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            uxNovelsLabel.Location = new System.Drawing.Point(32, 0);
            uxNovelsLabel.Name = "uxNovelsLabel";
            uxNovelsLabel.Size = new System.Drawing.Size(141, 67);
            uxNovelsLabel.TabIndex = 1;
            uxNovelsLabel.Text = "Your Novels";
            uxNovelsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uxAddNewButton
            // 
            uxAddNewButton.Location = new System.Drawing.Point(3, 3);
            uxAddNewButton.Name = "uxAddNewButton";
            uxAddNewButton.Size = new System.Drawing.Size(75, 23);
            uxAddNewButton.TabIndex = 2;
            uxAddNewButton.Text = "Add New";
            uxAddNewButton.UseVisualStyleBackColor = true;
            uxAddNewButton.Click += AddNewButtonClick;
            // 
            // uxReadButton
            // 
            uxReadButton.Location = new System.Drawing.Point(346, 3);
            uxReadButton.Name = "uxReadButton";
            uxReadButton.Size = new System.Drawing.Size(75, 23);
            uxReadButton.TabIndex = 3;
            uxReadButton.Text = "Read";
            uxReadButton.UseVisualStyleBackColor = true;
            uxReadButton.Click += ReadButtonClick;
            // 
            // uxEditButton
            // 
            uxEditButton.Location = new System.Drawing.Point(84, 3);
            uxEditButton.Name = "uxEditButton";
            uxEditButton.Size = new System.Drawing.Size(75, 23);
            uxEditButton.TabIndex = 4;
            uxEditButton.Text = "Edit";
            uxEditButton.UseVisualStyleBackColor = true;
            uxEditButton.Click += EditButtonClick;
            // 
            // uxNovelList
            // 
            uxNovelList.Dock = System.Windows.Forms.DockStyle.Fill;
            uxNovelList.Location = new System.Drawing.Point(32, 70);
            uxNovelList.Name = "uxNovelList";
            uxNovelList.Size = new System.Drawing.Size(770, 398);
            uxNovelList.TabIndex = 5;
            uxNovelList.UseCompatibleStateImageBehavior = false;
            // 
            // uxDeleteButton
            // 
            uxDeleteButton.Location = new System.Drawing.Point(165, 3);
            uxDeleteButton.Name = "uxDeleteButton";
            uxDeleteButton.Size = new System.Drawing.Size(75, 23);
            uxDeleteButton.TabIndex = 6;
            uxDeleteButton.Text = "Delete";
            uxDeleteButton.UseVisualStyleBackColor = true;
            uxDeleteButton.Click += DeleteButtonClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.40775561F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.18684F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.40540552F));
            tableLayoutPanel1.Controls.Add(uxNovelList, 1, 1);
            tableLayoutPanel1.Controls.Add(uxNovelsLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new System.Drawing.Size(851, 525);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.Controls.Add(uxReadButton, 4, 0);
            tableLayoutPanel2.Controls.Add(uxDeleteButton, 2, 0);
            tableLayoutPanel2.Controls.Add(uxAddNewButton, 0, 0);
            tableLayoutPanel2.Controls.Add(uxEditButton, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            tableLayoutPanel2.Location = new System.Drawing.Point(298, 474);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(504, 48);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // AuthorView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AuthorView";
            Size = new System.Drawing.Size(851, 525);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label uxNovelsLabel;
        private System.Windows.Forms.Button uxAddNewButton;
        private System.Windows.Forms.Button uxReadButton;
        private System.Windows.Forms.Button uxEditButton;
        private System.Windows.Forms.ListView uxNovelList;
        private System.Windows.Forms.Button uxDeleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}