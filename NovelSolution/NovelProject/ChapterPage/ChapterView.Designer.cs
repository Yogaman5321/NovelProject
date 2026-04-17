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
            SuspendLayout();
            // 
            // uxBackButton
            // 
            uxBackButton.Location = new System.Drawing.Point(619, 17);
            uxBackButton.Name = "uxBackButton";
            uxBackButton.Size = new System.Drawing.Size(75, 23);
            uxBackButton.TabIndex = 0;
            uxBackButton.Text = "<";
            uxBackButton.UseVisualStyleBackColor = true;
            uxBackButton.Click += BackButtonClick;
            // 
            // uxForwardButton
            // 
            uxForwardButton.Location = new System.Drawing.Point(700, 17);
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
            uxTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            uxTextBox.Size = new System.Drawing.Size(747, 372);
            uxTextBox.TabIndex = 3;
            uxTextBox.Text = "";
            // 
            // ChapterView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uxTextBox);
            Controls.Add(uxExitButton);
            Controls.Add(uxForwardButton);
            Controls.Add(uxBackButton);
            Name = "ChapterView";
            Size = new System.Drawing.Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxForwardButton;
        private System.Windows.Forms.Button uxExitButton;
        private System.Windows.Forms.RichTextBox uxTextBox;
    }
}