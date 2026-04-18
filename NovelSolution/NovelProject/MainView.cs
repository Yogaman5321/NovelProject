using NovelProject.AuthorPage;
using NovelProject.BrowserPage;
using NovelProject.HomePage;
using NovelProject.Navigation;
using NovelProject.UserPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NovelProject
{
    public partial class MainView : Form
    {
        private string _username;
        private bool _accountMode; // true for account, false for guest
        public bool ReopenLogin = false;

        public Action<UserControl> Navigate;

        public MainView(string username, bool accountMode)
        {
            InitializeComponent();
            _username = username;
            EnvironmentVars.username = username;
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

            LoadView(new HomeView(default));
        }

        private void LoadView(UserControl view)
        {
            uxMainPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            uxMainPanel.Controls.Add(view);

            if (view is INavigatable navigatableView)
            {
                navigatableView.SetNavigator(LoadView);
            }

            logOutButton.Click += logInOutButton_Click;
            logInButton.Click += logInOutButton_Click;
        }

        private void logInOutButton_Click(object sender, EventArgs e)
        {
            ReopenLogin = true;
            this.Close();
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            //var view = new HomeView();
            //var controller = new HomeController(view.DisplayState);
            //view.SetHandler(controller.HandleEvents);
            LoadView(new HomeView(default));
        }

        private void browseNovelsButton_Click(object sender, EventArgs e)
        {
            var view = new BrowserView();
            var controller = new BrowserController(view.DisplayState);
            view.SetHandler(controller.HandleEvents);

            LoadView(view);
        }

        private void authorDashboardButton_Click(object sender, EventArgs e)
        {
            //var view = new AuthorView();
            //var controller = new AuthorController(view.DisplayState);
            //view.SetHandler(controller.HandleEvents);

            LoadView(new AuthorView());
        }

        private void userProfileButton_Click(object sender, EventArgs e)
        {
            //var view = new UserView();
            //var controller = new UserController(view.DisplayState);
            //view.SetHandler(controller.HandleEvents);
            LoadView(new UserView());
        }

    }
}
