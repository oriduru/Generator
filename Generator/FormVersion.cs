using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Generater
{
    /// <summary>
    /// バージョン情報
    /// </summary>
    public partial class FormVersion : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormVersion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// shownイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void version_Shown(object sender, EventArgs e)
        {
            versionValue.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// 社章画像クリックイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void companyLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.fict.jp/");
        }

        /// <summary>
        /// キープレスイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void FormVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.ProcessKeyPress((Form)sender, e);
        }
    }
}
