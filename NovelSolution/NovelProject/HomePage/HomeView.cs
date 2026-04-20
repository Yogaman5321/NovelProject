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
        
        private List<HistoryInfo> _readHistory;
        private HomeController _controller;
        public HomeView(HomePageStateHandler handler)
        {
            //environment vars class to get username and set welcome label to username
            _controller = new HomeController(_readHistory, HomeViewHandler);
            InitializeComponent();

            HomeView_Load();
        }

        private void HomeView_Load()
        {
            WelcomeLabel.Text = $"Welcome, !";
            

        }            
        private void HomeViewHandler(HomePageState h)
            {
            switch (h)
            { 
                case HomePageState.LoadRecentNovels:
                    _controller.handler(HomePageState.Default);
                    LoadReadHistory();
                    break;
            }
        }

        private void LoadReadHistory()
        {
            foreach(HistoryInfo info in _readHistory)
            {
                UxLastReadListBox.Items.Add($"{info.ChapterTitle} - Last read on {info.LastReadDate}");
            }
        }

    }
}
