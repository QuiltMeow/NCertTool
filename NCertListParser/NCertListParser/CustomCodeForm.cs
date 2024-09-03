using Microsoft.Web.WebView2.Core;
using ScintillaNET;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cpp = ScintillaNET.Style.Cpp;

namespace NCertListParser
{
    public partial class CustomCodeForm : Form
    {
        public CustomCodeForm()
        {
            InitializeComponent();
            initCodeTool();
        }

        private void setEnable(bool enable)
        {
            txtCode.Enabled = btnExecute.Enabled = false;
        }

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("請輸入自訂程式碼", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            setEnable(false);
            CoreWebView2ExecuteScriptResult result = await Program.web.getWebView().CoreWebView2.ExecuteScriptWithResultAsync(code);
            StringBuilder sb = new StringBuilder();
            if (result.Succeeded)
            {
                sb.Append("執行結果 : ");
                sb.AppendLine(result.ResultAsJson);

                sb.Append("返回字串 : ");
                int isSuccess;
                string resultString;
                result.TryGetResultAsString(out resultString, out isSuccess);
                if (isSuccess == 1)
                {
                    sb.Append(resultString);
                }
                else
                {
                    sb.Append("無法取得返回字串");
                }
            }
            else
            {
                CoreWebView2ScriptException exception = result.Exception;
                sb.AppendLine("執行腳本時發生例外狀況");
                sb.AppendLine($"例外狀況名稱 : {exception.Name}");
                sb.AppendLine($"例外狀況訊息 : {exception.Message}");
                sb.AppendLine($"例外狀況 JSON : {exception.ToJson}");
                sb.AppendLine($"Line Number : {exception.LineNumber}");
                sb.Append($"Column Number : {exception.ColumnNumber}");
            }
            txtResult.Text = sb.ToString();
            setEnable(true);
        }

        private void CustomCodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        // 此函式庫版本暫無 Java Script Lexer
        private void initCodeTool()
        {
            const int DEFAULT = Style.Default;

            txtCode.StyleResetDefault();
            StyleCollection style = txtCode.Styles;
            style[DEFAULT].Font = "Consolas";
            style[DEFAULT].Size = 10;

            txtCode.StyleClearAll();
            style[Cpp.Default].ForeColor = Color.Silver;
            style[Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0); // 綠
            style[Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0);
            style[Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128); // 灰
            style[Cpp.Number].ForeColor = Color.Olive;
            style[Cpp.Word].ForeColor = Color.Blue;
            style[Cpp.Word2].ForeColor = Color.Blue;
            style[Cpp.String].ForeColor = Color.FromArgb(163, 21, 21); // 紅
            style[Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21);
            style[Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21);
            style[Cpp.StringEol].BackColor = Color.Pink;
            style[Cpp.Operator].ForeColor = Color.Purple;
            style[Cpp.Preprocessor].ForeColor = Color.Maroon;
            txtCode.LexerName = "cpp";

            txtCode.SetKeywords(0, "abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach goto if implicit in interface internal is lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof stackalloc switch this throw true try typeof unchecked unsafe using virtual while function");
            txtCode.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void dynamic var let");
        }
    }
}