using NovelProject.Models;
using NovelProject.Navigation;
using NovelProject.NovelPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject.ChapterPage
{
    public partial class ChapterView : UserControl, INavigatable
    {

        private ChapterController _controller;

        private Novel _novel;
        public ChapterView(Novel novel, int chapter)
        {
            InitializeComponent();
            
            _novel = novel;
            _controller = new ChapterController(novel.NovelId.ToString());
            SetController(_controller);
            _controller.SetChapter(chapter);
        }

        public void SetController(ChapterController controller)
        {
            _controller = controller;

            _controller.OnDisplayChapter += DisplayChapter;
        }

        public void DisplayChapter(String chapter)
        {
            uxTextBox.Text = chapter;
            uxChapterLabel.Text = $"Chapter {_controller.CurrentChapter}";

            _controller.UpdateReadHistory();
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            _controller.ChangeChapter(1);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            _controller.ChangeChapter(-1);
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            _navigate?.Invoke(new NovelView(_novel));
        }

        private Action<UserControl> _navigate;
        public void SetNavigator(Action<UserControl> navigate)
        {
            _navigate = navigate;
        }
    }
}
