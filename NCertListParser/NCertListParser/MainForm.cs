using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCertListParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Program.navigateHomePage();
        }

        private async void btnCrawlId_Click(object sender, EventArgs e)
        {
            enableControl(false);
            try
            {
                Program.output.appendTextThreadSafe(await Program.web.executeScriptThreadSafe(Constant.ID_CRAWL_CODE));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"採集編號時發生例外狀況 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableControl(true);

            void enableControl(bool enable)
            {
                btnCrawlId.Enabled = enable;
            }
        }

        private async void btnCrawlDetailData_Click(object sender, EventArgs e)
        {
            enableControl(false);
            try
            {
                Program.output.appendTextThreadSafe(await Program.web.executeScriptThreadSafe(Constant.DETAIL_DATA_CRAWL_CODE));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"採集詳細資料時發生例外狀況 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableControl(true);

            void enableControl(bool enable)
            {
                btnCrawlDetailData.Enabled = enable;
            }
        }

        private void btnOutputForm_Click(object sender, EventArgs e)
        {
            Program.output.Show();
        }

        private async void btnCrawlAllId_Click(object sender, EventArgs e)
        {
            const string URL_PREFIX = "https://www.ncert.nat.gov.tw/NoticeAna/anaList.do?pageNum=";

            int page;
            using (InputForm form = new InputForm())
            {
                form.setTitle("請輸入總頁數");
                form.ShowDialog();
                if (!form.confirm)
                {
                    return;
                }

                try
                {
                    page = int.Parse(form.submitText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"輸入數值錯誤 : {ex.Message}", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Program.progress.appendTextThreadSafe($"任務派發 : 應採集 {page} 頁 ID 資料");

            enableControl(false);
            try
            {
                using (FileStream fs = new FileStream(Constant.ID_LIST_FILE, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        WebForm web = Program.web;
                        for (int i = 1; i <= page; ++i)
                        {
                            Program.progress.appendTextThreadSafe($"進度回報 : 正在採集第 {i} 頁 ID 資料");
                            await Task.Run(async () =>
                            {
                                web.resetComplete();
                                web.navigateThreadSafe($"{URL_PREFIX}{i}");
                                web.waitComplete();
                                sw.Write(await Program.web.executeScriptThreadSafe(Constant.ID_CRAWL_CODE));
                            });
                            Program.progress.appendTextThreadSafe($"進度回報 : 已完成採集第 {i} 頁 ID 資料");
                        }
                        Program.progress.appendTextThreadSafe($"採集完成 : 已完成採集 {page} 頁 ID 資料");
                    }
                }
            }
            catch (Exception ex)
            {
                Program.progress.appendTextThreadSafe($"批量採集編號時發生例外狀況 : {ex}", Color.Red);
                MessageBox.Show($"批量採集編號時發生例外狀況 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableControl(true);

            void enableControl(bool enable)
            {
                btnCrawlAllId.Enabled = enable;
            }
        }

        private async void btnCrawlAllDetailData_Click(object sender, EventArgs e)
        {
            const string URL_PREFIX = "https://www.ncert.nat.gov.tw/NoticeAna/anaDetail.do?id=";

            List<string> idList = new List<string>();
            using (InputForm form = new InputForm())
            {
                form.setTitle("請輸入警訊編號 (一行一個)");
                form.ShowDialog();

                if (!form.confirm)
                {
                    return;
                }
                idList.AddRange(form.submitText.Replace("\r", string.Empty).Split(new string[] {
                    "\n"
                }, StringSplitOptions.RemoveEmptyEntries));
            }
            int count = idList.Count;
            Program.progress.appendTextThreadSafe($"任務派發 : 應採集 {count} 筆警訊詳細資料");

            enableControl(false);
            try
            {
                using (FileStream fs = new FileStream(Constant.DETAIL_DATA_LIST_FILE, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        WebForm web = Program.web;
                        for (int i = 0; i < count; ++i)
                        {
                            string id = idList[i];
                            string progress = $"第 {i + 1} 筆警訊詳細資料 ({id})";
                            Program.progress.appendTextThreadSafe($"進度回報 : 正在採集{progress}");
                            await Task.Run(async () =>
                            {
                                web.resetComplete();
                                web.navigateThreadSafe($"{URL_PREFIX}{id}");
                                web.waitComplete();
                                sw.WriteLine(await Program.web.executeScriptThreadSafe(Constant.DETAIL_DATA_CRAWL_CODE));
                            });
                            Program.progress.appendTextThreadSafe($"進度回報 : 已完成採集{progress}");
                        }
                        Program.progress.appendTextThreadSafe($"採集完成 : 已完成採集 {count} 筆警訊詳細資料");
                    }
                }
            }
            catch (Exception ex)
            {
                Program.progress.appendTextThreadSafe($"批量採集詳細資料時發生例外狀況 : {ex}", Color.Red);
                MessageBox.Show($"批量採集詳細資料時發生例外狀況 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableControl(true);

            void enableControl(bool enable)
            {
                btnCrawlAllDetailData.Enabled = enable;
            }
        }

        private void btnWebForm_Click(object sender, EventArgs e)
        {
            Program.web.Show();
        }

        private void btnCustomCode_Click(object sender, EventArgs e)
        {
            Program.customCode.Show();
        }

        private void timerInit_Tick(object sender, EventArgs e)
        {
            timerInit.Stop();
            Program.initHandle();
        }

        private void btnProgressForm_Click(object sender, EventArgs e)
        {
            Program.progress.Show();
        }
    }
}