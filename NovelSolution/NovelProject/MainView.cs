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

        public MainView(string username)
        {
            InitializeComponent();
            _username = username;
            usernameLabel.Text = _username;
        }
    }
}
