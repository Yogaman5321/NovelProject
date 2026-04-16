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

namespace NovelProject
{
    public partial class MainView : Form
    {
        private string _username;
        private bool _accountMode; // true for account, false for guest
        public bool ReopenLogin = false;

        public MainView(string username, bool accountMode)
        {
            InitializeComponent();
            _username = username;
            _accountMode = accountMode;
            usernameLabel.Text = _username;

            authorDashboardButton.Visible = _accountMode;
            authorDashboardButton.Enabled = _accountMode;

            userProfileButton.Visible = _accountMode;
            userProfileButton.Enabled = _accountMode;

            logInButton.Visible = !_accountMode;
            logInButton.Enabled = !_accountMode;

            logOutButton.Visible = _accountMode;
            logOutButton.Enabled = _accountMode;

            logOutButton.Click += logInOutButton_Click;
            logInButton.Click += logInOutButton_Click;
        }

        private void logInOutButton_Click(object sender, EventArgs e)
        {
            ReopenLogin = true;
            this.Close();
        }

        public void LoadUserControl(UserControl userControl)
        {

        }
    }
}
