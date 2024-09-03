using System;
using System.Windows.Forms;

namespace NCertListParser
{
    public partial class InputForm : Form
    {
        public bool confirm
        {
            get;
            private set;
        }

        public string submitText
        {
            get;
            private set;
        }

        public void setTitle(string title)
        {
            Text = title;
        }

        public InputForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("請輸入內容", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            submitText = text;
            confirm = true;
            Close();
        }
    }
}