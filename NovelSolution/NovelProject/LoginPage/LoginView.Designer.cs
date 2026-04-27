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
            usernameBox.Location = new System.Drawing.Point(219, 195);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new System.Drawing.Size(212, 27);
            usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new System.Drawing.Point(219, 263);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new System.Drawing.Size(212, 27);
            passwordBox.TabIndex = 1;
            // 
            // accountLoginButton
            // 
            accountLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accountLoginButton.Location = new System.Drawing.Point(35, 321);
            accountLoginButton.Name = "accountLoginButton";
            accountLoginButton.Size = new System.Drawing.Size(395, 41);
            accountLoginButton.TabIndex = 2;
            accountLoginButton.Text = "Log in with an account";
            accountLoginButton.UseVisualStyleBackColor = true;
            accountLoginButton.Click += accountLoginButton_Click;
            // 
            // guestLoginButton
            // 
            guestLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            guestLoginButton.Location = new System.Drawing.Point(35, 509);
            guestLoginButton.Name = "guestLoginButton";
            guestLoginButton.Size = new System.Drawing.Size(395, 39);
            guestLoginButton.TabIndex = 3;
            guestLoginButton.Text = "Log in as a Guest";
            guestLoginButton.UseVisualStyleBackColor = true;
            guestLoginButton.Click += guestLoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(159, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 62);
            label1.TabIndex = 4;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(59, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 23);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(59, 264);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 23);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(219, 443);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 23);
            label4.TabIndex = 7;
            label4.Text = "Or:";
            // 
            // createAccountButton
            // 
            createAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            createAccountButton.Location = new System.Drawing.Point(35, 368);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new System.Drawing.Size(395, 41);
            createAccountButton.TabIndex = 8;
            createAccountButton.Text = "Create account with these credentials";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            errorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            errorLabel.ForeColor = System.Drawing.Color.Red;
            errorLabel.Location = new System.Drawing.Point(0, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new System.Drawing.Size(263, 64);
            errorLabel.TabIndex = 9;
            errorLabel.Text = "Error Label, change as needed in code";
            errorLabel.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(errorLabel);
            panel1.Location = new System.Drawing.Point(101, 103);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(263, 64);
            panel1.TabIndex = 10;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(472, 568);
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
            Name = "LoginView";
            Text = "LoginView";
            panel1.ResumeLayout(false);
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

