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
            ((System.ComponentModel.ISupportInitialize)uxPdfViewer).BeginInit();
            SuspendLayout();
            // 
            // uxBackButton
            // 
            uxBackButton.Location = new System.Drawing.Point(832, 19);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new System.Drawing.Size(75, 23);
            uxBackButton.TabIndex = 0;
            uxBackButton.Text = "<";
            uxBackButton.UseVisualStyleBackColor = true;
            uxBackButton.Click += BackButtonClick;
            // 
            // uxForwardButton
            // 
            uxForwardButton.Location = new System.Drawing.Point(913, 19);
            uxForwardButton.Name = "uxForwardButton";
            uxForwardButton.Size = new System.Drawing.Size(75, 23);
            uxForwardButton.TabIndex = 1;
            uxForwardButton.Text = ">";
            uxForwardButton.UseVisualStyleBackColor = true;
            uxForwardButton.Click += ForwardButtonClick;
            // 
            // uxExitButton
            // 
            uxExitButton.Location = new System.Drawing.Point(27, 17);
            uxExitButton.Name = "uxExitButton";
            uxExitButton.Size = new System.Drawing.Size(75, 23);
            uxExitButton.TabIndex = 2;
            uxExitButton.Text = "Exit";
            uxExitButton.UseVisualStyleBackColor = true;
            uxExitButton.Click += ExitButtonClick;
            // 
            // uxTextBox
            // 
            uxTextBox.Location = new System.Drawing.Point(28, 56);
            uxTextBox.Name = "uxTextBox";
            uxTextBox.ReadOnly = true;
            uxTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            uxTextBox.Size = new System.Drawing.Size(960, 471);
            uxTextBox.TabIndex = 3;
            uxTextBox.Text = "";
            // 
            // uxChapterLabel
            // 
            uxChapterLabel.AutoSize = true;
            uxChapterLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            uxChapterLabel.Location = new System.Drawing.Point(233, 15);
            uxChapterLabel.Name = "uxChapterLabel";
            uxChapterLabel.Size = new System.Drawing.Size(88, 25);
            uxChapterLabel.TabIndex = 4;
            uxChapterLabel.Text = "Chapter: ";
            // 
            // uxViewCommentsButton
            // 
            uxViewCommentsButton.Location = new System.Drawing.Point(871, 533);
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
            uxPdfViewer.Location = new System.Drawing.Point(28, 56);
            uxPdfViewer.Name = "uxPdfViewer";
            uxPdfViewer.Size = new System.Drawing.Size(960, 471);
            uxPdfViewer.TabIndex = 6;
            uxPdfViewer.ZoomFactor = 1D;
            // 
            // ChapterView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxPdfViewer);
            Controls.Add(uxViewCommentsButton);
            Controls.Add(uxChapterLabel);
            Controls.Add(uxTextBox);
            Controls.Add(uxExitButton);
            Controls.Add(uxForwardButton);
            Controls.Add(uxBackButton);
            Name = "ChapterView";
            Size = new System.Drawing.Size(1024, 612);
            ((System.ComponentModel.ISupportInitialize)uxPdfViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxForwardButton;
        private System.Windows.Forms.Button uxExitButton;
        private System.Windows.Forms.RichTextBox uxTextBox;
        private System.Windows.Forms.Label uxChapterLabel;
        private System.Windows.Forms.Button uxViewCommentsButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 uxPdfViewer;
    }
}