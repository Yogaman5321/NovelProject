using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovelProject.CommentPage
{
    public partial class Prompt : Form
    {
        public static string ShowDialog(string title, string prompt)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = prompt;

            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Width = 360;
            textBox.Height = 150;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(10, 10, 360, 20);
            textBox.SetBounds(10, 35, 360, 150);
            buttonOk.SetBounds(210, 195, 75, 30);
            buttonCancel.SetBounds(295, 195, 75, 30);

            label.AutoSize = true;

            form.ClientSize = new Size(380, 240);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterParent;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            return form.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }
}