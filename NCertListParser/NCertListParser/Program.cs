using System;
using System.Windows.Forms;

namespace NCertListParser
{
    public static class Program
    {
        public static WebForm web
        {
            get;
            private set;
        }

        public static OutputForm output
        {
            get;
            private set;
        }

        public static OutputForm progress
        {
            get;
            private set;
        }

        public static CustomCodeForm customCode
        {
            get;
            private set;
        }

        public static MainForm main
        {
            get;
            private set;
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            output = new OutputForm();
            output.setTitle("輸出視窗");

            progress = new OutputForm();
            progress.setTitle("進度視窗");

            web = new WebForm();
            web.setTitle("Web View 視窗 (國家資通安全通報應變網站)");
            navigateHomePage();

            customCode = new CustomCodeForm();
            main = new MainForm();
            Application.Run(main);
        }

        public static void initHandle(Form form)
        {
            form.Show();
            form.Hide();
        }

        public static void initHandle()
        {
            initHandle(output);
            initHandle(progress);
            initHandle(web);
        }

        public static void navigateHomePage()
        {
            web.getWebView().Source = new Uri(Constant.HOME_PAGE);
        }
    }
}