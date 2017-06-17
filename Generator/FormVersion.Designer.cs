namespace Generater
{
    partial class FormVersion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVersion));
            this.versionTitle = new System.Windows.Forms.Label();
            this.versionValue = new System.Windows.Forms.Label();
            this.devTitle = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.companyLogo = new System.Windows.Forms.PictureBox();
            this.orera = new System.Windows.Forms.Label();
            this.telTitle = new System.Windows.Forms.Label();
            this.privacyMarkNumber = new System.Windows.Forms.Label();
            this.dispatchTitle = new System.Windows.Forms.Label();
            this.privacyMark = new System.Windows.Forms.PictureBox();
            this.tel = new System.Windows.Forms.Label();
            this.dispatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privacyMark)).BeginInit();
            this.SuspendLayout();
            // 
            // versionTitle
            // 
            this.versionTitle.AutoSize = true;
            this.versionTitle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.versionTitle.Location = new System.Drawing.Point(217, 35);
            this.versionTitle.Name = "versionTitle";
            this.versionTitle.Size = new System.Drawing.Size(44, 12);
            this.versionTitle.TabIndex = 0;
            this.versionTitle.Text = "Version";
            // 
            // versionValue
            // 
            this.versionValue.AutoSize = true;
            this.versionValue.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.versionValue.Location = new System.Drawing.Point(267, 35);
            this.versionValue.Name = "versionValue";
            this.versionValue.Size = new System.Drawing.Size(35, 12);
            this.versionValue.TabIndex = 0;
            this.versionValue.Text = "1.0.0.0";
            // 
            // devTitle
            // 
            this.devTitle.AutoSize = true;
            this.devTitle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.devTitle.Location = new System.Drawing.Point(217, 63);
            this.devTitle.Name = "devTitle";
            this.devTitle.Size = new System.Drawing.Size(41, 12);
            this.devTitle.TabIndex = 0;
            this.devTitle.Text = "製造元";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.company.Location = new System.Drawing.Point(265, 63);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(84, 12);
            this.company.TabIndex = 0;
            this.company.Text = "株式会社フィクト";
            // 
            // companyLogo
            // 
            this.companyLogo.Image = ((System.Drawing.Image)(resources.GetObject("companyLogo.Image")));
            this.companyLogo.Location = new System.Drawing.Point(21, 24);
            this.companyLogo.Name = "companyLogo";
            this.companyLogo.Size = new System.Drawing.Size(144, 69);
            this.companyLogo.TabIndex = 1;
            this.companyLogo.TabStop = false;
            this.companyLogo.Click += new System.EventHandler(this.companyLogo_Click);
            // 
            // orera
            // 
            this.orera.AutoSize = true;
            this.orera.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orera.Location = new System.Drawing.Point(265, 81);
            this.orera.Name = "orera";
            this.orera.Size = new System.Drawing.Size(92, 12);
            this.orera.TabIndex = 0;
            this.orera.Text = "社内インフラチーム";
            // 
            // telTitle
            // 
            this.telTitle.AutoSize = true;
            this.telTitle.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.telTitle.Location = new System.Drawing.Point(19, 104);
            this.telTitle.Name = "telTitle";
            this.telTitle.Size = new System.Drawing.Size(49, 11);
            this.telTitle.TabIndex = 0;
            this.telTitle.Text = "電話番号";
            // 
            // privacyMarkNumber
            // 
            this.privacyMarkNumber.AutoSize = true;
            this.privacyMarkNumber.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.privacyMarkNumber.Location = new System.Drawing.Point(19, 224);
            this.privacyMarkNumber.Name = "privacyMarkNumber";
            this.privacyMarkNumber.Size = new System.Drawing.Size(93, 11);
            this.privacyMarkNumber.TabIndex = 0;
            this.privacyMarkNumber.Text = "第10823848(03)号";
            // 
            // dispatchTitle
            // 
            this.dispatchTitle.AutoSize = true;
            this.dispatchTitle.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.dispatchTitle.Location = new System.Drawing.Point(19, 122);
            this.dispatchTitle.Name = "dispatchTitle";
            this.dispatchTitle.Size = new System.Drawing.Size(71, 11);
            this.dispatchTitle.TabIndex = 0;
            this.dispatchTitle.Text = "派遣事業番号";
            // 
            // privacyMark
            // 
            this.privacyMark.Image = ((System.Drawing.Image)(resources.GetObject("privacyMark.Image")));
            this.privacyMark.Location = new System.Drawing.Point(21, 142);
            this.privacyMark.Name = "privacyMark";
            this.privacyMark.Size = new System.Drawing.Size(85, 79);
            this.privacyMark.TabIndex = 1;
            this.privacyMark.TabStop = false;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.tel.Location = new System.Drawing.Point(91, 104);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(83, 11);
            this.tel.TabIndex = 0;
            this.tel.Text = "：03‐6382‐6565";
            // 
            // dispatch
            // 
            this.dispatch.AutoSize = true;
            this.dispatch.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.dispatch.Location = new System.Drawing.Point(91, 122);
            this.dispatch.Name = "dispatch";
            this.dispatch.Size = new System.Drawing.Size(76, 11);
            this.dispatch.TabIndex = 0;
            this.dispatch.Text = "：特13-304556";
            // 
            // FormVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 257);
            this.Controls.Add(this.privacyMark);
            this.Controls.Add(this.companyLogo);
            this.Controls.Add(this.versionValue);
            this.Controls.Add(this.orera);
            this.Controls.Add(this.company);
            this.Controls.Add(this.dispatch);
            this.Controls.Add(this.dispatchTitle);
            this.Controls.Add(this.privacyMarkNumber);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.telTitle);
            this.Controls.Add(this.devTitle);
            this.Controls.Add(this.versionTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVersion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文字列生成ツール のバージョン情報";
            this.Shown += new System.EventHandler(this.version_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormVersion_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privacyMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionTitle;
        private System.Windows.Forms.Label versionValue;
        private System.Windows.Forms.Label devTitle;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.PictureBox companyLogo;
        private System.Windows.Forms.Label orera;
        private System.Windows.Forms.Label telTitle;
        private System.Windows.Forms.Label privacyMarkNumber;
        private System.Windows.Forms.Label dispatchTitle;
        private System.Windows.Forms.PictureBox privacyMark;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label dispatch;
    }
}