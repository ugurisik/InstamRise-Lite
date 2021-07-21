
namespace InstamRise.UserInterface
{
    partial class LicencePage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lstAnnouncement = new System.Windows.Forms.ListBox();
            this.btnLicenceControl = new Guna.UI2.WinForms.Guna2Button();
            this.txtLicenceKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(574, 721);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lstAnnouncement);
            this.guna2Panel2.Controls.Add(this.btnLicenceControl);
            this.guna2Panel2.Controls.Add(this.txtLicenceKey);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.guna2Panel2.Location = new System.Drawing.Point(15, 15);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(544, 688);
            this.guna2Panel2.TabIndex = 0;
            // 
            // lstAnnouncement
            // 
            this.lstAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lstAnnouncement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAnnouncement.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstAnnouncement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(44)))));
            this.lstAnnouncement.FormattingEnabled = true;
            this.lstAnnouncement.ItemHeight = 18;
            this.lstAnnouncement.Items.AddRange(new object[] {
            "InstamRise Full sürümünü satın alarak tüm özelliklerden yararlanabilirsiniz.",
            "Çok yakında tüm özellikleriyle hizmetinizde..."});
            this.lstAnnouncement.Location = new System.Drawing.Point(6, 157);
            this.lstAnnouncement.Name = "lstAnnouncement";
            this.lstAnnouncement.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstAnnouncement.Size = new System.Drawing.Size(532, 468);
            this.lstAnnouncement.TabIndex = 2;
            // 
            // btnLicenceControl
            // 
            this.btnLicenceControl.Animated = true;
            this.btnLicenceControl.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLicenceControl.BorderRadius = 16;
            this.btnLicenceControl.CheckedState.Parent = this.btnLicenceControl;
            this.btnLicenceControl.CustomImages.Parent = this.btnLicenceControl;
            this.btnLicenceControl.FillColor = System.Drawing.Color.White;
            this.btnLicenceControl.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLicenceControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnLicenceControl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLicenceControl.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLicenceControl.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLicenceControl.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLicenceControl.HoverState.Parent = this.btnLicenceControl;
            this.btnLicenceControl.Location = new System.Drawing.Point(153, 94);
            this.btnLicenceControl.Name = "btnLicenceControl";
            this.btnLicenceControl.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.btnLicenceControl.ShadowDecoration.Parent = this.btnLicenceControl;
            this.btnLicenceControl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLicenceControl.Size = new System.Drawing.Size(237, 47);
            this.btnLicenceControl.TabIndex = 1;
            this.btnLicenceControl.Text = "Giriş Yap";
            this.btnLicenceControl.Click += new System.EventHandler(this.btnLicenceControl_Click);
            // 
            // txtLicenceKey
            // 
            this.txtLicenceKey.Animated = true;
            this.txtLicenceKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtLicenceKey.BorderRadius = 25;
            this.txtLicenceKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenceKey.DefaultText = "TEM8S2-2ET83-CGKP1-DPSI2-EPZO1";
            this.txtLicenceKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicenceKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicenceKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenceKey.DisabledState.Parent = this.txtLicenceKey;
            this.txtLicenceKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenceKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.txtLicenceKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenceKey.FocusedState.Parent = this.txtLicenceKey;
            this.txtLicenceKey.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLicenceKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(44)))));
            this.txtLicenceKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicenceKey.HoverState.Parent = this.txtLicenceKey;
            this.txtLicenceKey.Location = new System.Drawing.Point(52, 18);
            this.txtLicenceKey.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLicenceKey.Name = "txtLicenceKey";
            this.txtLicenceKey.PasswordChar = '\0';
            this.txtLicenceKey.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(44)))));
            this.txtLicenceKey.PlaceholderText = "Lisans anahtarını giriniz...";
            this.txtLicenceKey.SelectedText = "";
            this.txtLicenceKey.SelectionStart = 30;
            this.txtLicenceKey.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(117)))), ((int)(((byte)(206)))));
            this.txtLicenceKey.ShadowDecoration.Parent = this.txtLicenceKey;
            this.txtLicenceKey.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLicenceKey.Size = new System.Drawing.Size(444, 58);
            this.txtLicenceKey.TabIndex = 0;
            this.txtLicenceKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LicencePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "LicencePage";
            this.Size = new System.Drawing.Size(574, 721);
            this.Load += new System.EventHandler(this.LicencePage_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtLicenceKey;
        private System.Windows.Forms.ListBox lstAnnouncement;
        private Guna.UI2.WinForms.Guna2Button btnLicenceControl;
    }
}
