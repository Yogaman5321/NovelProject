namespace NovelProject
{
    partial class NovelDisplayCard
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
            novelNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            viewsLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            authorLinkLabel = new System.Windows.Forms.LinkLabel();
            label3 = new System.Windows.Forms.Label();
            chapterCountLabel = new System.Windows.Forms.Label();
            tagsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // novelNameLabel
            // 
            novelNameLabel.AutoSize = true;
            novelNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            novelNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            novelNameLabel.Location = new System.Drawing.Point(0, 0);
            novelNameLabel.Name = "novelNameLabel";
            novelNameLabel.Size = new System.Drawing.Size(124, 28);
            novelNameLabel.TabIndex = 0;
            novelNameLabel.Text = "NovelName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Rating:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(55, 31);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(84, 20);
            ratingLabel.TabIndex = 2;
            ratingLabel.Text = "RatingHere";
            // 
            // viewsLabel
            // 
            viewsLabel.AutoSize = true;
            viewsLabel.Location = new System.Drawing.Point(55, 51);
            viewsLabel.Name = "viewsLabel";
            viewsLabel.Size = new System.Drawing.Size(162, 20);
            viewsLabel.TabIndex = 3;
            viewsLabel.Text = "CountInReadingHistory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Views:";
            // 
            // authorLinkLabel
            // 
            authorLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            authorLinkLabel.AutoSize = true;
            authorLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            authorLinkLabel.Location = new System.Drawing.Point(260, 3);
            authorLinkLabel.Name = "authorLinkLabel";
            authorLinkLabel.Size = new System.Drawing.Size(119, 28);
            authorLinkLabel.TabIndex = 7;
            authorLinkLabel.TabStop = true;
            authorLinkLabel.Text = "AuthorHere";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(260, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Chapters:";
            // 
            // chapterCountLabel
            // 
            chapterCountLabel.AutoSize = true;
            chapterCountLabel.Location = new System.Drawing.Point(323, 31);
            chapterCountLabel.Name = "chapterCountLabel";
            chapterCountLabel.Size = new System.Drawing.Size(122, 20);
            chapterCountLabel.TabIndex = 9;
            chapterCountLabel.Text = "CountOfChapters";
            // 
            // tagsFlowLayoutPanel
            // 
            tagsFlowLayoutPanel.AutoScroll = true;
            tagsFlowLayoutPanel.Location = new System.Drawing.Point(45, 74);
            tagsFlowLayoutPanel.Name = "tagsFlowLayoutPanel";
            tagsFlowLayoutPanel.Size = new System.Drawing.Size(391, 34);
            tagsFlowLayoutPanel.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 20);
            label5.TabIndex = 11;
            label5.Text = "Tags: ";
            // 
            // NovelDisplayCard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(label5);
            Controls.Add(tagsFlowLayoutPanel);
            Controls.Add(chapterCountLabel);
            Controls.Add(label3);
            Controls.Add(authorLinkLabel);
            Controls.Add(label2);
            Controls.Add(viewsLabel);
            Controls.Add(ratingLabel);
            Controls.Add(label1);
            Controls.Add(novelNameLabel);
            Name = "NovelDisplayCard";
            Size = new System.Drawing.Size(446, 111);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label novelNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label viewsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel authorLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label chapterCountLabel;
        private System.Windows.Forms.FlowLayoutPanel tagsFlowLayoutPanel;
        private System.Windows.Forms.Label label5;
    }
}
