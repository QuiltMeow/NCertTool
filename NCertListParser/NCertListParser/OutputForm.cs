using System;
using System.Drawing;
using System.Windows.Forms;

namespace NCertListParser
{
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
        }

        public void setTitle(string title)
        {
            Text = title;
        }

        public void appendTextThreadSafe(string text, bool newLine = true)
        {
            appendTextThreadSafe(text, Color.Black, newLine);
        }

        public void appendTextThreadSafe(string text, Color color, bool newLine = true)
        {
            Util.appendTextThreadSafe(txtOutput, text, color, newLine);
        }

        public string getText()
        {
            return txtOutput.Text;
        }

        public void clearText()
        {
            txtOutput.Clear();
        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void OutputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}