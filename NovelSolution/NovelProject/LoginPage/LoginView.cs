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
    public partial class LoginView : Form
    {
        public LoginHandler handler;

        public LoginView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // For testing purposes, we will directly open the main view without actual authentication.
            // This method and the associated button will be removed in the future.
            this.Invoke(new Action(() =>
            {
                MainView mv = new MainView("test user");
                mv.Show();
                this.Hide();
            }));
        }

        private void accountLoginButton_Click(object sender, EventArgs e)
        {

        }

        private void guestLoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
