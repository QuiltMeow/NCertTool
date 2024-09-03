using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCertListParser
{
    public partial class WebForm : Form
    {
        private bool complete;

        public WebForm()
        {
            InitializeComponent();
        }

        public void setTitle(string title)
        {
            Text = title;
        }

        public WebView2 getWebView()
        {
            return wvMain;
        }

        private void WebForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void wvMain_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            complete = true;
        }

        public void resetComplete()
        {
            complete = false;
        }

        public void waitComplete()
        {
            const int WAIT_QUERY = 100;
            const int WAIT_AFTER_COMPLETE = 1000;
            while (!complete)
            {
                Thread.Sleep(WAIT_QUERY);
            }
            Thread.Sleep(WAIT_AFTER_COMPLETE);
        }

        public void navigateThreadSafe(string url)
        {
            wvMain.Invoke((MethodInvoker)delegate
            {
                wvMain.Source = new Uri(url);
            });
        }

        public async Task<string> executeScriptThreadSafe(string code)
        {
            Func<Task<string>> function = async () =>
            {
                return Util.decodeScriptResult(await wvMain.CoreWebView2.ExecuteScriptAsync(code));
            };

            if (InvokeRequired)
            {
                Task<string> task = (Task<string>)Invoke(function);
                return await task;
            }
            return await function();
        }
    }
}