using System;
using System.Windows.Forms;

namespace Generater
{
    public static class Common
    {
        /// <summary>
        /// テキストボックスの文字列を数値に変換
        /// </summary>
        /// <param name="textBox">テキストボックスコントロール</param>
        /// <returns>成功時：数値　失敗時：-1</returns>
        public static int ParseTextBox(TextBox textBox)
        {
            int ret;

            try
            {
                ret = int.Parse(textBox.Text);
            }
            catch
            {
                textBox.Focus();
                textBox.SelectAll();
                ret = -1;
            }

            return ret;
        }

        /// <summary>
        /// フォームのキープレスイベントの処理を共通化
        /// </summary>
        /// <param name="sender">イベント発生源（フォーム）</param>
        /// <param name="e">イベント引数</param>
        public static void ProcessKeyPress(Form sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                sender.Close();
            }
        }
    }
}
