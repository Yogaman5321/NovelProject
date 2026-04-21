namespace NovelProject.ReviewControl
{
    partial class ReviewView
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
            label1 = new System.Windows.Forms.Label();
            ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            reviewContentBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            submitReviewButton = new System.Windows.Forms.Button();
            characterCountLabel = new System.Windows.Forms.Label();
            editReviewButton = new System.Windows.Forms.Button();
            deleteReviewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)ratingNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(49, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(222, 38);
            label1.TabIndex = 0;
            label1.Text = "Leave a Review:";
            // 
            // ratingNumericUpDown
            // 
            ratingNumericUpDown.DecimalPlaces = 1;
            ratingNumericUpDown.Location = new System.Drawing.Point(167, 85);
            ratingNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ratingNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ratingNumericUpDown.Name = "ratingNumericUpDown";
            ratingNumericUpDown.Size = new System.Drawing.Size(70, 27);
            ratingNumericUpDown.TabIndex = 1;
            ratingNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // reviewContentBox
            // 
            reviewContentBox.Location = new System.Drawing.Point(17, 164);
            reviewContentBox.MaxLength = 500;
            reviewContentBox.Multiline = true;
            reviewContentBox.Name = "reviewContentBox";
            reviewContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            reviewContentBox.Size = new System.Drawing.Size(294, 259);
            reviewContentBox.TabIndex = 2;
            reviewContentBox.TextChanged += reviewContentBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(91, 84);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 28);
            label2.TabIndex = 3;
            label2.Text = "1-10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(49, 133);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 28);
            label3.TabIndex = 4;
            label3.Text = "Content:";
            // 
            // submitReviewButton
            // 
            submitReviewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            submitReviewButton.Location = new System.Drawing.Point(17, 429);
            submitReviewButton.Name = "submitReviewButton";
            submitReviewButton.Size = new System.Drawing.Size(94, 44);
            submitReviewButton.TabIndex = 5;
            submitReviewButton.Text = "Submit";
            submitReviewButton.UseVisualStyleBackColor = true;
            submitReviewButton.Click += submitReviewButton_Click;
            // 
            // characterCountLabel
            // 
            characterCountLabel.AutoSize = true;
            characterCountLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            characterCountLabel.Location = new System.Drawing.Point(221, 140);
            characterCountLabel.Name = "characterCountLabel";
            characterCountLabel.Size = new System.Drawing.Size(41, 17);
            characterCountLabel.TabIndex = 6;
            characterCountLabel.Text = "0/500";
            // 
            // editReviewButton
            // 
            editReviewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            editReviewButton.Location = new System.Drawing.Point(117, 429);
            editReviewButton.Name = "editReviewButton";
            editReviewButton.Size = new System.Drawing.Size(94, 44);
            editReviewButton.TabIndex = 7;
            editReviewButton.Text = "Edit";
            editReviewButton.UseVisualStyleBackColor = true;
            editReviewButton.Click += editReviewButton_Click;
            // 
            // deleteReviewButton
            // 
            deleteReviewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            deleteReviewButton.Location = new System.Drawing.Point(217, 429);
            deleteReviewButton.Name = "deleteReviewButton";
            deleteReviewButton.Size = new System.Drawing.Size(94, 44);
            deleteReviewButton.TabIndex = 8;
            deleteReviewButton.Text = "Delete";
            deleteReviewButton.UseVisualStyleBackColor = true;
            deleteReviewButton.Click += deleteReviewButton_Click;
            // 
            // ReviewView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(deleteReviewButton);
            Controls.Add(editReviewButton);
            Controls.Add(characterCountLabel);
            Controls.Add(submitReviewButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(reviewContentBox);
            Controls.Add(ratingNumericUpDown);
            Controls.Add(label1);
            Name = "ReviewView";
            Size = new System.Drawing.Size(327, 476);
            ((System.ComponentModel.ISupportInitialize)ratingNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ratingNumericUpDown;
        private System.Windows.Forms.TextBox reviewContentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitReviewButton;
        private System.Windows.Forms.Label characterCountLabel;
        private System.Windows.Forms.Button editReviewButton;
        private System.Windows.Forms.Button deleteReviewButton;
    }
}
