
namespace InstamRise.UserInterface
{
    partial class Licence
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lstAnnocoument = new MyListDesign.MyListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLicenceLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtLicenceKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.lstAnnocoument);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(25, 225);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1150, 293);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lstAnnocoument
            // 
            this.lstAnnocoument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAnnocoument.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstAnnocoument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.lstAnnocoument.FormattingEnabled = true;
            this.lstAnnocoument.ItemHeight = 20;
            this.lstAnnocoument.Items.AddRange(new object[] {
            "InstamRise Full sürümünü satın alarak tüm özelliklerden yararlanabilirsiniz.",
            "Çok yakında tüm özellikleriyle hizmetinizde..."});
            this.lstAnnocoument.Location = new System.Drawing.Point(15, 43);
            this.lstAnnocoument.Name = "lstAnnocoument";
            this.lstAnnocoument.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstAnnocoument.ShowScrollbar = false;
            this.lstAnnocoument.Size = new System.Drawing.Size(1119, 220);
            this.lstAnnocoument.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(528, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duyurular";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.guna2Panel1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.btnLicenceLogin);
            this.guna2Panel2.Controls.Add(this.txtLicenceKey);
            this.guna2Panel2.Location = new System.Drawing.Point(25, 18);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1150, 190);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(469, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lisans numarası giriniz :";
            // 
            // btnLicenceLogin
            // 
            this.btnLicenceLogin.Animated = true;
            this.btnLicenceLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLicenceLogin.BorderRadius = 15;
            this.btnLicenceLogin.BorderThickness = 2;
            this.btnLicenceLogin.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLicenceLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLicenceLogin.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnLicenceLogin.CheckedState.Parent = this.btnLicenceLogin;
            this.btnLicenceLogin.CustomImages.Parent = this.btnLicenceLogin;
            this.btnLicenceLogin.FillColor = System.Drawing.Color.White;
            this.btnLicenceLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLicenceLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnLicenceLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnLicenceLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnLicenceLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLicenceLogin.HoverState.Parent = this.btnLicenceLogin;
            this.btnLicenceLogin.Location = new System.Drawing.Point(500, 133);
            this.btnLicenceLogin.Name = "btnLicenceLogin";
            this.btnLicenceLogin.ShadowDecoration.Parent = this.btnLicenceLogin;
            this.btnLicenceLogin.Size = new System.Drawing.Size(150, 43);
            this.btnLicenceLogin.TabIndex = 1;
            this.btnLicenceLogin.Text = "Giriş Yap";
            this.btnLicenceLogin.Click += new System.EventHandler(this.btnLicenceLogin_Click);
            // 
            // txtLicenceKey
            // 
            this.txtLicenceKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtLicenceKey.BorderRadius = 15;
            this.txtLicenceKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenceKey.DefaultText = "_#Q4MN+8$T7@%B-RLSC?G5*G5Z!FH*BP9J_UYXS4V4L?F$=CR@";
            this.txtLicenceKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicenceKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicenceKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenceKey.DisabledState.Parent = this.txtLicenceKey;
            this.txtLicenceKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicenceKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtLicenceKey.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtLicenceKey.FocusedState.Parent = this.txtLicenceKey;
            this.txtLicenceKey.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLicenceKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtLicenceKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtLicenceKey.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtLicenceKey.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtLicenceKey.HoverState.Parent = this.txtLicenceKey;
            this.txtLicenceKey.Location = new System.Drawing.Point(50, 66);
            this.txtLicenceKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtLicenceKey.Name = "txtLicenceKey";
            this.txtLicenceKey.PasswordChar = '\0';
            this.txtLicenceKey.PlaceholderText = "Lisans numarasını giriniz...";
            this.txtLicenceKey.SelectedText = "";
            this.txtLicenceKey.SelectionStart = 50;
            this.txtLicenceKey.ShadowDecoration.Parent = this.txtLicenceKey;
            this.txtLicenceKey.Size = new System.Drawing.Size(1050, 54);
            this.txtLicenceKey.TabIndex = 0;
            this.txtLicenceKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.guna2Panel2;
            // 
            // Licence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Licence";
            this.Size = new System.Drawing.Size(1200, 534);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtLicenceKey;
        private Guna.UI2.WinForms.Guna2Button btnLicenceLogin;
        private System.Windows.Forms.Label label2;
        private MyListDesign.MyListBox lstAnnocoument;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
