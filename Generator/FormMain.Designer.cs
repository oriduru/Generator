namespace Generater
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripHelp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exec = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.passwordCount = new System.Windows.Forms.TextBox();
            this.passwordLength = new System.Windows.Forms.TextBox();
            this.passwordCountUnit = new System.Windows.Forms.Label();
            this.passwordLengthUnit = new System.Windows.Forms.Label();
            this.passwordCountTitle = new System.Windows.Forms.Label();
            this.passwordLengthTitle = new System.Windows.Forms.Label();
            this.savePath = new System.Windows.Forms.TextBox();
            this.savePathTitle = new System.Windows.Forms.Label();
            this.selectSavePath = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.guidCountTitle = new System.Windows.Forms.Label();
            this.guidCount = new System.Windows.Forms.TextBox();
            this.guidCountUnit = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabContents = new System.Windows.Forms.TabControl();
            this.tabPassword = new System.Windows.Forms.TabPage();
            this.tabGuid = new System.Windows.Forms.TabPage();
            this.tabStringHash = new System.Windows.Forms.TabPage();
            this.hashEncoding = new System.Windows.Forms.Label();
            this.hashAlgorithm = new System.Windows.Forms.Label();
            this.hashOutputFormat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hashHashText = new System.Windows.Forms.TextBox();
            this.hashPlainText = new System.Windows.Forms.TextBox();
            this.tabStringBase64 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.base64Base64Text = new System.Windows.Forms.TextBox();
            this.base64PlainText = new System.Windows.Forms.TextBox();
            this.base64Encording = new System.Windows.Forms.Label();
            this.tabFileHash = new System.Windows.Forms.TabPage();
            this.fileHashAlgorithm = new System.Windows.Forms.Label();
            this.fileHashOutputFormat = new System.Windows.Forms.Label();
            this.fileHashFilePath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fileHashOpenDialog = new System.Windows.Forms.Button();
            this.tabFileBase64 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileBase64Decode = new System.Windows.Forms.RadioButton();
            this.fileBase64Encode = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.base64OpenDialog = new System.Windows.Forms.Button();
            this.fileBase64FilePath = new System.Windows.Forms.TextBox();
            this.tabUrlEncode = new System.Windows.Forms.TabPage();
            this.tabCommonParts = new System.Windows.Forms.TabPage();
            this.groupEncoding = new System.Windows.Forms.GroupBox();
            this.base64Help = new System.Windows.Forms.LinkLabel();
            this.encodingText = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupOutputFormat = new System.Windows.Forms.GroupBox();
            this.hashOutputFormatBase64 = new System.Windows.Forms.RadioButton();
            this.hashOutputFormatHex = new System.Windows.Forms.RadioButton();
            this.groupAlgorithm = new System.Windows.Forms.GroupBox();
            this.hashAlgoSHA512 = new System.Windows.Forms.RadioButton();
            this.hashAlgoSHA384 = new System.Windows.Forms.RadioButton();
            this.hashAlgoSHA256 = new System.Windows.Forms.RadioButton();
            this.hashAlgoSHA1 = new System.Windows.Forms.RadioButton();
            this.hashAlgoMD5 = new System.Windows.Forms.RadioButton();
            this.uriEscapeRFC3986 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.uriEscapeEncodedText = new System.Windows.Forms.TextBox();
            this.uriEscapePlainText = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.tabContents.SuspendLayout();
            this.tabPassword.SuspendLayout();
            this.tabGuid.SuspendLayout();
            this.tabStringHash.SuspendLayout();
            this.tabStringBase64.SuspendLayout();
            this.tabFileHash.SuspendLayout();
            this.tabFileBase64.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabUrlEncode.SuspendLayout();
            this.tabCommonParts.SuspendLayout();
            this.groupEncoding.SuspendLayout();
            this.groupOutputFormat.SuspendLayout();
            this.groupAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(545, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpVersion});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(75, 22);
            this.menuHelp.Text = "ヘルプ(&H)";
            // 
            // menuHelpVersion
            // 
            this.menuHelpVersion.Name = "menuHelpVersion";
            this.menuHelpVersion.Size = new System.Drawing.Size(178, 22);
            this.menuHelpVersion.Text = "バージョン情報(&A)";
            this.menuHelpVersion.Click += new System.EventHandler(this.menuHelpVersion_Click);
            // 
            // contextMenuStripHelp
            // 
            this.contextMenuStripHelp.Name = "contextMenuStrip1";
            this.contextMenuStripHelp.Size = new System.Drawing.Size(61, 4);
            // 
            // exec
            // 
            this.exec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exec.Location = new System.Drawing.Point(24, 404);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(75, 23);
            this.exec.TabIndex = 500;
            this.exec.Text = "生成";
            this.exec.UseVisualStyleBackColor = true;
            this.exec.Click += new System.EventHandler(this.exec_Click);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.result.Location = new System.Drawing.Point(24, 433);
            this.result.MaxLength = 2147483647;
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(500, 99);
            this.result.TabIndex = 530;
            this.result.WordWrap = false;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // passwordCount
            // 
            this.passwordCount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.passwordCount.Location = new System.Drawing.Point(72, 20);
            this.passwordCount.MaxLength = 3;
            this.passwordCount.Name = "passwordCount";
            this.passwordCount.Size = new System.Drawing.Size(43, 19);
            this.passwordCount.TabIndex = 10;
            this.passwordCount.Text = "10";
            this.passwordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLength
            // 
            this.passwordLength.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.passwordLength.Location = new System.Drawing.Point(72, 45);
            this.passwordLength.MaxLength = 3;
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(43, 19);
            this.passwordLength.TabIndex = 20;
            this.passwordLength.Text = "12";
            this.passwordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordCountUnit
            // 
            this.passwordCountUnit.AutoSize = true;
            this.passwordCountUnit.Location = new System.Drawing.Point(121, 23);
            this.passwordCountUnit.Name = "passwordCountUnit";
            this.passwordCountUnit.Size = new System.Drawing.Size(17, 12);
            this.passwordCountUnit.TabIndex = 3;
            this.passwordCountUnit.Text = "個";
            // 
            // passwordLengthUnit
            // 
            this.passwordLengthUnit.AutoSize = true;
            this.passwordLengthUnit.Location = new System.Drawing.Point(121, 48);
            this.passwordLengthUnit.Name = "passwordLengthUnit";
            this.passwordLengthUnit.Size = new System.Drawing.Size(17, 12);
            this.passwordLengthUnit.TabIndex = 3;
            this.passwordLengthUnit.Text = "桁";
            // 
            // passwordCountTitle
            // 
            this.passwordCountTitle.AutoSize = true;
            this.passwordCountTitle.Location = new System.Drawing.Point(23, 23);
            this.passwordCountTitle.Name = "passwordCountTitle";
            this.passwordCountTitle.Size = new System.Drawing.Size(41, 12);
            this.passwordCountTitle.TabIndex = 3;
            this.passwordCountTitle.Text = "生成数";
            // 
            // passwordLengthTitle
            // 
            this.passwordLengthTitle.AutoSize = true;
            this.passwordLengthTitle.Location = new System.Drawing.Point(23, 48);
            this.passwordLengthTitle.Name = "passwordLengthTitle";
            this.passwordLengthTitle.Size = new System.Drawing.Size(25, 12);
            this.passwordLengthTitle.TabIndex = 3;
            this.passwordLengthTitle.Text = "長さ";
            // 
            // savePath
            // 
            this.savePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savePath.Location = new System.Drawing.Point(71, 540);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(342, 19);
            this.savePath.TabIndex = 540;
            this.savePath.Text = "C:\\";
            this.savePath.TextChanged += new System.EventHandler(this.savePath_TextChanged);
            // 
            // savePathTitle
            // 
            this.savePathTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.savePathTitle.AutoSize = true;
            this.savePathTitle.Location = new System.Drawing.Point(22, 543);
            this.savePathTitle.Name = "savePathTitle";
            this.savePathTitle.Size = new System.Drawing.Size(41, 12);
            this.savePathTitle.TabIndex = 3;
            this.savePathTitle.Text = "保存先";
            // 
            // selectSavePath
            // 
            this.selectSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSavePath.Location = new System.Drawing.Point(419, 538);
            this.selectSavePath.Name = "selectSavePath";
            this.selectSavePath.Size = new System.Drawing.Size(24, 23);
            this.selectSavePath.TabIndex = 550;
            this.selectSavePath.Text = "...";
            this.selectSavePath.UseVisualStyleBackColor = true;
            this.selectSavePath.Click += new System.EventHandler(this.selectSavePath_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(449, 538);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 560;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            this.save.MouseLeave += new System.EventHandler(this.save_MouseLeave);
            // 
            // copy
            // 
            this.copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copy.Enabled = false;
            this.copy.Location = new System.Drawing.Point(395, 404);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(125, 23);
            this.copy.TabIndex = 510;
            this.copy.Text = "クリップボードにコピー";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            this.copy.MouseLeave += new System.EventHandler(this.copy_MouseLeave);
            // 
            // guidCountTitle
            // 
            this.guidCountTitle.AutoSize = true;
            this.guidCountTitle.Location = new System.Drawing.Point(23, 23);
            this.guidCountTitle.Name = "guidCountTitle";
            this.guidCountTitle.Size = new System.Drawing.Size(41, 12);
            this.guidCountTitle.TabIndex = 3;
            this.guidCountTitle.Text = "生成数";
            // 
            // guidCount
            // 
            this.guidCount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.guidCount.Location = new System.Drawing.Point(72, 20);
            this.guidCount.MaxLength = 5;
            this.guidCount.Name = "guidCount";
            this.guidCount.Size = new System.Drawing.Size(43, 19);
            this.guidCount.TabIndex = 10;
            this.guidCount.Text = "100";
            this.guidCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guidCountUnit
            // 
            this.guidCountUnit.AutoSize = true;
            this.guidCountUnit.Location = new System.Drawing.Point(121, 23);
            this.guidCountUnit.Name = "guidCountUnit";
            this.guidCountUnit.Size = new System.Drawing.Size(17, 12);
            this.guidCountUnit.TabIndex = 3;
            this.guidCountUnit.Text = "個";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 1000;
            this.toolTip.InitialDelay = 1;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // tabContents
            // 
            this.tabContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContents.Controls.Add(this.tabPassword);
            this.tabContents.Controls.Add(this.tabGuid);
            this.tabContents.Controls.Add(this.tabStringHash);
            this.tabContents.Controls.Add(this.tabStringBase64);
            this.tabContents.Controls.Add(this.tabFileHash);
            this.tabContents.Controls.Add(this.tabFileBase64);
            this.tabContents.Controls.Add(this.tabUrlEncode);
            this.tabContents.Controls.Add(this.tabCommonParts);
            this.tabContents.Location = new System.Drawing.Point(24, 32);
            this.tabContents.Name = "tabContents";
            this.tabContents.SelectedIndex = 0;
            this.tabContents.Size = new System.Drawing.Size(500, 352);
            this.tabContents.TabIndex = 1;
            this.tabContents.SelectedIndexChanged += new System.EventHandler(this.tabContents_SelectedIndexChanged);
            // 
            // tabPassword
            // 
            this.tabPassword.Controls.Add(this.passwordCountTitle);
            this.tabPassword.Controls.Add(this.passwordCount);
            this.tabPassword.Controls.Add(this.passwordLengthUnit);
            this.tabPassword.Controls.Add(this.passwordLength);
            this.tabPassword.Controls.Add(this.passwordLengthTitle);
            this.tabPassword.Controls.Add(this.passwordCountUnit);
            this.tabPassword.Location = new System.Drawing.Point(4, 22);
            this.tabPassword.Name = "tabPassword";
            this.tabPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPassword.Size = new System.Drawing.Size(492, 326);
            this.tabPassword.TabIndex = 0;
            this.tabPassword.Text = "パスワード";
            this.tabPassword.UseVisualStyleBackColor = true;
            // 
            // tabGuid
            // 
            this.tabGuid.Controls.Add(this.guidCountTitle);
            this.tabGuid.Controls.Add(this.guidCount);
            this.tabGuid.Controls.Add(this.guidCountUnit);
            this.tabGuid.Location = new System.Drawing.Point(4, 22);
            this.tabGuid.Name = "tabGuid";
            this.tabGuid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuid.Size = new System.Drawing.Size(492, 326);
            this.tabGuid.TabIndex = 1;
            this.tabGuid.Text = "Guid";
            this.tabGuid.UseVisualStyleBackColor = true;
            // 
            // tabStringHash
            // 
            this.tabStringHash.Controls.Add(this.hashEncoding);
            this.tabStringHash.Controls.Add(this.hashAlgorithm);
            this.tabStringHash.Controls.Add(this.hashOutputFormat);
            this.tabStringHash.Controls.Add(this.label11);
            this.tabStringHash.Controls.Add(this.label12);
            this.tabStringHash.Controls.Add(this.label13);
            this.tabStringHash.Controls.Add(this.hashHashText);
            this.tabStringHash.Controls.Add(this.hashPlainText);
            this.tabStringHash.Location = new System.Drawing.Point(4, 22);
            this.tabStringHash.Name = "tabStringHash";
            this.tabStringHash.Size = new System.Drawing.Size(492, 326);
            this.tabStringHash.TabIndex = 6;
            this.tabStringHash.Text = "文字列ハッシュ";
            this.tabStringHash.UseVisualStyleBackColor = true;
            // 
            // hashEncoding
            // 
            this.hashEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hashEncoding.AutoSize = true;
            this.hashEncoding.Location = new System.Drawing.Point(15, 146);
            this.hashEncoding.Name = "hashEncoding";
            this.hashEncoding.Size = new System.Drawing.Size(76, 12);
            this.hashEncoding.TabIndex = 540;
            this.hashEncoding.Text = "エンコーディング";
            this.hashEncoding.Visible = false;
            // 
            // hashAlgorithm
            // 
            this.hashAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hashAlgorithm.AutoSize = true;
            this.hashAlgorithm.Location = new System.Drawing.Point(15, 266);
            this.hashAlgorithm.Name = "hashAlgorithm";
            this.hashAlgorithm.Size = new System.Drawing.Size(95, 12);
            this.hashAlgorithm.TabIndex = 33;
            this.hashAlgorithm.Text = "ハッシュアルゴリズム";
            this.hashAlgorithm.Visible = false;
            // 
            // hashOutputFormat
            // 
            this.hashOutputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hashOutputFormat.AutoSize = true;
            this.hashOutputFormat.Location = new System.Drawing.Point(15, 206);
            this.hashOutputFormat.Name = "hashOutputFormat";
            this.hashOutputFormat.Size = new System.Drawing.Size(88, 12);
            this.hashOutputFormat.TabIndex = 33;
            this.hashOutputFormat.Text = "ハッシュ出力形式";
            this.hashOutputFormat.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 12);
            this.label11.TabIndex = 539;
            this.label11.Text = "ハッシュテキスト";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 12);
            this.label12.TabIndex = 538;
            this.label12.Text = "プレーンテキスト";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 537;
            this.label13.Text = "⇒";
            // 
            // hashHashText
            // 
            this.hashHashText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hashHashText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hashHashText.Location = new System.Drawing.Point(277, 38);
            this.hashHashText.MaxLength = 2147483647;
            this.hashHashText.Multiline = true;
            this.hashHashText.Name = "hashHashText";
            this.hashHashText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hashHashText.Size = new System.Drawing.Size(194, 89);
            this.hashHashText.TabIndex = 536;
            // 
            // hashPlainText
            // 
            this.hashPlainText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hashPlainText.Location = new System.Drawing.Point(21, 38);
            this.hashPlainText.MaxLength = 2147483647;
            this.hashPlainText.Multiline = true;
            this.hashPlainText.Name = "hashPlainText";
            this.hashPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hashPlainText.Size = new System.Drawing.Size(194, 89);
            this.hashPlainText.TabIndex = 535;
            this.hashPlainText.TextChanged += new System.EventHandler(this.hashPlainText_TextChanged);
            // 
            // tabStringBase64
            // 
            this.tabStringBase64.Controls.Add(this.label3);
            this.tabStringBase64.Controls.Add(this.label2);
            this.tabStringBase64.Controls.Add(this.label1);
            this.tabStringBase64.Controls.Add(this.base64Base64Text);
            this.tabStringBase64.Controls.Add(this.base64PlainText);
            this.tabStringBase64.Controls.Add(this.base64Encording);
            this.tabStringBase64.Location = new System.Drawing.Point(4, 22);
            this.tabStringBase64.Name = "tabStringBase64";
            this.tabStringBase64.Size = new System.Drawing.Size(492, 326);
            this.tabStringBase64.TabIndex = 5;
            this.tabStringBase64.Text = "文字列Base64";
            this.tabStringBase64.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 12);
            this.label3.TabIndex = 534;
            this.label3.Text = "Base64テキスト";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 533;
            this.label2.Text = "プレーンテキスト";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 532;
            this.label1.Text = "⇔";
            // 
            // base64Base64Text
            // 
            this.base64Base64Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.base64Base64Text.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.base64Base64Text.Location = new System.Drawing.Point(277, 38);
            this.base64Base64Text.MaxLength = 2147483647;
            this.base64Base64Text.Multiline = true;
            this.base64Base64Text.Name = "base64Base64Text";
            this.base64Base64Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.base64Base64Text.Size = new System.Drawing.Size(194, 205);
            this.base64Base64Text.TabIndex = 20;
            this.base64Base64Text.TextChanged += new System.EventHandler(this.base64Base64Text_TextChanged);
            // 
            // base64PlainText
            // 
            this.base64PlainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.base64PlainText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.base64PlainText.Location = new System.Drawing.Point(21, 38);
            this.base64PlainText.MaxLength = 2147483647;
            this.base64PlainText.Multiline = true;
            this.base64PlainText.Name = "base64PlainText";
            this.base64PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.base64PlainText.Size = new System.Drawing.Size(194, 205);
            this.base64PlainText.TabIndex = 10;
            this.base64PlainText.TextChanged += new System.EventHandler(this.base64PlainText_TextChanged);
            // 
            // base64Encording
            // 
            this.base64Encording.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.base64Encording.AutoSize = true;
            this.base64Encording.Location = new System.Drawing.Point(15, 266);
            this.base64Encording.Name = "base64Encording";
            this.base64Encording.Size = new System.Drawing.Size(76, 12);
            this.base64Encording.TabIndex = 533;
            this.base64Encording.Text = "エンコーディング";
            this.base64Encording.Visible = false;
            // 
            // tabFileHash
            // 
            this.tabFileHash.Controls.Add(this.fileHashAlgorithm);
            this.tabFileHash.Controls.Add(this.fileHashOutputFormat);
            this.tabFileHash.Controls.Add(this.fileHashFilePath);
            this.tabFileHash.Controls.Add(this.label15);
            this.tabFileHash.Controls.Add(this.fileHashOpenDialog);
            this.tabFileHash.Location = new System.Drawing.Point(4, 22);
            this.tabFileHash.Name = "tabFileHash";
            this.tabFileHash.Size = new System.Drawing.Size(492, 326);
            this.tabFileHash.TabIndex = 2;
            this.tabFileHash.Text = "ファイルハッシュ";
            this.tabFileHash.UseVisualStyleBackColor = true;
            // 
            // fileHashAlgorithm
            // 
            this.fileHashAlgorithm.AutoSize = true;
            this.fileHashAlgorithm.Location = new System.Drawing.Point(15, 112);
            this.fileHashAlgorithm.Name = "fileHashAlgorithm";
            this.fileHashAlgorithm.Size = new System.Drawing.Size(95, 12);
            this.fileHashAlgorithm.TabIndex = 227;
            this.fileHashAlgorithm.Text = "ハッシュアルゴリズム";
            this.fileHashAlgorithm.Visible = false;
            // 
            // fileHashOutputFormat
            // 
            this.fileHashOutputFormat.AutoSize = true;
            this.fileHashOutputFormat.Location = new System.Drawing.Point(15, 52);
            this.fileHashOutputFormat.Name = "fileHashOutputFormat";
            this.fileHashOutputFormat.Size = new System.Drawing.Size(88, 12);
            this.fileHashOutputFormat.TabIndex = 228;
            this.fileHashOutputFormat.Text = "ハッシュ出力形式";
            this.fileHashOutputFormat.Visible = false;
            // 
            // fileHashFilePath
            // 
            this.fileHashFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileHashFilePath.Location = new System.Drawing.Point(87, 20);
            this.fileHashFilePath.Name = "fileHashFilePath";
            this.fileHashFilePath.Size = new System.Drawing.Size(360, 19);
            this.fileHashFilePath.TabIndex = 10;
            this.fileHashFilePath.Text = "C:\\";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 12);
            this.label15.TabIndex = 226;
            this.label15.Text = "ファイルパス";
            // 
            // fileHashOpenDialog
            // 
            this.fileHashOpenDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileHashOpenDialog.Location = new System.Drawing.Point(453, 18);
            this.fileHashOpenDialog.Name = "fileHashOpenDialog";
            this.fileHashOpenDialog.Size = new System.Drawing.Size(24, 23);
            this.fileHashOpenDialog.TabIndex = 20;
            this.fileHashOpenDialog.Text = "...";
            this.fileHashOpenDialog.UseVisualStyleBackColor = true;
            this.fileHashOpenDialog.Click += new System.EventHandler(this.fileHashOpenDialog_Click);
            // 
            // tabFileBase64
            // 
            this.tabFileBase64.Controls.Add(this.groupBox1);
            this.tabFileBase64.Controls.Add(this.label8);
            this.tabFileBase64.Controls.Add(this.label10);
            this.tabFileBase64.Controls.Add(this.label9);
            this.tabFileBase64.Controls.Add(this.label7);
            this.tabFileBase64.Controls.Add(this.label6);
            this.tabFileBase64.Controls.Add(this.base64OpenDialog);
            this.tabFileBase64.Controls.Add(this.fileBase64FilePath);
            this.tabFileBase64.Location = new System.Drawing.Point(4, 22);
            this.tabFileBase64.Name = "tabFileBase64";
            this.tabFileBase64.Size = new System.Drawing.Size(492, 326);
            this.tabFileBase64.TabIndex = 3;
            this.tabFileBase64.Text = "ファイルBase64";
            this.tabFileBase64.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fileBase64Decode);
            this.groupBox1.Controls.Add(this.fileBase64Encode);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 51);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "変換方法";
            // 
            // fileBase64Decode
            // 
            this.fileBase64Decode.AutoSize = true;
            this.fileBase64Decode.Location = new System.Drawing.Point(123, 21);
            this.fileBase64Decode.Name = "fileBase64Decode";
            this.fileBase64Decode.Size = new System.Drawing.Size(98, 16);
            this.fileBase64Decode.TabIndex = 32;
            this.fileBase64Decode.Text = "Base64デコード";
            this.fileBase64Decode.UseVisualStyleBackColor = true;
            // 
            // fileBase64Encode
            // 
            this.fileBase64Encode.AutoSize = true;
            this.fileBase64Encode.Checked = true;
            this.fileBase64Encode.Location = new System.Drawing.Point(11, 21);
            this.fileBase64Encode.Name = "fileBase64Encode";
            this.fileBase64Encode.Size = new System.Drawing.Size(106, 16);
            this.fileBase64Encode.TabIndex = 31;
            this.fileBase64Encode.TabStop = true;
            this.fileBase64Encode.Text = "Base64エンコード";
            this.fileBase64Encode.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 12);
            this.label8.TabIndex = 229;
            this.label8.Text = "自動的に 『ファイルの保存』 ダイアログが開きます。";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(425, 12);
            this.label10.TabIndex = 229;
            this.label10.Text = "Base64デコードすることにより、保存したテキストデータをバイナリファイルに再変換できます。";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(362, 12);
            this.label9.TabIndex = 229;
            this.label9.Text = "Base64エンコードすると、バイナリファイルをテキストデータとして保存できます。";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(413, 12);
            this.label7.TabIndex = 229;
            this.label7.Text = "エンコード、またはデコードを行うと、結果ペインにBase64文字列が表示されると同時に、";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 229;
            this.label6.Text = "ファイルパス";
            // 
            // base64OpenDialog
            // 
            this.base64OpenDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.base64OpenDialog.Location = new System.Drawing.Point(424, 18);
            this.base64OpenDialog.Name = "base64OpenDialog";
            this.base64OpenDialog.Size = new System.Drawing.Size(24, 23);
            this.base64OpenDialog.TabIndex = 20;
            this.base64OpenDialog.Text = "...";
            this.base64OpenDialog.UseVisualStyleBackColor = true;
            this.base64OpenDialog.Click += new System.EventHandler(this.fileBase64OpenDialog_Click);
            // 
            // fileBase64FilePath
            // 
            this.fileBase64FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBase64FilePath.Location = new System.Drawing.Point(87, 20);
            this.fileBase64FilePath.Name = "fileBase64FilePath";
            this.fileBase64FilePath.Size = new System.Drawing.Size(331, 19);
            this.fileBase64FilePath.TabIndex = 10;
            this.fileBase64FilePath.Text = "C:\\";
            // 
            // tabUrlEncode
            // 
            this.tabUrlEncode.Controls.Add(this.label4);
            this.tabUrlEncode.Controls.Add(this.label14);
            this.tabUrlEncode.Controls.Add(this.label16);
            this.tabUrlEncode.Controls.Add(this.uriEscapeEncodedText);
            this.tabUrlEncode.Controls.Add(this.uriEscapePlainText);
            this.tabUrlEncode.Controls.Add(this.uriEscapeRFC3986);
            this.tabUrlEncode.Location = new System.Drawing.Point(4, 22);
            this.tabUrlEncode.Name = "tabUrlEncode";
            this.tabUrlEncode.Size = new System.Drawing.Size(492, 326);
            this.tabUrlEncode.TabIndex = 4;
            this.tabUrlEncode.Text = "URLエンコード";
            this.tabUrlEncode.UseVisualStyleBackColor = true;
            // 
            // tabCommonParts
            // 
            this.tabCommonParts.Controls.Add(this.groupEncoding);
            this.tabCommonParts.Controls.Add(this.groupOutputFormat);
            this.tabCommonParts.Controls.Add(this.groupAlgorithm);
            this.tabCommonParts.Location = new System.Drawing.Point(4, 22);
            this.tabCommonParts.Name = "tabCommonParts";
            this.tabCommonParts.Size = new System.Drawing.Size(492, 326);
            this.tabCommonParts.TabIndex = 7;
            this.tabCommonParts.Text = "共通部品";
            this.tabCommonParts.UseVisualStyleBackColor = true;
            // 
            // groupEncoding
            // 
            this.groupEncoding.Controls.Add(this.base64Help);
            this.groupEncoding.Controls.Add(this.encodingText);
            this.groupEncoding.Controls.Add(this.label5);
            this.groupEncoding.Location = new System.Drawing.Point(18, 133);
            this.groupEncoding.Name = "groupEncoding";
            this.groupEncoding.Size = new System.Drawing.Size(462, 51);
            this.groupEncoding.TabIndex = 43;
            this.groupEncoding.TabStop = false;
            this.groupEncoding.Text = "エンコーディング";
            // 
            // base64Help
            // 
            this.base64Help.AutoSize = true;
            this.base64Help.Location = new System.Drawing.Point(145, 23);
            this.base64Help.Name = "base64Help";
            this.base64Help.Size = new System.Drawing.Size(62, 12);
            this.base64Help.TabIndex = 565;
            this.base64Help.TabStop = true;
            this.base64Help.Text = "コードページ";
            // 
            // encodingText
            // 
            this.encodingText.FormattingEnabled = true;
            this.encodingText.Location = new System.Drawing.Point(20, 19);
            this.encodingText.Name = "encodingText";
            this.encodingText.Size = new System.Drawing.Size(110, 20);
            this.encodingText.TabIndex = 563;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 12);
            this.label5.TabIndex = 564;
            this.label5.Text = "（                を指定する。省略値はUTF-8）";
            // 
            // groupOutputFormat
            // 
            this.groupOutputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOutputFormat.Controls.Add(this.hashOutputFormatBase64);
            this.groupOutputFormat.Controls.Add(this.hashOutputFormatHex);
            this.groupOutputFormat.Location = new System.Drawing.Point(18, 19);
            this.groupOutputFormat.Name = "groupOutputFormat";
            this.groupOutputFormat.Size = new System.Drawing.Size(462, 51);
            this.groupOutputFormat.TabIndex = 41;
            this.groupOutputFormat.TabStop = false;
            this.groupOutputFormat.Text = "出力形式";
            // 
            // hashOutputFormatBase64
            // 
            this.hashOutputFormatBase64.AutoSize = true;
            this.hashOutputFormatBase64.Location = new System.Drawing.Point(90, 21);
            this.hashOutputFormatBase64.Name = "hashOutputFormatBase64";
            this.hashOutputFormatBase64.Size = new System.Drawing.Size(61, 16);
            this.hashOutputFormatBase64.TabIndex = 32;
            this.hashOutputFormatBase64.Text = "Base64";
            this.hashOutputFormatBase64.UseVisualStyleBackColor = true;
            // 
            // hashOutputFormatHex
            // 
            this.hashOutputFormatHex.AutoSize = true;
            this.hashOutputFormatHex.Checked = true;
            this.hashOutputFormatHex.Location = new System.Drawing.Point(20, 21);
            this.hashOutputFormatHex.Name = "hashOutputFormatHex";
            this.hashOutputFormatHex.Size = new System.Drawing.Size(59, 16);
            this.hashOutputFormatHex.TabIndex = 31;
            this.hashOutputFormatHex.TabStop = true;
            this.hashOutputFormatHex.Text = "16進数";
            this.hashOutputFormatHex.UseVisualStyleBackColor = true;
            // 
            // groupAlgorithm
            // 
            this.groupAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAlgorithm.Controls.Add(this.hashAlgoSHA512);
            this.groupAlgorithm.Controls.Add(this.hashAlgoSHA384);
            this.groupAlgorithm.Controls.Add(this.hashAlgoSHA256);
            this.groupAlgorithm.Controls.Add(this.hashAlgoSHA1);
            this.groupAlgorithm.Controls.Add(this.hashAlgoMD5);
            this.groupAlgorithm.Location = new System.Drawing.Point(18, 76);
            this.groupAlgorithm.Name = "groupAlgorithm";
            this.groupAlgorithm.Size = new System.Drawing.Size(462, 51);
            this.groupAlgorithm.TabIndex = 42;
            this.groupAlgorithm.TabStop = false;
            this.groupAlgorithm.Text = "ハッシュアルゴリズム";
            // 
            // hashAlgoSHA512
            // 
            this.hashAlgoSHA512.AutoSize = true;
            this.hashAlgoSHA512.Location = new System.Drawing.Point(300, 21);
            this.hashAlgoSHA512.Name = "hashAlgoSHA512";
            this.hashAlgoSHA512.Size = new System.Drawing.Size(64, 16);
            this.hashAlgoSHA512.TabIndex = 45;
            this.hashAlgoSHA512.Text = "SHA512";
            this.hashAlgoSHA512.UseVisualStyleBackColor = true;
            // 
            // hashAlgoSHA384
            // 
            this.hashAlgoSHA384.AutoSize = true;
            this.hashAlgoSHA384.Location = new System.Drawing.Point(230, 21);
            this.hashAlgoSHA384.Name = "hashAlgoSHA384";
            this.hashAlgoSHA384.Size = new System.Drawing.Size(64, 16);
            this.hashAlgoSHA384.TabIndex = 44;
            this.hashAlgoSHA384.Text = "SHA384";
            this.hashAlgoSHA384.UseVisualStyleBackColor = true;
            // 
            // hashAlgoSHA256
            // 
            this.hashAlgoSHA256.AutoSize = true;
            this.hashAlgoSHA256.Checked = true;
            this.hashAlgoSHA256.Location = new System.Drawing.Point(160, 21);
            this.hashAlgoSHA256.Name = "hashAlgoSHA256";
            this.hashAlgoSHA256.Size = new System.Drawing.Size(64, 16);
            this.hashAlgoSHA256.TabIndex = 43;
            this.hashAlgoSHA256.TabStop = true;
            this.hashAlgoSHA256.Text = "SHA256";
            this.hashAlgoSHA256.UseVisualStyleBackColor = true;
            // 
            // hashAlgoSHA1
            // 
            this.hashAlgoSHA1.AutoSize = true;
            this.hashAlgoSHA1.Location = new System.Drawing.Point(90, 21);
            this.hashAlgoSHA1.Name = "hashAlgoSHA1";
            this.hashAlgoSHA1.Size = new System.Drawing.Size(52, 16);
            this.hashAlgoSHA1.TabIndex = 42;
            this.hashAlgoSHA1.Text = "SHA1";
            this.hashAlgoSHA1.UseVisualStyleBackColor = true;
            // 
            // hashAlgoMD5
            // 
            this.hashAlgoMD5.AutoSize = true;
            this.hashAlgoMD5.Location = new System.Drawing.Point(20, 21);
            this.hashAlgoMD5.Name = "hashAlgoMD5";
            this.hashAlgoMD5.Size = new System.Drawing.Size(46, 16);
            this.hashAlgoMD5.TabIndex = 41;
            this.hashAlgoMD5.Text = "MD5";
            this.hashAlgoMD5.UseVisualStyleBackColor = true;
            // 
            // uriEscapeRFC3986
            // 
            this.uriEscapeRFC3986.AutoSize = true;
            this.uriEscapeRFC3986.Checked = true;
            this.uriEscapeRFC3986.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uriEscapeRFC3986.Location = new System.Drawing.Point(21, 252);
            this.uriEscapeRFC3986.Name = "uriEscapeRFC3986";
            this.uriEscapeRFC3986.Size = new System.Drawing.Size(216, 16);
            this.uriEscapeRFC3986.TabIndex = 0;
            this.uriEscapeRFC3986.Text = "RFC3986に基づいたURLエンコードを行う";
            this.uriEscapeRFC3986.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 12);
            this.label4.TabIndex = 539;
            this.label4.Text = "エンコード後テキスト";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 12);
            this.label14.TabIndex = 538;
            this.label14.Text = "プレーンテキスト";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(236, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 537;
            this.label16.Text = "⇔";
            // 
            // uriEscapeEncodedText
            // 
            this.uriEscapeEncodedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uriEscapeEncodedText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uriEscapeEncodedText.Location = new System.Drawing.Point(277, 38);
            this.uriEscapeEncodedText.MaxLength = 2147483647;
            this.uriEscapeEncodedText.Multiline = true;
            this.uriEscapeEncodedText.Name = "uriEscapeEncodedText";
            this.uriEscapeEncodedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uriEscapeEncodedText.Size = new System.Drawing.Size(194, 205);
            this.uriEscapeEncodedText.TabIndex = 536;
            this.uriEscapeEncodedText.TextChanged += new System.EventHandler(this.uriEscapeEncodedText_TextChanged);
            // 
            // uriEscapePlainText
            // 
            this.uriEscapePlainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uriEscapePlainText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uriEscapePlainText.Location = new System.Drawing.Point(21, 38);
            this.uriEscapePlainText.MaxLength = 2147483647;
            this.uriEscapePlainText.Multiline = true;
            this.uriEscapePlainText.Name = "uriEscapePlainText";
            this.uriEscapePlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uriEscapePlainText.Size = new System.Drawing.Size(194, 205);
            this.uriEscapePlainText.TabIndex = 535;
            this.uriEscapePlainText.TextChanged += new System.EventHandler(this.uriEscapePlainText_TextChanged);
            // 
            // FormMain
            // 
            this.AcceptButton = this.exec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 581);
            this.Controls.Add(this.tabContents);
            this.Controls.Add(this.savePathTitle);
            this.Controls.Add(this.savePath);
            this.Controls.Add(this.result);
            this.Controls.Add(this.selectSavePath);
            this.Controls.Add(this.save);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.exec);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "文字列生成ツール";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabContents.ResumeLayout(false);
            this.tabPassword.ResumeLayout(false);
            this.tabPassword.PerformLayout();
            this.tabGuid.ResumeLayout(false);
            this.tabGuid.PerformLayout();
            this.tabStringHash.ResumeLayout(false);
            this.tabStringHash.PerformLayout();
            this.tabStringBase64.ResumeLayout(false);
            this.tabStringBase64.PerformLayout();
            this.tabFileHash.ResumeLayout(false);
            this.tabFileHash.PerformLayout();
            this.tabFileBase64.ResumeLayout(false);
            this.tabFileBase64.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabUrlEncode.ResumeLayout(false);
            this.tabUrlEncode.PerformLayout();
            this.tabCommonParts.ResumeLayout(false);
            this.groupEncoding.ResumeLayout(false);
            this.groupEncoding.PerformLayout();
            this.groupOutputFormat.ResumeLayout(false);
            this.groupOutputFormat.PerformLayout();
            this.groupAlgorithm.ResumeLayout(false);
            this.groupAlgorithm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpVersion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHelp;
        private System.Windows.Forms.Button exec;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox passwordCount;
        private System.Windows.Forms.TextBox passwordLength;
        private System.Windows.Forms.Label passwordCountUnit;
        private System.Windows.Forms.Label passwordLengthUnit;
        private System.Windows.Forms.Label passwordCountTitle;
        private System.Windows.Forms.Label passwordLengthTitle;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.Label savePathTitle;
        private System.Windows.Forms.Button selectSavePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Label guidCountTitle;
        private System.Windows.Forms.TextBox guidCount;
        private System.Windows.Forms.Label guidCountUnit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabContents;
        private System.Windows.Forms.TabPage tabPassword;
        private System.Windows.Forms.TabPage tabGuid;
        private System.Windows.Forms.TabPage tabFileHash;
        private System.Windows.Forms.Button fileHashOpenDialog;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabFileBase64;
        private System.Windows.Forms.TabPage tabUrlEncode;
        private System.Windows.Forms.Button base64OpenDialog;
        private System.Windows.Forms.TextBox fileBase64FilePath;
        private System.Windows.Forms.TabPage tabStringBase64;
        private System.Windows.Forms.TextBox base64Base64Text;
        private System.Windows.Forms.TextBox base64PlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fileBase64Decode;
        private System.Windows.Forms.RadioButton fileBase64Encode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileHashFilePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabStringHash;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox hashHashText;
        private System.Windows.Forms.TextBox hashPlainText;
        private System.Windows.Forms.Label hashAlgorithm;
        private System.Windows.Forms.Label hashOutputFormat;
        private System.Windows.Forms.Label fileHashAlgorithm;
        private System.Windows.Forms.Label fileHashOutputFormat;
        private System.Windows.Forms.TabPage tabCommonParts;
        private System.Windows.Forms.GroupBox groupOutputFormat;
        private System.Windows.Forms.RadioButton hashOutputFormatBase64;
        private System.Windows.Forms.RadioButton hashOutputFormatHex;
        private System.Windows.Forms.GroupBox groupAlgorithm;
        private System.Windows.Forms.RadioButton hashAlgoSHA512;
        private System.Windows.Forms.RadioButton hashAlgoSHA384;
        private System.Windows.Forms.RadioButton hashAlgoSHA256;
        private System.Windows.Forms.RadioButton hashAlgoSHA1;
        private System.Windows.Forms.RadioButton hashAlgoMD5;
        private System.Windows.Forms.Label base64Encording;
        private System.Windows.Forms.GroupBox groupEncoding;
        private System.Windows.Forms.LinkLabel base64Help;
        private System.Windows.Forms.ComboBox encodingText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hashEncoding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox uriEscapeEncodedText;
        private System.Windows.Forms.TextBox uriEscapePlainText;
        private System.Windows.Forms.CheckBox uriEscapeRFC3986;
    }
}

