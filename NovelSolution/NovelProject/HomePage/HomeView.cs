using NovelProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject.HomePage
{
    public partial class HomeView : UserControl
    {
        private HomePageStateHandler handler;
        private List<ReadHistory> _readHistory;
        public HomeView(HomePageStateHandler handler)
        {
            //environment vars class to get username and set welcome label to username
            HomeController controller = new HomeController(_readHistory);
            InitializeComponent();
            this.handler = controller.handler;
            HomeView_Load();
        }

        private HomePageStateHandler handle;

        private void HomeView_Load()
        {
            WelcomeLabel.Text = $"Welcome, !";

            handler(HomePageState.Default);

        }

        //private void LoadRecentNovels()
        //{
        //    handler(HomePageState.LoadRecentNovels);
        //}
    }
}
