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
        public HomeHandler handler;

        public HomeView()
        {
            InitializeComponent();
            WelcomeLabel.Text = $"Welcome, {EnvironmentVars.username}!";
            this.Load += LoadHistory;
        }

        public void SetHomeHandler(HomeHandler handler)
        {
            this.handler = handler;
        }

        public void DisplayState(HomePageState s, List<HistoryInfo> history)
        {
            switch (s)
            {
                case HomePageState.GotHistory:
                    LoadReadHistory(history);
                    break;
                default:
                    break;
            }
        }

        private void LoadHistory(object sender, EventArgs e)
        {
            handler(HomePageState.LoadRecentNovels);
        }

        private void LoadReadHistory(List<HistoryInfo> history)
        {
            UxLastReadListBox.Items.Clear();
            foreach (HistoryInfo info in history)
            {
                UxLastReadListBox.Items.Add($"{info.ChapterTitle} - Last read on {info.LastReadDate}");
            }
        }
    }
}
