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
            label5 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new System.Drawing.Point(219, 194);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new System.Drawing.Size(212, 27);
            usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new System.Drawing.Point(219, 263);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new System.Drawing.Size(212, 27);
            passwordBox.TabIndex = 1;
            // 
            // accountLoginButton
            // 
            accountLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accountLoginButton.Location = new System.Drawing.Point(35, 321);
            accountLoginButton.Name = "accountLoginButton";
            accountLoginButton.Size = new System.Drawing.Size(396, 41);
            accountLoginButton.TabIndex = 2;
            accountLoginButton.Text = "Log in with an account";
            accountLoginButton.UseVisualStyleBackColor = true;
            accountLoginButton.Click += accountLoginButton_Click;
            // 
            // guestLoginButton
            // 
            guestLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            guestLoginButton.Location = new System.Drawing.Point(35, 510);
            guestLoginButton.Name = "guestLoginButton";
            guestLoginButton.Size = new System.Drawing.Size(396, 39);
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
            label2.Location = new System.Drawing.Point(60, 194);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 23);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(60, 264);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 23);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(219, 442);
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
            createAccountButton.Size = new System.Drawing.Size(396, 41);
            createAccountButton.TabIndex = 8;
            createAccountButton.Text = "Create account with these credentials";
            createAccountButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(100, 146);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(269, 20);
            label5.TabIndex = 9;
            label5.Text = "Error Label, change as needed in code";
            label5.Visible = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(51, 474);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(364, 29);
            button1.TabIndex = 10;
            button1.Text = "Temporary Debug Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(472, 568);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(createAccountButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guestLoginButton);
            Controls.Add(accountLoginButton);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "LoginView";
            Text = "LoginView";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

