using System;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Generater.Functions;

namespace Generater
{
    /// <summary>
    /// メインフォーム
    /// </summary>
    public partial class FormMain : Form
    {
        #region メンバ定数

        private const string TAB_PASSWORD = "パスワード";
        private const string TAB_GUID = "Guid";
        private const string TAB_HASH = "文字列ハッシュ";
        private const string TAB_BASE64 = "文字列Base64";
        private const string TAB_FILEHASH = "ファイルハッシュ";
        private const string TAB_FILEBASE64 = "ファイルBase64";
        private const string TAB_URLENCODE = "URLエンコード";

        #endregion

        #region メンバ変数

        /// <summary>
        /// 作業ディレクトリ
        /// </summary>
        private string _workDir = string.Empty;

        /// <summary>
        /// エンコード中
        /// </summary>
        private bool _processingEncode = false;

        #endregion

        #region デリゲート

        /// <summary>
        /// 実処理のデリゲート
        /// </summary>
        private delegate void process();

        /// <summary>
        /// 実処理のデリゲート
        /// </summary>
        private process _process;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        #region フォームイベント
        /// <summary>
        /// フォーム表示イベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void FormMain_Shown(object sender, EventArgs e)
        {
            try
            {
                //設定取得
                _workDir = ConfigurationManager.AppSettings["WorkDir"];

                //初期選択はパスワード生成機能
                ActivateExecButton(GetPassword);
                savePath.Text = _workDir + $"Password_{DateTime.Now:yyyyMMdd}.txt";
                passwordCount.Focus();

                //エンコード
                encodingText.Items.Add("shift_jis");
                encodingText.Items.Add("utf-8");

                //共通部品タブを隠す
                tabContents.TabPages.Remove(tabCommonParts);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// バージョン情報ダイアログを表示
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void menuHelpVersion_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormVersion();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// 保存先選択ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void selectSavePath_Click(object sender, EventArgs e)
        {
            try
            {
                var sfd = new SaveFileDialog();

                if (string.IsNullOrWhiteSpace(savePath.Text))
                {
                    sfd.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    sfd.FileName = $"MyText_{DateTime.Now:yyyyMMdd}.txt";
                }
                else
                {
                    sfd.InitialDirectory = Path.GetDirectoryName(savePath.Text);
                    sfd.FileName = Path.GetFileName(savePath.Text);
                }
                sfd.Filter = "テキストファイル(*.txt)|*.txt";
                sfd.Title = "名前を付けてファイルを保存";
                sfd.OverwritePrompt = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    savePath.Text = sfd.FileName;

                    //作業ディレクトリを更新
                    var workDir = Path.GetDirectoryName(sfd.FileName);
                    if (workDir.EndsWith(@"\"))
                    {
                        _workDir = workDir;
                    }
                    else
                    {
                        _workDir = workDir + @"\";
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// タブインデックス変更イベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void tabContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabContents.SelectedTab.Text)
            {
                case TAB_PASSWORD:
                    ActivateExecButton(GetPassword);
                    savePath.Text = _workDir + $"Password_{DateTime.Now:yyyyMMdd}.txt";
                    break;

                case TAB_GUID:
                    ActivateExecButton(GetGuid);
                    savePath.Text = _workDir + $"Guid_{DateTime.Now:yyyyMMdd}.txt";
                    break;

                case TAB_HASH:
                    tabStringHash.Controls.Add(groupEncoding);
                    tabStringHash.Controls.Add(groupOutputFormat);
                    tabStringHash.Controls.Add(groupAlgorithm);
                    groupEncoding.Location = new System.Drawing.Point(hashEncoding.Location.X, hashEncoding.Location.Y);
                    groupOutputFormat.Location = new System.Drawing.Point(hashOutputFormat.Location.X, hashOutputFormat.Location.Y);
                    groupAlgorithm.Location = new System.Drawing.Point(hashAlgorithm.Location.X, hashAlgorithm.Location.Y);

                    ActivateExecButton(null);
                    savePath.Text = _workDir + $"Hash_{DateTime.Now:yyyyMMdd}.txt";
                    break;

                case TAB_BASE64:
                    tabStringBase64.Controls.Add(groupEncoding);
                    groupEncoding.Location = new System.Drawing.Point(base64Encording.Location.X, base64Encording.Location.Y);

                    ActivateExecButton(null);
                    savePath.Text = _workDir + $"Base64_{DateTime.Now:yyyyMMdd}.txt";
                    break;

                case TAB_FILEHASH:
                    tabFileHash.Controls.Add(groupOutputFormat);
                    tabFileHash.Controls.Add(groupAlgorithm);
                    groupOutputFormat.Location = new System.Drawing.Point(fileHashOutputFormat.Location.X, fileHashOutputFormat.Location.Y);
                    groupAlgorithm.Location = new System.Drawing.Point(fileHashAlgorithm.Location.X, fileHashAlgorithm.Location.Y);

                    ActivateExecButton(GetFileHash);
                    savePath.Text = _workDir + $"FileHash_{DateTime.Now:yyyyMMdd}.txt";
                    break;

                case TAB_FILEBASE64:
                    ActivateExecButton(GetFileBase64);
                    savePath.Text = _workDir + $"FileBase64_{DateTime.Now:yyyyMMdd}.txt";
                    break;

                case TAB_URLENCODE:
                    ActivateExecButton(null);
                    savePath.Text = _workDir + $"UrlEncode_{DateTime.Now:yyyyMMdd}.txt";
                    break;

                default:
                    ActivateExecButton(null);
                    ShowErrorMessage("未実装の処理を実行しようとしました。");
                    break;
            }
        }

        /// <summary>
        /// ファイル選択ダイアログ表示ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void fileHashOpenDialog_Click(object sender, EventArgs e)
        {
            try
            {
                var path = OpenFileDialogWrapper(fileHashFilePath.Text);
                if (!string.IsNullOrEmpty(path))
                {
                    fileHashFilePath.Text = path;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// ファイル選択ダイアログ表示ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void fileBase64OpenDialog_Click(object sender, EventArgs e)
        {
            try
            {
                var path = OpenFileDialogWrapper(fileBase64FilePath.Text);
                if (!string.IsNullOrEmpty(path))
                {
                    fileBase64FilePath.Text = path;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// 生成ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void exec_Click(object sender, EventArgs e)
        {
            try
            {
                _process?.Invoke();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// 結果テキストボックス変更イベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(result.Text))
                {
                    copy.Enabled = false;
                    save.Enabled = false;
                }
                else
                {
                    copy.Enabled = true;
                    if (string.IsNullOrWhiteSpace(savePath.Text))
                    {
                        save.Enabled = false;
                    }
                    else
                    {
                        save.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// 保存先パステキストボックス変更イベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void savePath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(result.Text) || string.IsNullOrWhiteSpace(savePath.Text))
                {
                    save.Enabled = false;
                }
                else
                {
                    save.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// クリップボードにコピーボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(result.Text, true);
                toolTip.SetToolTip(copy, "クリップボードにコピーしました。");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// クリップボードにコピーボタンマウスリーブイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copy_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                toolTip.RemoveAll();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// 保存ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(savePath.Text))
                {
                    var msg = $"{Path.GetFileName(savePath.Text)} は既に存在します。\r\n上書きしてよろしいですか？";
                    if (MessageBox.Show(msg, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                using (var sw = new StreamWriter(savePath.Text, false))
                {
                    sw.Write(result.Text);
                }
                toolTip.SetToolTip(save, "保存しました。");
            }
            catch (UnauthorizedAccessException)
            {
                ShowErrorMessage($"権限が不足しています。{Environment.NewLine}権限を取得するか、他の出力先を試してください。");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// 保存ボタンからマウスが外れたイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void save_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                toolTip.RemoveAll();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// キープレスイベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.ProcessKeyPress((Form)sender, e);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region 機能
        #region パスワード生成
        /// <summary>
        /// パスワード生成
        /// </summary>
        private void GetPassword()
        {
            try
            {
                int cnt = Common.ParseTextBox(passwordCount);
                int len = Common.ParseTextBox(passwordLength);
                var ins = new GeneratePassword(cnt, len);
                result.Text = ins.Execute();
            }
            catch (FunctionException ex)
            {
                switch (ex.ErrorCode)
                {
                    case GeneratePassword.PASSWORD_COUNT_NOT_INPUT:
                    case GeneratePassword.PASSWORD_COUNT_OUT_OF_RANGE:
                        break;

                    case GeneratePassword.PASSWORD_LENGTH_NOT_INPUT:
                    case GeneratePassword.PASSWORD_LENGTH_OUT_OF_RANGE:
                        break;

                    default:
                        break;
                }
                ShowErrorMessage(ex.Message);
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Guid生成
        /// <summary>
        /// Guid生成
        /// </summary>
        private void GetGuid()
        {
            try
            {
                int cnt = Common.ParseTextBox(guidCount);
                var ins = new GenerateGuid(cnt);
                result.Text = ins.Execute();
            }
            catch (FunctionException ex)
            {
                switch (ex.ErrorCode)
                {
                    case GenerateGuid.GUID_COUNT_NOT_INPUT:
                    case GenerateGuid.GUID_COUNT_OUT_OF_RANGE:
                        break;

                    default:
                        break;
                }
                ShowErrorMessage(ex.Message);
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region 文字列ハッシュ値生成
        /// <summary>
        /// Hashテキスト編集イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hashPlainText_TextChanged(object sender, EventArgs e)
        {
            if (_processingEncode == false)
            {
                _processingEncode = true;
                var ins = new GenerateStringHash(hashPlainText.Text, GetHashAlgorithm(), GetEncoding(encodingText.Text), hashOutputFormatBase64.Checked);
                hashHashText.Text = ins.Execute();
                _processingEncode = false;
            }
        }
        #endregion

        #region 文字列Base64生成
        /// <summary>
        /// Base64プレーンテキスト編集イベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void base64PlainText_TextChanged(object sender, EventArgs e)
        {
            if (_processingEncode == false)
            {
                _processingEncode = true;
                var ins = new GenerateStringBase64(base64PlainText.Text, false, GetEncoding(encodingText.Text));
                base64Base64Text.Text = ins.Execute();
                _processingEncode = false;
            }
        }

        /// <summary>
        /// Base64テキスト編集イベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void base64Base64Text_TextChanged(object sender, EventArgs e)
        {
            if (_processingEncode == false)
            {
                _processingEncode = true;
                var ins = new GenerateStringBase64(base64Base64Text.Text, true, GetEncoding(encodingText.Text));
                base64PlainText.Text = ins.Execute();
                _processingEncode = false;
            }
        }

        /// <summary>
        /// Base64ヘルプクリック
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void base64Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            base64Help.LinkVisited = true;
            System.Diagnostics.Process.Start("https://msdn.microsoft.com/ja-jp/library/system.text.encoding.aspx#備考");
        }
        #endregion

        #region ファイルハッシュ値生成
        /// <summary>
        /// ハッシュ値生成
        /// </summary>
        private void GetFileHash()
        {
            try
            {
                using (var hashAlgorithm = GetHashAlgorithm())
                {
                    var ins = new GenerateFileHash(fileHashFilePath.Text, hashAlgorithm, hashOutputFormatBase64.Checked);
                    result.Text = ins.Execute();
                }
            }
            catch (FunctionException ex)
            {
                switch (ex.ErrorCode)
                {
                    case GenerateFileHash.FILEHASH_FILE_NOT_FOUND:
                        fileHashFilePath.Focus();
                        break;

                    case GenerateFileHash.FILEHASH_ALGORITHM_NOT_SELECTED:
                        groupAlgorithm.Focus();
                        break;

                    default:
                        break;
                }
                ShowErrorMessage(ex.Message);
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region ファイルBase64生成
        /// <summary>
        /// ハッシュ値生成
        /// </summary>
        private void GetFileBase64()
        {
            try
            {
                //Base64文字列取得
                var ins = new GenerateFileBase64(fileBase64FilePath.Text, fileBase64Decode.Checked);
                var base64 = ins.Execute();
                if (base64.Length > result.MaxLength)
                {
                    result.Text = base64.Substring(0, result.MaxLength);
                }
                else
                {
                    result.Text = base64;
                }

                //ファイル出力
                var sfd = new SaveFileDialog();
                if (fileBase64Decode.Checked)
                {
                    sfd.Filter = "すべてのファイル(*.*)|*.*";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var fs = new FileStream(sfd.FileName, FileMode.Create))
                        using (var bw = new BinaryWriter(fs))
                        {
                            var fileBytes = Convert.FromBase64String(base64);
                            bw.Write(fileBytes);
                        }
                        MessageBox.Show("ファイルを保存しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    sfd.Filter = "テキスト ファイル(*.txt)|*.txt";
                    sfd.AddExtension = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var sw = new StreamWriter(sfd.FileName, false))
                        {
                            sw.Write(base64);
                        }
                        MessageBox.Show("ファイルを保存しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (FunctionException ex)
            {
                switch (ex.ErrorCode)
                {
                    case GenerateFileBase64.BASE64FROMFILE_FILE_NOT_FOUND:
                        fileHashFilePath.Focus();
                        break;

                    case GenerateFileBase64.BASE64FROMFILE_EXCEPTION:
                        groupAlgorithm.Focus();
                        break;

                    default:
                        break;
                }
                ShowErrorMessage(ex.Message);
                return;
            }
            catch (FormatException ex)
            {
                string msg = $"{ex.Message}{Environment.NewLine}結果ペインで有効なBase-64文字列であることを確認してください。";
                ShowErrorMessage(msg);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region URLエンコード
        /// <summary>
        /// URLエンコードプレーンテキスト編集イベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void uriEscapePlainText_TextChanged(object sender, EventArgs e)
        {
            if (_processingEncode == false)
            {
                _processingEncode = true;
                var ins = new GenerateUriEscape(uriEscapePlainText.Text, uriEscapeRFC3986.Checked);
                uriEscapeEncodedText.Text = ins.Execute();
                _processingEncode = false;
            }
        }

        /// <summary>
        /// URLエンコードエンコード後テキスト編集イベント
        /// </summary>
        /// <param name="sender">イベント発生源</param>
        /// <param name="e">イベント引数</param>
        private void uriEscapeEncodedText_TextChanged(object sender, EventArgs e)
        {
            if (_processingEncode == false)
            {
                _processingEncode = true;
                var ins = new GenerateUriEscape(uriEscapeEncodedText.Text, uriEscapeRFC3986.Checked, true);
                uriEscapePlainText.Text = ins.Execute();
                _processingEncode = false;
            }
        }
        #endregion
        #endregion

        #region メンバメソッド

        /// <summary>
        /// 実行ボタンの動作を決定し、押下可否を変更する
        /// </summary>
        /// <param name="action"></param>
        private void ActivateExecButton(process action)
        {
            _process = action;
            if (action == null)
            {
                exec.Enabled = false;
            }
            else
            {
                exec.Enabled = true;
            }
        }

        /// <summary>
        /// ハッシュアルゴリズムの取得
        /// </summary>
        /// <returns></returns>
        private HashAlgorithm GetHashAlgorithm()
        {
            if (hashAlgoMD5.Checked)
            { return new MD5CryptoServiceProvider(); }
            else if (hashAlgoSHA1.Checked)
            { return new SHA1CryptoServiceProvider(); }
            else if (hashAlgoSHA256.Checked)
            { return new SHA256CryptoServiceProvider(); }
            else if (hashAlgoSHA384.Checked)
            { return new SHA384CryptoServiceProvider(); }
            else if (hashAlgoSHA512.Checked)
            { return new SHA512CryptoServiceProvider(); }

            hashAlgoSHA256.Checked = true;
            return new SHA256CryptoServiceProvider();
        }

        /// <summary>
        /// エンコードを返却する
        /// </summary>
        /// <param name="codePage">コードページ（数値、またはコードページ名）</param>
        /// <returns>エンコード</returns>
        private Encoding GetEncoding(string codePage)
        {
            if (String.IsNullOrWhiteSpace(codePage))
            {
                return null;
            }

            Encoding ret = null;
            try
            {
                int num;
                if (int.TryParse(codePage, out num))
                {
                    ret = Encoding.GetEncoding(num);
                }
                else
                {
                    ret = Encoding.GetEncoding(codePage);
                }
            }
            catch
            {
                //nullを返却
            }
            return ret;
        }

        /// <summary>
        /// OpenFileDialogを表示する
        /// </summary>
        /// <returns></returns>
        private string OpenFileDialogWrapper(string initialDirectory = "")
        {
            var ret = string.Empty;

            //ダイアログを表示する
            var ofd = new OpenFileDialog();
            if (string.IsNullOrWhiteSpace(initialDirectory) == false)
            {
                ofd.InitialDirectory = initialDirectory;
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ret = ofd.FileName;
            }

            return ret;
        }

        /// <summary>
        /// エラーメッセージダイアログを表示する
        /// </summary>
        /// <param name="message">エラーメッセージ</param>
        /// <returns></returns>
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
