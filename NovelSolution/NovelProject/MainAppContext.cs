using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelProject.LoginPage;

namespace NovelProject
{
    public class MainAppContext : ApplicationContext
    {
        private Form _currentForm;

        public MainAppContext()
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            var loginView = new LoginView();
            var loginController = new LoginController(loginView.DisplayState);
            loginView.SetLoginHandler(loginController.HandleEvents);

            loginView.FormClosed += (s, e) =>
            {
                if (loginView.DialogResult != DialogResult.OK)
                {
                    ExitThread();
                }
            };

            loginView.LoginSucceeded += (username, isAccount) =>
            {
                ShowMain(username, isAccount);
                loginView.FormClosed -= null; // Remove handler if needed
                loginView.Close();
            };

            SetMainForm(loginView);
            loginView.Show();
        }

        private void ShowMain(string username, bool isAccount)
        {
            var mainView = new MainView(username, isAccount);
            mainView.FormClosed += (s, e) =>
            {
                if (mainView.ReopenLogin)
                {
                    ShowLogin();
                }
                else
                {
                    ExitThread();
                }
            };
            SetMainForm(mainView);
            mainView.Show();
        }

        private void SetMainForm(Form form)
        {
            if (_currentForm != null)
            {
                _currentForm.FormClosed -= null; // Remove handlers if needed
                _currentForm.Dispose();
            }
            _currentForm = form;
        }
    }
}
