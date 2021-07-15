
namespace InstamRise_Lite.UserInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLicenceControl = new Guna.UI2.WinForms.Guna2Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(128, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lisans Kodu Giriniz :";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 8;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "TEM8S2-2ET83-CGKP1-DPSI2-EPZO1";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(3, 51);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Enabled = true;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2TextBox1.Size = new System.Drawing.Size(484, 43);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // btnLicenceControl
            // 
            this.btnLicenceControl.Animated = true;
            this.btnLicenceControl.BackColor = System.Drawing.Color.Transparent;
            this.btnLicenceControl.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLicenceControl.BorderRadius = 8;
            this.btnLicenceControl.BorderThickness = 1;
            this.btnLicenceControl.CheckedState.Parent = this.btnLicenceControl;
            this.btnLicenceControl.CustomImages.Parent = this.btnLicenceControl;
            this.btnLicenceControl.FillColor = System.Drawing.Color.Teal;
            this.btnLicenceControl.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLicenceControl.ForeColor = System.Drawing.Color.Silver;
            this.btnLicenceControl.HoverState.Parent = this.btnLicenceControl;
            this.btnLicenceControl.Location = new System.Drawing.Point(150, 100);
            this.btnLicenceControl.Name = "btnLicenceControl";
            this.btnLicenceControl.ShadowDecoration.Enabled = true;
            this.btnLicenceControl.ShadowDecoration.Parent = this.btnLicenceControl;
            this.btnLicenceControl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLicenceControl.Size = new System.Drawing.Size(180, 45);
            this.btnLicenceControl.TabIndex = 3;
            this.btnLicenceControl.Text = "Giriş Yap";
            this.btnLicenceControl.Click += new System.EventHandler(this.btnLicenceControl_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Silver;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Teal;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "InstamRise Full sürümünü satın alarak tüm özelliklerden yararlanabilirsiniz.",
            "Çok yakında tüm özellikleriyle hizmetinizde..."});
            this.listBox1.Location = new System.Drawing.Point(3, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(484, 482);
            this.listBox1.TabIndex = 4;
            // 
            // LicencePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLicenceControl);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label1);
            this.Name = "LicencePage";
            this.Size = new System.Drawing.Size(490, 653);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnLicenceControl;
        private System.Windows.Forms.ListBox listBox1;
    }
}
