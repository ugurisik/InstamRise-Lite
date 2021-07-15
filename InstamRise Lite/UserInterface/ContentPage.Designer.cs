
namespace InstamRise_Lite.UserInterface
{
    partial class ContentPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbDownloadType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDownload = new Guna.UI2.WinForms.Guna2Button();
            this.txtDownloadUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnUnFollow = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numberUnFollowTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbUsers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbGetListType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFollow = new Guna.UI2.WinForms.Guna2Button();
            this.btnGetList = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtListContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.numberFollowTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblGetListCount = new System.Windows.Forms.Label();
            this.cbFollowPrivateAcc = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUnFollowTime)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFollowTime)).BeginInit();
            this.SuspendLayout();
            // 
            // VScrollBar
            // 
            this.VScrollBar.BorderRadius = 8;
            this.VScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.VScrollBar.FillColor = System.Drawing.Color.Silver;
            this.VScrollBar.HighlightOnWheel = true;
            this.VScrollBar.HoverState.Parent = null;
            this.VScrollBar.LargeChange = 10;
            this.VScrollBar.Location = new System.Drawing.Point(472, 0);
            this.VScrollBar.Maximum = 500;
            this.VScrollBar.MouseWheelBarPartitions = 15;
            this.VScrollBar.Name = "VScrollBar";
            this.VScrollBar.PressedState.Parent = this.VScrollBar;
            this.VScrollBar.ScrollbarSize = 18;
            this.VScrollBar.Size = new System.Drawing.Size(18, 653);
            this.VScrollBar.TabIndex = 1;
            this.VScrollBar.ThumbColor = System.Drawing.Color.Teal;
            this.VScrollBar.ThumbSize = 20F;
            this.VScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(5, -200);
            this.panel1.Controls.Add(this.guna2GroupBox5);
            this.panel1.Controls.Add(this.guna2GroupBox4);
            this.panel1.Controls.Add(this.guna2GroupBox3);
            this.panel1.Controls.Add(this.guna2GroupBox2);
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 1250);
            this.panel1.TabIndex = 2;
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox5.BorderRadius = 15;
            this.guna2GroupBox5.Controls.Add(this.guna2Button4);
            this.guna2GroupBox5.Controls.Add(this.guna2Button3);
            this.guna2GroupBox5.Controls.Add(this.guna2DataGridView1);
            this.guna2GroupBox5.Controls.Add(this.guna2Button2);
            this.guna2GroupBox5.Controls.Add(this.guna2ComboBox1);
            this.guna2GroupBox5.Controls.Add(this.label2);
            this.guna2GroupBox5.Controls.Add(this.label1);
            this.guna2GroupBox5.Controls.Add(this.guna2DateTimePicker1);
            this.guna2GroupBox5.Controls.Add(this.guna2Button1);
            this.guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox5.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2GroupBox5.Location = new System.Drawing.Point(4, 838);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.ShadowDecoration.Parent = this.guna2GroupBox5;
            this.guna2GroupBox5.Size = new System.Drawing.Size(457, 409);
            this.guna2GroupBox5.TabIndex = 14;
            this.guna2GroupBox5.Text = "Gönderi Paylaşma İşlemleri";
            this.guna2GroupBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox5.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderRadius = 8;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.Teal;
            this.guna2Button4.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(229, 165);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(200, 36);
            this.guna2Button4.TabIndex = 18;
            this.guna2Button4.Text = "Paylaşımı Başlat";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Teal;
            this.guna2Button3.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(23, 165);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(200, 36);
            this.guna2Button3.TabIndex = 17;
            this.guna2Button3.Text = "Seçileni Sil";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(6, 205);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(446, 193);
            this.guna2DataGridView1.TabIndex = 16;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Teal;
            this.guna2Button2.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(229, 123);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(200, 36);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.Text = "Gönderiyi Ekle";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2ComboBox1.BorderRadius = 8;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Teal;
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(252, 79);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2ComboBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Paylaşım Saati Seçiniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Paylaşım Tarihi Seçiniz :";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.BorderRadius = 8;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Teal;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(252, 37);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker1.TabIndex = 13;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 7, 15, 15, 48, 40, 261);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Teal;
            this.guna2Button1.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(23, 123);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(200, 36);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Görsel Seç";
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox4.BorderRadius = 15;
            this.guna2GroupBox4.Controls.Add(this.cmbDownloadType);
            this.guna2GroupBox4.Controls.Add(this.btnDownload);
            this.guna2GroupBox4.Controls.Add(this.txtDownloadUsername);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox4.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2GroupBox4.Location = new System.Drawing.Point(4, 664);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.ShadowDecoration.Parent = this.guna2GroupBox4;
            this.guna2GroupBox4.Size = new System.Drawing.Size(457, 167);
            this.guna2GroupBox4.TabIndex = 13;
            this.guna2GroupBox4.Text = "Gönderi İndirme İşlemleri";
            this.guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox4.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // cmbDownloadType
            // 
            this.cmbDownloadType.BackColor = System.Drawing.Color.Transparent;
            this.cmbDownloadType.BorderColor = System.Drawing.Color.DimGray;
            this.cmbDownloadType.BorderRadius = 8;
            this.cmbDownloadType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDownloadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownloadType.FillColor = System.Drawing.Color.Silver;
            this.cmbDownloadType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDownloadType.FocusedState.Parent = this.cmbDownloadType;
            this.cmbDownloadType.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDownloadType.ForeColor = System.Drawing.Color.Teal;
            this.cmbDownloadType.FormattingEnabled = true;
            this.cmbDownloadType.HoverState.Parent = this.cmbDownloadType;
            this.cmbDownloadType.ItemHeight = 30;
            this.cmbDownloadType.Items.AddRange(new object[] {
            "Profilden İndir"});
            this.cmbDownloadType.ItemsAppearance.Parent = this.cmbDownloadType;
            this.cmbDownloadType.Location = new System.Drawing.Point(3, 38);
            this.cmbDownloadType.Name = "cmbDownloadType";
            this.cmbDownloadType.ShadowDecoration.Parent = this.cmbDownloadType;
            this.cmbDownloadType.Size = new System.Drawing.Size(451, 36);
            this.cmbDownloadType.TabIndex = 11;
            this.cmbDownloadType.SelectedIndexChanged += new System.EventHandler(this.cmbDownloadType_SelectedIndexChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Animated = true;
            this.btnDownload.BorderRadius = 8;
            this.btnDownload.CheckedState.Parent = this.btnDownload;
            this.btnDownload.CustomImages.Parent = this.btnDownload;
            this.btnDownload.FillColor = System.Drawing.Color.Teal;
            this.btnDownload.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnDownload.HoverState.Parent = this.btnDownload;
            this.btnDownload.Location = new System.Drawing.Point(3, 123);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.ShadowDecoration.Parent = this.btnDownload;
            this.btnDownload.Size = new System.Drawing.Size(449, 36);
            this.btnDownload.TabIndex = 12;
            this.btnDownload.Text = "İndirme İşlemini Başlat";
            // 
            // txtDownloadUsername
            // 
            this.txtDownloadUsername.Animated = true;
            this.txtDownloadUsername.BorderColor = System.Drawing.Color.DimGray;
            this.txtDownloadUsername.BorderRadius = 8;
            this.txtDownloadUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDownloadUsername.DefaultText = "";
            this.txtDownloadUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDownloadUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDownloadUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDownloadUsername.DisabledState.Parent = this.txtDownloadUsername;
            this.txtDownloadUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDownloadUsername.FillColor = System.Drawing.Color.Teal;
            this.txtDownloadUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDownloadUsername.FocusedState.Parent = this.txtDownloadUsername;
            this.txtDownloadUsername.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDownloadUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtDownloadUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDownloadUsername.HoverState.Parent = this.txtDownloadUsername;
            this.txtDownloadUsername.Location = new System.Drawing.Point(3, 80);
            this.txtDownloadUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDownloadUsername.Name = "txtDownloadUsername";
            this.txtDownloadUsername.PasswordChar = '\0';
            this.txtDownloadUsername.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtDownloadUsername.PlaceholderText = "";
            this.txtDownloadUsername.SelectedText = "";
            this.txtDownloadUsername.ShadowDecoration.Parent = this.txtDownloadUsername;
            this.txtDownloadUsername.Size = new System.Drawing.Size(450, 36);
            this.txtDownloadUsername.TabIndex = 13;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox3.BorderRadius = 15;
            this.guna2GroupBox3.Controls.Add(this.btnUnFollow);
            this.guna2GroupBox3.Controls.Add(this.label6);
            this.guna2GroupBox3.Controls.Add(this.numberUnFollowTime);
            this.guna2GroupBox3.Controls.Add(this.label7);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox3.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(4, 514);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(457, 144);
            this.guna2GroupBox3.TabIndex = 12;
            this.guna2GroupBox3.Text = "Takipten Çıkma İşlemleri";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox3.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // btnUnFollow
            // 
            this.btnUnFollow.Animated = true;
            this.btnUnFollow.BorderRadius = 8;
            this.btnUnFollow.CheckedState.Parent = this.btnUnFollow;
            this.btnUnFollow.CustomImages.Parent = this.btnUnFollow;
            this.btnUnFollow.FillColor = System.Drawing.Color.Teal;
            this.btnUnFollow.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnFollow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnUnFollow.HoverState.Parent = this.btnUnFollow;
            this.btnUnFollow.Location = new System.Drawing.Point(5, 80);
            this.btnUnFollow.Name = "btnUnFollow";
            this.btnUnFollow.ShadowDecoration.Parent = this.btnUnFollow;
            this.btnUnFollow.Size = new System.Drawing.Size(448, 36);
            this.btnUnFollow.TabIndex = 11;
            this.btnUnFollow.Text = "Takipten Çıkma İşlemini Başlat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(44, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "İşlem Yapılacak Süre (sn):";
            // 
            // numberUnFollowTime
            // 
            this.numberUnFollowTime.BackColor = System.Drawing.Color.Transparent;
            this.numberUnFollowTime.BorderColor = System.Drawing.Color.DimGray;
            this.numberUnFollowTime.BorderRadius = 8;
            this.numberUnFollowTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberUnFollowTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numberUnFollowTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numberUnFollowTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numberUnFollowTime.DisabledState.Parent = this.numberUnFollowTime;
            this.numberUnFollowTime.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numberUnFollowTime.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numberUnFollowTime.FillColor = System.Drawing.Color.Silver;
            this.numberUnFollowTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numberUnFollowTime.FocusedState.Parent = this.numberUnFollowTime;
            this.numberUnFollowTime.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberUnFollowTime.ForeColor = System.Drawing.Color.Teal;
            this.numberUnFollowTime.Location = new System.Drawing.Point(282, 36);
            this.numberUnFollowTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numberUnFollowTime.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numberUnFollowTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberUnFollowTime.Name = "numberUnFollowTime";
            this.numberUnFollowTime.ShadowDecoration.Parent = this.numberUnFollowTime;
            this.numberUnFollowTime.Size = new System.Drawing.Size(171, 36);
            this.numberUnFollowTime.TabIndex = 10;
            this.numberUnFollowTime.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.numberUnFollowTime.UpDownButtonForeColor = System.Drawing.Color.PaleTurquoise;
            this.numberUnFollowTime.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(4, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Çıkarılan Kullanıcı Sayısı : 0";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox2.BorderRadius = 15;
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.txtPassword);
            this.guna2GroupBox2.Controls.Add(this.cmbUsers);
            this.guna2GroupBox2.Controls.Add(this.btnLogin);
            this.guna2GroupBox2.Controls.Add(this.txtUsername);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(4, 3);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(457, 242);
            this.guna2GroupBox2.TabIndex = 12;
            this.guna2GroupBox2.Text = "Hesap İşlemleri";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(4, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kullandığınız hesapta 1 saat arayla cihaz değiştiriniz!";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.DimGray;
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.Teal;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(4, 122);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceholderText = "Şifre giriniz...";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(449, 36);
            this.txtPassword.TabIndex = 2;
            // 
            // cmbUsers
            // 
            this.cmbUsers.BackColor = System.Drawing.Color.Transparent;
            this.cmbUsers.BorderColor = System.Drawing.Color.DimGray;
            this.cmbUsers.BorderRadius = 8;
            this.cmbUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FillColor = System.Drawing.Color.Silver;
            this.cmbUsers.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUsers.FocusedState.Parent = this.cmbUsers;
            this.cmbUsers.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUsers.ForeColor = System.Drawing.Color.Teal;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.HoverState.Parent = this.cmbUsers;
            this.cmbUsers.ItemHeight = 30;
            this.cmbUsers.ItemsAppearance.Parent = this.cmbUsers;
            this.cmbUsers.Location = new System.Drawing.Point(3, 36);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.ShadowDecoration.Parent = this.cmbUsers;
            this.cmbUsers.Size = new System.Drawing.Size(451, 36);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Teal;
            this.btnLogin.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(5, 165);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(448, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BorderColor = System.Drawing.Color.DimGray;
            this.txtUsername.BorderRadius = 8;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.Teal;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(3, 78);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.PlaceholderText = "Kullanıcı adı giriniz...";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(450, 36);
            this.txtUsername.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(4, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Programı kullanırken farklı bir cihazdan giriş yapmayınız!";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.cmbGetListType);
            this.guna2GroupBox1.Controls.Add(this.btnFollow);
            this.guna2GroupBox1.Controls.Add(this.btnGetList);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txtListContent);
            this.guna2GroupBox1.Controls.Add(this.numberFollowTime);
            this.guna2GroupBox1.Controls.Add(this.lblGetListCount);
            this.guna2GroupBox1.Controls.Add(this.cbFollowPrivateAcc);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(4, 251);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(457, 257);
            this.guna2GroupBox1.TabIndex = 11;
            this.guna2GroupBox1.Text = "Takip Etme İşlemleri";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // cmbGetListType
            // 
            this.cmbGetListType.BackColor = System.Drawing.Color.Transparent;
            this.cmbGetListType.BorderColor = System.Drawing.Color.DimGray;
            this.cmbGetListType.BorderRadius = 8;
            this.cmbGetListType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGetListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGetListType.FillColor = System.Drawing.Color.Silver;
            this.cmbGetListType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGetListType.FocusedState.Parent = this.cmbGetListType;
            this.cmbGetListType.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGetListType.ForeColor = System.Drawing.Color.Teal;
            this.cmbGetListType.FormattingEnabled = true;
            this.cmbGetListType.HoverState.Parent = this.cmbGetListType;
            this.cmbGetListType.ItemHeight = 30;
            this.cmbGetListType.Items.AddRange(new object[] {
            "Takipçilerini Getir",
            "Gönderiyi Beğenenleri Getir"});
            this.cmbGetListType.ItemsAppearance.Parent = this.cmbGetListType;
            this.cmbGetListType.Location = new System.Drawing.Point(3, 36);
            this.cmbGetListType.Name = "cmbGetListType";
            this.cmbGetListType.ShadowDecoration.Parent = this.cmbGetListType;
            this.cmbGetListType.Size = new System.Drawing.Size(451, 36);
            this.cmbGetListType.TabIndex = 4;
            this.cmbGetListType.SelectedIndexChanged += new System.EventHandler(this.cmbGetListType_SelectedIndexChanged);
            // 
            // btnFollow
            // 
            this.btnFollow.Animated = true;
            this.btnFollow.BorderRadius = 8;
            this.btnFollow.CheckedState.Parent = this.btnFollow;
            this.btnFollow.CustomImages.Parent = this.btnFollow;
            this.btnFollow.FillColor = System.Drawing.Color.Teal;
            this.btnFollow.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFollow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnFollow.HoverState.Parent = this.btnFollow;
            this.btnFollow.Location = new System.Drawing.Point(6, 209);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.ShadowDecoration.Parent = this.btnFollow;
            this.btnFollow.Size = new System.Drawing.Size(448, 36);
            this.btnFollow.TabIndex = 9;
            this.btnFollow.Text = "Takip İşlemini Başlat";
            // 
            // btnGetList
            // 
            this.btnGetList.Animated = true;
            this.btnGetList.BorderRadius = 8;
            this.btnGetList.CheckedState.Parent = this.btnGetList;
            this.btnGetList.CustomImages.Parent = this.btnGetList;
            this.btnGetList.FillColor = System.Drawing.Color.Teal;
            this.btnGetList.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnGetList.HoverState.Parent = this.btnGetList;
            this.btnGetList.Location = new System.Drawing.Point(283, 78);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.ShadowDecoration.Parent = this.btnGetList;
            this.btnGetList.Size = new System.Drawing.Size(171, 36);
            this.btnGetList.TabIndex = 6;
            this.btnGetList.Text = "Getir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(45, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "İşlem Yapılacak Süre (sn):";
            // 
            // txtListContent
            // 
            this.txtListContent.Animated = true;
            this.txtListContent.BorderColor = System.Drawing.Color.DimGray;
            this.txtListContent.BorderRadius = 8;
            this.txtListContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtListContent.DefaultText = "";
            this.txtListContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtListContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtListContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListContent.DisabledState.Parent = this.txtListContent;
            this.txtListContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtListContent.FillColor = System.Drawing.Color.Teal;
            this.txtListContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListContent.FocusedState.Parent = this.txtListContent;
            this.txtListContent.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtListContent.ForeColor = System.Drawing.Color.Silver;
            this.txtListContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtListContent.HoverState.Parent = this.txtListContent;
            this.txtListContent.Location = new System.Drawing.Point(3, 78);
            this.txtListContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtListContent.Name = "txtListContent";
            this.txtListContent.PasswordChar = '\0';
            this.txtListContent.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtListContent.PlaceholderText = "";
            this.txtListContent.SelectedText = "";
            this.txtListContent.ShadowDecoration.Parent = this.txtListContent;
            this.txtListContent.Size = new System.Drawing.Size(273, 36);
            this.txtListContent.TabIndex = 5;
            // 
            // numberFollowTime
            // 
            this.numberFollowTime.BackColor = System.Drawing.Color.Transparent;
            this.numberFollowTime.BorderColor = System.Drawing.Color.DimGray;
            this.numberFollowTime.BorderRadius = 8;
            this.numberFollowTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberFollowTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numberFollowTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numberFollowTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numberFollowTime.DisabledState.Parent = this.numberFollowTime;
            this.numberFollowTime.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numberFollowTime.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numberFollowTime.FillColor = System.Drawing.Color.Silver;
            this.numberFollowTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numberFollowTime.FocusedState.Parent = this.numberFollowTime;
            this.numberFollowTime.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberFollowTime.ForeColor = System.Drawing.Color.Teal;
            this.numberFollowTime.Location = new System.Drawing.Point(283, 165);
            this.numberFollowTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numberFollowTime.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numberFollowTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberFollowTime.Name = "numberFollowTime";
            this.numberFollowTime.ShadowDecoration.Parent = this.numberFollowTime;
            this.numberFollowTime.Size = new System.Drawing.Size(171, 36);
            this.numberFollowTime.TabIndex = 8;
            this.numberFollowTime.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.numberFollowTime.UpDownButtonForeColor = System.Drawing.Color.PaleTurquoise;
            this.numberFollowTime.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // lblGetListCount
            // 
            this.lblGetListCount.AutoSize = true;
            this.lblGetListCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGetListCount.ForeColor = System.Drawing.Color.Teal;
            this.lblGetListCount.Location = new System.Drawing.Point(3, 118);
            this.lblGetListCount.Name = "lblGetListCount";
            this.lblGetListCount.Size = new System.Drawing.Size(180, 16);
            this.lblGetListCount.TabIndex = 6;
            this.lblGetListCount.Text = "Çekilen yeni kullanıcı sayısı : 0";
            // 
            // cbFollowPrivateAcc
            // 
            this.cbFollowPrivateAcc.Animated = true;
            this.cbFollowPrivateAcc.AutoSize = true;
            this.cbFollowPrivateAcc.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.cbFollowPrivateAcc.CheckedState.BorderRadius = 2;
            this.cbFollowPrivateAcc.CheckedState.BorderThickness = 0;
            this.cbFollowPrivateAcc.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.cbFollowPrivateAcc.CheckMarkColor = System.Drawing.Color.Silver;
            this.cbFollowPrivateAcc.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFollowPrivateAcc.ForeColor = System.Drawing.Color.Teal;
            this.cbFollowPrivateAcc.Location = new System.Drawing.Point(6, 137);
            this.cbFollowPrivateAcc.Name = "cbFollowPrivateAcc";
            this.cbFollowPrivateAcc.Size = new System.Drawing.Size(217, 23);
            this.cbFollowPrivateAcc.TabIndex = 7;
            this.cbFollowPrivateAcc.Text = "Gizli Hesapları Takip Etme";
            this.cbFollowPrivateAcc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbFollowPrivateAcc.UncheckedState.BorderRadius = 2;
            this.cbFollowPrivateAcc.UncheckedState.BorderThickness = 0;
            this.cbFollowPrivateAcc.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbFollowPrivateAcc.UseVisualStyleBackColor = true;
            // 
            // ContentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VScrollBar);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "ContentPage";
            this.Size = new System.Drawing.Size(490, 653);
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUnFollowTime)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFollowTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2VScrollBar VScrollBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGetListCount;
        private Guna.UI2.WinForms.Guna2TextBox txtListContent;
        private Guna.UI2.WinForms.Guna2Button btnGetList;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGetListType;
        private Guna.UI2.WinForms.Guna2CheckBox cbFollowPrivateAcc;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUsers;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numberFollowTime;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button btnUnFollow;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown numberUnFollowTime;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDownloadType;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private Guna.UI2.WinForms.Guna2TextBox txtDownloadUsername;
        private Guna.UI2.WinForms.Guna2Button btnFollow;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}
