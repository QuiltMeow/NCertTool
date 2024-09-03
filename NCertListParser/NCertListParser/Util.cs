using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NCertListParser
{
    public static class Util
    {
        public static string decodeScriptResult(string html)
        {
            html = Regex.Unescape(html);
            html = html.Remove(0, 1);
            html = html.Remove(html.Length - 1, 1);
            return html;
        }

        public static void appendTextThreadSafe(RichTextBox textBox, string text, Color color, bool newLine = true)
        {
            if (text == null)
            {
                return;
            }
            textBox.Invoke((MethodInvoker)delegate
            {
                textBox.SelectionStart = textBox.TextLength;
                textBox.SelectionLength = 0;

                textBox.SelectionColor = color;
                textBox.AppendText($"{text}{(newLine ? Environment.NewLine : string.Empty)}");
                textBox.SelectionColor = textBox.ForeColor;
            });
        }
    }
}