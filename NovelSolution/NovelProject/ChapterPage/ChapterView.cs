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
    public partial class ChapterView : UserControl
    {

        private ChapterController _controller;

        public ChapterView(string title, int chapter)
        {
            InitializeComponent();

            _controller = new ChapterController(title);
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

        }


    }
}
