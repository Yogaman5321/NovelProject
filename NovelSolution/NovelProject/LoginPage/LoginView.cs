using NovelProject.LoginPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;


namespace NovelProject
{
    public partial class LoginView : Form
    {
        public LoginHandler handler;
        public event Action<string, bool> LoginSucceeded;

        public LoginView()
        {
            InitializeComponent();
        }

        public void DisplayState(LoginState s)
        {
            errorLabel.Visible = false;
            errorLabel.Text = "";
            switch (s)
            {
                case LoginState.LoginAsGuest:
                    this.Invoke(new Action (() =>
                    {
                        EnvironmentVars.username = "Guest";
                        LoginSucceeded?.Invoke("Guest", false);
                    }));
                    break;
                case LoginState.SucceedLogin:
                    this.Invoke(new Action(() =>
                        {
                            EnvironmentVars.username = usernameBox.Text;
                            LoginSucceeded?.Invoke(usernameBox.Text, true);
                        }));
                    break;
                case LoginState.SucceedCreate:
                    this.Invoke(new Action(() =>
                        {
                            EnvironmentVars.username = usernameBox.Text;
                            LoginSucceeded?.Invoke(usernameBox.Text, true);
                        }));
                    break;
                case LoginState.FailLogin:
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    errorLabel.Text = "Login failed. Please check your username and password.";
                    errorLabel.Visible = true;
                    break;
                case LoginState.FailCreate:
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    errorLabel.Text = "Account creation failed. Please choose a different username.";
                    errorLabel.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void accountLoginButton_Click(object sender, EventArgs e)
        {
            handler(LoginState.TryLoginAccount, usernameBox.Text, passwordBox.Text);
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            handler(LoginState.TryCreateAccount, usernameBox.Text, passwordBox.Text);
        }

        private void guestLoginButton_Click(object sender, EventArgs e)
        {
            handler(LoginState.LoginAsGuest, "", "");
        }   
       

        public void SetLoginHandler(LoginHandler handler)
        {
            this.handler = handler;
        }

        
    }
}
