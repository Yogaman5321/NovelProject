namespace NovelProject
{
    partial class LoginView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameBox = new System.Windows.Forms.TextBox();
            passwordBox = new System.Windows.Forms.TextBox();
            accountLoginButton = new System.Windows.Forms.Button();
            guestLoginButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            createAccountButton = new System.Windows.Forms.Button();
            errorLabel = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new System.Drawing.Point(192, 146);
            usernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new System.Drawing.Size(186, 23);
            usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new System.Drawing.Point(192, 197);
            passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new System.Drawing.Size(186, 23);
            passwordBox.TabIndex = 1;
            // 
            // accountLoginButton
            // 
            accountLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accountLoginButton.Location = new System.Drawing.Point(31, 241);
            accountLoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            accountLoginButton.Name = "accountLoginButton";
            accountLoginButton.Size = new System.Drawing.Size(346, 31);
            accountLoginButton.TabIndex = 2;
            accountLoginButton.Text = "Log in with an account";
            accountLoginButton.UseVisualStyleBackColor = true;
            accountLoginButton.Click += accountLoginButton_Click;
            // 
            // guestLoginButton
            // 
            guestLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            guestLoginButton.Location = new System.Drawing.Point(31, 382);
            guestLoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            guestLoginButton.Name = "guestLoginButton";
            guestLoginButton.Size = new System.Drawing.Size(346, 29);
            guestLoginButton.TabIndex = 3;
            guestLoginButton.Text = "Log in as a Guest";
            guestLoginButton.UseVisualStyleBackColor = true;
            guestLoginButton.Click += guestLoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(139, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 51);
            label1.TabIndex = 4;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(52, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 19);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(52, 198);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 19);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(192, 332);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 19);
            label4.TabIndex = 7;
            label4.Text = "Or:";
            // 
            // createAccountButton
            // 
            createAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            createAccountButton.Location = new System.Drawing.Point(31, 276);
            createAccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new System.Drawing.Size(346, 31);
            createAccountButton.TabIndex = 8;
            createAccountButton.Text = "Create account with these credentials";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = false;
            errorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            errorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            errorLabel.ForeColor = System.Drawing.Color.Red;
            errorLabel.Location = new System.Drawing.Point(0, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new System.Drawing.Size(206, 15);
            errorLabel.TabIndex = 9;
            errorLabel.Text = "Error Label, change as needed in code";
            errorLabel.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(errorLabel);
            panel1.Location = new System.Drawing.Point(88, 77);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(230, 48);
            panel1.TabIndex = 10;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(413, 426);
            Controls.Add(createAccountButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guestLoginButton);
            Controls.Add(accountLoginButton);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "LoginView";
            Text = "LoginView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button accountLoginButton;
        private System.Windows.Forms.Button guestLoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

