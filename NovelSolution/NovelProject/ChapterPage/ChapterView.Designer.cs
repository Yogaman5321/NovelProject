namespace NovelProject.ChapterPage
{
    partial class ChapterView
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
            uxBackButton = new System.Windows.Forms.Button();
            uxForwardButton = new System.Windows.Forms.Button();
            uxExitButton = new System.Windows.Forms.Button();
            uxTextBox = new System.Windows.Forms.RichTextBox();
            uxChapterLabel = new System.Windows.Forms.Label();
            uxViewCommentsButton = new System.Windows.Forms.Button();
            uxPdfViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)uxPdfViewer).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uxBackButton
            // 
            uxBackButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            uxBackButton.Location = new System.Drawing.Point(798, 16);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new System.Drawing.Size(75, 23);
            uxBackButton.TabIndex = 0;
            uxBackButton.Text = "<";
            uxBackButton.UseVisualStyleBackColor = true;
            uxBackButton.Click += BackButtonClick;
            // 
            // uxForwardButton
            // 
            uxForwardButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxForwardButton.Location = new System.Drawing.Point(879, 16);
            uxForwardButton.Name = "uxForwardButton";
            uxForwardButton.Size = new System.Drawing.Size(75, 23);
            uxForwardButton.TabIndex = 1;
            uxForwardButton.Text = ">";
            uxForwardButton.UseVisualStyleBackColor = true;
            uxForwardButton.Click += ForwardButtonClick;
            // 
            // uxExitButton
            // 
            uxExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            uxExitButton.Location = new System.Drawing.Point(25, 16);
            uxExitButton.Name = "uxExitButton";
            uxExitButton.Size = new System.Drawing.Size(75, 23);
            uxExitButton.TabIndex = 2;
            uxExitButton.Text = "Exit";
            uxExitButton.UseVisualStyleBackColor = true;
            uxExitButton.Click += ExitButtonClick;
            // 
            // uxTextBox
            // 
            uxTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            uxTextBox.Location = new System.Drawing.Point(0, 0);
            uxTextBox.Name = "uxTextBox";
            uxTextBox.ReadOnly = true;
            uxTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            uxTextBox.Size = new System.Drawing.Size(1018, 504);
            uxTextBox.TabIndex = 3;
            uxTextBox.Text = "";
            // 
            // uxChapterLabel
            // 
            uxChapterLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            uxChapterLabel.AutoSize = true;
            uxChapterLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            uxChapterLabel.Location = new System.Drawing.Point(128, 17);
            uxChapterLabel.Name = "uxChapterLabel";
            uxChapterLabel.Size = new System.Drawing.Size(88, 25);
            uxChapterLabel.TabIndex = 4;
            uxChapterLabel.Text = "Chapter: ";
            // 
            // uxViewCommentsButton
            // 
            uxViewCommentsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            uxViewCommentsButton.Location = new System.Drawing.Point(887, 561);
            uxViewCommentsButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            uxViewCommentsButton.Name = "uxViewCommentsButton";
            uxViewCommentsButton.Size = new System.Drawing.Size(117, 23);
            uxViewCommentsButton.TabIndex = 5;
            uxViewCommentsButton.Text = "View Comments";
            uxViewCommentsButton.UseVisualStyleBackColor = true;
            uxViewCommentsButton.Click += ViewCommentsButtonClick;
            // 
            // uxPdfViewer
            // 
            uxPdfViewer.AllowExternalDrop = true;
            uxPdfViewer.CreationProperties = null;
            uxPdfViewer.DefaultBackgroundColor = System.Drawing.Color.White;
            uxPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            uxPdfViewer.Location = new System.Drawing.Point(0, 0);
            uxPdfViewer.Name = "uxPdfViewer";
            uxPdfViewer.Size = new System.Drawing.Size(1018, 504);
            uxPdfViewer.TabIndex = 6;
            uxPdfViewer.ZoomFactor = 1D;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(uxViewCommentsButton, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.602151F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.39785F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1024, 612);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(uxTextBox);
            panel1.Controls.Add(uxPdfViewer);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 51);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1018, 504);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.11315F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.88685F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(uxForwardButton, 4, 0);
            tableLayoutPanel2.Controls.Add(uxChapterLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(uxBackButton, 3, 0);
            tableLayoutPanel2.Controls.Add(uxExitButton, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1018, 42);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // ChapterView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ChapterView";
            Size = new System.Drawing.Size(1024, 612);
            ((System.ComponentModel.ISupportInitialize)uxPdfViewer).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxForwardButton;
        private System.Windows.Forms.Button uxExitButton;
        private System.Windows.Forms.RichTextBox uxTextBox;
        private System.Windows.Forms.Label uxChapterLabel;
        private System.Windows.Forms.Button uxViewCommentsButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 uxPdfViewer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}