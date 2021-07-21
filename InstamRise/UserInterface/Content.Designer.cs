
namespace InstamRise.UserInterface
{
    partial class Content
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lstShowProcess = new MyListDesign.MyListBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbDownloadMediaType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDownloadMediaStart = new Guna.UI2.WinForms.Guna2Button();
            this.txtDownloadMediaContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnShareChoiseImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnShareAddData = new Guna.UI2.WinForms.Guna2Button();
            this.btnShareDeleteData = new Guna.UI2.WinForms.Guna2Button();
            this.dgvShareMedias = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareMediaPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShareStart = new Guna.UI2.WinForms.Guna2Button();
            this.dtpShareTime = new System.Windows.Forms.DateTimePicker();
            this.dtpShareDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberUnFollowTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnUnFollowStart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbFollowType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFollowStart = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numberFollowTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbFollowPrivateAcc = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtFollowContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccountUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            this.guna2GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShareMedias)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUnFollowTime)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFollowTime)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VScrollBar1
            // 
            this.VScrollBar1.BorderRadius = 6;
            this.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.VScrollBar1.HoverState.Parent = null;
            this.VScrollBar1.LargeChange = 10;
            this.VScrollBar1.Location = new System.Drawing.Point(1182, 0);
            this.VScrollBar1.Maximum = 1100;
            this.VScrollBar1.MouseWheelBarPartitions = 20;
            this.VScrollBar1.Name = "VScrollBar1";
            this.VScrollBar1.PressedState.Parent = this.VScrollBar1;
            this.VScrollBar1.ScrollbarSize = 18;
            this.VScrollBar1.Size = new System.Drawing.Size(18, 534);
            this.VScrollBar1.TabIndex = 0;
            this.VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.VScrollBar1.ThumbSize = 40F;
            this.VScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.lstShowProcess);
            this.guna2Panel1.Location = new System.Drawing.Point(683, 7);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(493, 519);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lstShowProcess
            // 
            this.lstShowProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstShowProcess.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstShowProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.lstShowProcess.FormattingEnabled = true;
            this.lstShowProcess.ItemHeight = 18;
            this.lstShowProcess.Location = new System.Drawing.Point(15, 14);
            this.lstShowProcess.Name = "lstShowProcess";
            this.lstShowProcess.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstShowProcess.ShowScrollbar = false;
            this.lstShowProcess.Size = new System.Drawing.Size(463, 468);
            this.lstShowProcess.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.guna2Panel1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.pnlContainer);
            this.guna2Panel2.Location = new System.Drawing.Point(7, 7);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(670, 519);
            this.guna2Panel2.TabIndex = 2;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderColor = System.Drawing.Color.Black;
            this.pnlContainer.Controls.Add(this.guna2GroupBox5);
            this.pnlContainer.Controls.Add(this.guna2GroupBox6);
            this.pnlContainer.Controls.Add(this.guna2GroupBox3);
            this.pnlContainer.Controls.Add(this.guna2GroupBox2);
            this.pnlContainer.Controls.Add(this.guna2GroupBox1);
            this.pnlContainer.Location = new System.Drawing.Point(14, -800);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.ShadowDecoration.Parent = this.pnlContainer;
            this.pnlContainer.Size = new System.Drawing.Size(639, 1605);
            this.pnlContainer.TabIndex = 0;
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox5.BorderRadius = 15;
            this.guna2GroupBox5.Controls.Add(this.cmbDownloadMediaType);
            this.guna2GroupBox5.Controls.Add(this.btnDownloadMediaStart);
            this.guna2GroupBox5.Controls.Add(this.txtDownloadMediaContent);
            this.guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.guna2GroupBox5.Location = new System.Drawing.Point(10, 781);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.ShadowDecoration.Parent = this.guna2GroupBox5;
            this.guna2GroupBox5.Size = new System.Drawing.Size(618, 206);
            this.guna2GroupBox5.TabIndex = 23;
            this.guna2GroupBox5.Text = "Gönderi İndirme İşlemleri";
            this.guna2GroupBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox5.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // cmbDownloadMediaType
            // 
            this.cmbDownloadMediaType.Animated = true;
            this.cmbDownloadMediaType.BackColor = System.Drawing.Color.White;
            this.cmbDownloadMediaType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbDownloadMediaType.BorderRadius = 15;
            this.cmbDownloadMediaType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDownloadMediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownloadMediaType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbDownloadMediaType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cmbDownloadMediaType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cmbDownloadMediaType.FocusedState.Parent = this.cmbDownloadMediaType;
            this.cmbDownloadMediaType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDownloadMediaType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cmbDownloadMediaType.FormattingEnabled = true;
            this.cmbDownloadMediaType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.cmbDownloadMediaType.HoverState.Parent = this.cmbDownloadMediaType;
            this.cmbDownloadMediaType.ItemHeight = 40;
            this.cmbDownloadMediaType.Items.AddRange(new object[] {
            "Profilden İndir"});
            this.cmbDownloadMediaType.ItemsAppearance.Parent = this.cmbDownloadMediaType;
            this.cmbDownloadMediaType.Location = new System.Drawing.Point(43, 42);
            this.cmbDownloadMediaType.Name = "cmbDownloadMediaType";
            this.cmbDownloadMediaType.ShadowDecoration.Parent = this.cmbDownloadMediaType;
            this.cmbDownloadMediaType.Size = new System.Drawing.Size(532, 46);
            this.cmbDownloadMediaType.TabIndex = 21;
            this.cmbDownloadMediaType.SelectedIndexChanged += new System.EventHandler(this.cmbDownloadMediaType_SelectedIndexChanged);
            // 
            // btnDownloadMediaStart
            // 
            this.btnDownloadMediaStart.Animated = true;
            this.btnDownloadMediaStart.BackColor = System.Drawing.Color.White;
            this.btnDownloadMediaStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnDownloadMediaStart.BorderRadius = 15;
            this.btnDownloadMediaStart.BorderThickness = 2;
            this.btnDownloadMediaStart.CheckedState.Parent = this.btnDownloadMediaStart;
            this.btnDownloadMediaStart.CustomImages.Parent = this.btnDownloadMediaStart;
            this.btnDownloadMediaStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnDownloadMediaStart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDownloadMediaStart.ForeColor = System.Drawing.Color.White;
            this.btnDownloadMediaStart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDownloadMediaStart.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDownloadMediaStart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDownloadMediaStart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnDownloadMediaStart.HoverState.Parent = this.btnDownloadMediaStart;
            this.btnDownloadMediaStart.Location = new System.Drawing.Point(139, 151);
            this.btnDownloadMediaStart.Name = "btnDownloadMediaStart";
            this.btnDownloadMediaStart.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.btnDownloadMediaStart.ShadowDecoration.Parent = this.btnDownloadMediaStart;
            this.btnDownloadMediaStart.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDownloadMediaStart.Size = new System.Drawing.Size(319, 47);
            this.btnDownloadMediaStart.TabIndex = 15;
            this.btnDownloadMediaStart.Text = "İndirme İşlemini Başlat";
            this.btnDownloadMediaStart.Click += new System.EventHandler(this.btnDownloadMediaStart_Click);
            // 
            // txtDownloadMediaContent
            // 
            this.txtDownloadMediaContent.Animated = true;
            this.txtDownloadMediaContent.BackColor = System.Drawing.Color.White;
            this.txtDownloadMediaContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtDownloadMediaContent.BorderRadius = 15;
            this.txtDownloadMediaContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDownloadMediaContent.DefaultText = "";
            this.txtDownloadMediaContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDownloadMediaContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDownloadMediaContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDownloadMediaContent.DisabledState.Parent = this.txtDownloadMediaContent;
            this.txtDownloadMediaContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDownloadMediaContent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtDownloadMediaContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtDownloadMediaContent.FocusedState.Parent = this.txtDownloadMediaContent;
            this.txtDownloadMediaContent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDownloadMediaContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtDownloadMediaContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtDownloadMediaContent.HoverState.Parent = this.txtDownloadMediaContent;
            this.txtDownloadMediaContent.Location = new System.Drawing.Point(43, 96);
            this.txtDownloadMediaContent.Margin = new System.Windows.Forms.Padding(5);
            this.txtDownloadMediaContent.Name = "txtDownloadMediaContent";
            this.txtDownloadMediaContent.PasswordChar = '\0';
            this.txtDownloadMediaContent.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtDownloadMediaContent.PlaceholderText = "Kullanıcı adını giriniz...";
            this.txtDownloadMediaContent.SelectedText = "";
            this.txtDownloadMediaContent.ShadowDecoration.Parent = this.txtDownloadMediaContent;
            this.txtDownloadMediaContent.Size = new System.Drawing.Size(532, 47);
            this.txtDownloadMediaContent.TabIndex = 15;
            // 
            // guna2GroupBox6
            // 
            this.guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox6.BorderRadius = 15;
            this.guna2GroupBox6.Controls.Add(this.btnShareChoiseImage);
            this.guna2GroupBox6.Controls.Add(this.btnShareAddData);
            this.guna2GroupBox6.Controls.Add(this.btnShareDeleteData);
            this.guna2GroupBox6.Controls.Add(this.dgvShareMedias);
            this.guna2GroupBox6.Controls.Add(this.btnShareStart);
            this.guna2GroupBox6.Controls.Add(this.dtpShareTime);
            this.guna2GroupBox6.Controls.Add(this.dtpShareDate);
            this.guna2GroupBox6.Controls.Add(this.label6);
            this.guna2GroupBox6.Controls.Add(this.label2);
            this.guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.guna2GroupBox6.Location = new System.Drawing.Point(10, 995);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.ShadowDecoration.Parent = this.guna2GroupBox6;
            this.guna2GroupBox6.Size = new System.Drawing.Size(618, 575);
            this.guna2GroupBox6.TabIndex = 24;
            this.guna2GroupBox6.Text = "Paylaşım İşlemleri";
            this.guna2GroupBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox6.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // btnShareChoiseImage
            // 
            this.btnShareChoiseImage.Animated = true;
            this.btnShareChoiseImage.BackColor = System.Drawing.Color.White;
            this.btnShareChoiseImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareChoiseImage.BorderRadius = 15;
            this.btnShareChoiseImage.BorderThickness = 2;
            this.btnShareChoiseImage.CheckedState.Parent = this.btnShareChoiseImage;
            this.btnShareChoiseImage.CustomImages.Parent = this.btnShareChoiseImage;
            this.btnShareChoiseImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareChoiseImage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShareChoiseImage.ForeColor = System.Drawing.Color.White;
            this.btnShareChoiseImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnShareChoiseImage.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnShareChoiseImage.HoverState.FillColor = System.Drawing.Color.White;
            this.btnShareChoiseImage.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnShareChoiseImage.HoverState.Parent = this.btnShareChoiseImage;
            this.btnShareChoiseImage.Location = new System.Drawing.Point(43, 135);
            this.btnShareChoiseImage.Name = "btnShareChoiseImage";
            this.btnShareChoiseImage.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.btnShareChoiseImage.ShadowDecoration.Parent = this.btnShareChoiseImage;
            this.btnShareChoiseImage.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnShareChoiseImage.Size = new System.Drawing.Size(252, 42);
            this.btnShareChoiseImage.TabIndex = 65;
            this.btnShareChoiseImage.Text = "Görsel Seç";
            this.btnShareChoiseImage.Click += new System.EventHandler(this.btnShareChoiseImage_Click);
            // 
            // btnShareAddData
            // 
            this.btnShareAddData.Animated = true;
            this.btnShareAddData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnShareAddData.BorderRadius = 15;
            this.btnShareAddData.BorderThickness = 2;
            this.btnShareAddData.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnShareAddData.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnShareAddData.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareAddData.CheckedState.Parent = this.btnShareAddData;
            this.btnShareAddData.CustomImages.Parent = this.btnShareAddData;
            this.btnShareAddData.FillColor = System.Drawing.Color.White;
            this.btnShareAddData.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShareAddData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnShareAddData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareAddData.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareAddData.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnShareAddData.HoverState.Parent = this.btnShareAddData;
            this.btnShareAddData.Location = new System.Drawing.Point(323, 135);
            this.btnShareAddData.Name = "btnShareAddData";
            this.btnShareAddData.ShadowDecoration.Parent = this.btnShareAddData;
            this.btnShareAddData.Size = new System.Drawing.Size(252, 42);
            this.btnShareAddData.TabIndex = 64;
            this.btnShareAddData.Text = "Paylaşım Ekle";
            this.btnShareAddData.Click += new System.EventHandler(this.btnShareAddData_Click);
            // 
            // btnShareDeleteData
            // 
            this.btnShareDeleteData.Animated = true;
            this.btnShareDeleteData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnShareDeleteData.BorderRadius = 15;
            this.btnShareDeleteData.BorderThickness = 2;
            this.btnShareDeleteData.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnShareDeleteData.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnShareDeleteData.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareDeleteData.CheckedState.Parent = this.btnShareDeleteData;
            this.btnShareDeleteData.CustomImages.Parent = this.btnShareDeleteData;
            this.btnShareDeleteData.FillColor = System.Drawing.Color.White;
            this.btnShareDeleteData.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShareDeleteData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnShareDeleteData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareDeleteData.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareDeleteData.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnShareDeleteData.HoverState.Parent = this.btnShareDeleteData;
            this.btnShareDeleteData.Location = new System.Drawing.Point(43, 198);
            this.btnShareDeleteData.Name = "btnShareDeleteData";
            this.btnShareDeleteData.ShadowDecoration.Parent = this.btnShareDeleteData;
            this.btnShareDeleteData.Size = new System.Drawing.Size(252, 42);
            this.btnShareDeleteData.TabIndex = 63;
            this.btnShareDeleteData.Text = "Seçilenleri Sil";
            this.btnShareDeleteData.Click += new System.EventHandler(this.btnShareDeleteData_Click);
            // 
            // dgvShareMedias
            // 
            this.dgvShareMedias.AllowUserToAddRows = false;
            this.dgvShareMedias.AllowUserToDeleteRows = false;
            this.dgvShareMedias.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvShareMedias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShareMedias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShareMedias.BackgroundColor = System.Drawing.Color.White;
            this.dgvShareMedias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShareMedias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShareMedias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShareMedias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShareMedias.ColumnHeadersHeight = 38;
            this.dgvShareMedias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ShareAccount,
            this.ShareDate,
            this.ShareTime,
            this.ShareMediaPath});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShareMedias.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShareMedias.EnableHeadersVisualStyles = false;
            this.dgvShareMedias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShareMedias.Location = new System.Drawing.Point(13, 257);
            this.dgvShareMedias.Name = "dgvShareMedias";
            this.dgvShareMedias.ReadOnly = true;
            this.dgvShareMedias.RowHeadersVisible = false;
            this.dgvShareMedias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShareMedias.Size = new System.Drawing.Size(594, 309);
            this.dgvShareMedias.TabIndex = 62;
            this.dgvShareMedias.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvShareMedias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShareMedias.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShareMedias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShareMedias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShareMedias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShareMedias.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvShareMedias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShareMedias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.dgvShareMedias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShareMedias.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvShareMedias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShareMedias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShareMedias.ThemeStyle.HeaderStyle.Height = 38;
            this.dgvShareMedias.ThemeStyle.ReadOnly = true;
            this.dgvShareMedias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShareMedias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShareMedias.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvShareMedias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.dgvShareMedias.ThemeStyle.RowsStyle.Height = 22;
            this.dgvShareMedias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShareMedias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 94.41803F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // ShareAccount
            // 
            this.ShareAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShareAccount.FillWeight = 109.2551F;
            this.ShareAccount.HeaderText = "Paylaşım Hesabı";
            this.ShareAccount.Name = "ShareAccount";
            this.ShareAccount.ReadOnly = true;
            // 
            // ShareDate
            // 
            this.ShareDate.FillWeight = 109.2551F;
            this.ShareDate.HeaderText = "Paylaşım Günü";
            this.ShareDate.Name = "ShareDate";
            this.ShareDate.ReadOnly = true;
            // 
            // ShareTime
            // 
            this.ShareTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShareTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShareTime.FillWeight = 109.2551F;
            this.ShareTime.HeaderText = "Paylaşım Saati";
            this.ShareTime.Name = "ShareTime";
            this.ShareTime.ReadOnly = true;
            // 
            // ShareMediaPath
            // 
            this.ShareMediaPath.FillWeight = 109.2551F;
            this.ShareMediaPath.HeaderText = "Paylaşım Resmi";
            this.ShareMediaPath.Name = "ShareMediaPath";
            this.ShareMediaPath.ReadOnly = true;
            // 
            // btnShareStart
            // 
            this.btnShareStart.Animated = true;
            this.btnShareStart.BackColor = System.Drawing.Color.White;
            this.btnShareStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareStart.BorderRadius = 15;
            this.btnShareStart.BorderThickness = 2;
            this.btnShareStart.CheckedState.Parent = this.btnShareStart;
            this.btnShareStart.CustomImages.Parent = this.btnShareStart;
            this.btnShareStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnShareStart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShareStart.ForeColor = System.Drawing.Color.White;
            this.btnShareStart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnShareStart.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnShareStart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnShareStart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnShareStart.HoverState.Parent = this.btnShareStart;
            this.btnShareStart.Location = new System.Drawing.Point(323, 198);
            this.btnShareStart.Name = "btnShareStart";
            this.btnShareStart.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.btnShareStart.ShadowDecoration.Parent = this.btnShareStart;
            this.btnShareStart.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnShareStart.Size = new System.Drawing.Size(252, 42);
            this.btnShareStart.TabIndex = 58;
            this.btnShareStart.Text = "Paylaşımı Başlat";
            this.btnShareStart.Click += new System.EventHandler(this.btnShareStart_Click);
            // 
            // dtpShareTime
            // 
            this.dtpShareTime.CalendarForeColor = System.Drawing.Color.Lime;
            this.dtpShareTime.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dtpShareTime.CalendarTitleBackColor = System.Drawing.Color.DarkOrange;
            this.dtpShareTime.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dtpShareTime.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpShareTime.CustomFormat = "HH:mm";
            this.dtpShareTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShareTime.Location = new System.Drawing.Point(323, 87);
            this.dtpShareTime.Name = "dtpShareTime";
            this.dtpShareTime.ShowUpDown = true;
            this.dtpShareTime.Size = new System.Drawing.Size(252, 29);
            this.dtpShareTime.TabIndex = 56;
            this.dtpShareTime.Value = new System.DateTime(2020, 12, 29, 0, 0, 0, 0);
            // 
            // dtpShareDate
            // 
            this.dtpShareDate.Animated = true;
            this.dtpShareDate.BackColor = System.Drawing.Color.White;
            this.dtpShareDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.dtpShareDate.BorderRadius = 8;
            this.dtpShareDate.CheckedState.Parent = this.dtpShareDate;
            this.dtpShareDate.FillColor = System.Drawing.Color.White;
            this.dtpShareDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.dtpShareDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShareDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.dtpShareDate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.dtpShareDate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.dtpShareDate.HoverState.Parent = this.dtpShareDate;
            this.dtpShareDate.Location = new System.Drawing.Point(321, 43);
            this.dtpShareDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpShareDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpShareDate.Name = "dtpShareDate";
            this.dtpShareDate.ShadowDecoration.Parent = this.dtpShareDate;
            this.dtpShareDate.Size = new System.Drawing.Size(254, 36);
            this.dtpShareDate.TabIndex = 22;
            this.dtpShareDate.Value = new System.DateTime(2021, 7, 15, 15, 48, 40, 261);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(100, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Paylaşım Tarihi Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(104, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Paylaşım Saati Seçiniz :";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox3.BorderRadius = 15;
            this.guna2GroupBox3.Controls.Add(this.label1);
            this.guna2GroupBox3.Controls.Add(this.numberUnFollowTime);
            this.guna2GroupBox3.Controls.Add(this.btnUnFollowStart);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(10, 624);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(618, 148);
            this.guna2GroupBox3.TabIndex = 22;
            this.guna2GroupBox3.Text = "Takipten Çıkma İşlemleri";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox3.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "İşlem Yapılacak Süre (sn):";
            // 
            // numberUnFollowTime
            // 
            this.numberUnFollowTime.BackColor = System.Drawing.Color.White;
            this.numberUnFollowTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.numberUnFollowTime.BorderRadius = 8;
            this.numberUnFollowTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberUnFollowTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numberUnFollowTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numberUnFollowTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numberUnFollowTime.DisabledState.Parent = this.numberUnFollowTime;
            this.numberUnFollowTime.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numberUnFollowTime.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numberUnFollowTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.numberUnFollowTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.numberUnFollowTime.FocusedState.Parent = this.numberUnFollowTime;
            this.numberUnFollowTime.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberUnFollowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.numberUnFollowTime.Location = new System.Drawing.Point(277, 41);
            this.numberUnFollowTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numberUnFollowTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberUnFollowTime.Name = "numberUnFollowTime";
            this.numberUnFollowTime.ShadowDecoration.Parent = this.numberUnFollowTime;
            this.numberUnFollowTime.Size = new System.Drawing.Size(289, 36);
            this.numberUnFollowTime.TabIndex = 18;
            this.numberUnFollowTime.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.numberUnFollowTime.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // btnUnFollowStart
            // 
            this.btnUnFollowStart.Animated = true;
            this.btnUnFollowStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnUnFollowStart.BorderRadius = 15;
            this.btnUnFollowStart.BorderThickness = 2;
            this.btnUnFollowStart.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnUnFollowStart.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnUnFollowStart.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnUnFollowStart.CheckedState.Parent = this.btnUnFollowStart;
            this.btnUnFollowStart.CustomImages.Parent = this.btnUnFollowStart;
            this.btnUnFollowStart.FillColor = System.Drawing.Color.White;
            this.btnUnFollowStart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnFollowStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnUnFollowStart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnUnFollowStart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnUnFollowStart.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUnFollowStart.HoverState.Parent = this.btnUnFollowStart;
            this.btnUnFollowStart.Location = new System.Drawing.Point(139, 85);
            this.btnUnFollowStart.Name = "btnUnFollowStart";
            this.btnUnFollowStart.ShadowDecoration.Parent = this.btnUnFollowStart;
            this.btnUnFollowStart.Size = new System.Drawing.Size(319, 47);
            this.btnUnFollowStart.TabIndex = 65;
            this.btnUnFollowStart.Text = "Takipten Çıkma İşlemini Başlat";
            this.btnUnFollowStart.Click += new System.EventHandler(this.btnUnFollowStart_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox2.BorderRadius = 15;
            this.guna2GroupBox2.Controls.Add(this.cmbFollowType);
            this.guna2GroupBox2.Controls.Add(this.btnFollowStart);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.numberFollowTime);
            this.guna2GroupBox2.Controls.Add(this.cbFollowPrivateAcc);
            this.guna2GroupBox2.Controls.Add(this.txtFollowContent);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(10, 332);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(618, 286);
            this.guna2GroupBox2.TabIndex = 16;
            this.guna2GroupBox2.Text = "Takip Etme İşlemleri";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // cmbFollowType
            // 
            this.cmbFollowType.Animated = true;
            this.cmbFollowType.BackColor = System.Drawing.Color.White;
            this.cmbFollowType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbFollowType.BorderRadius = 15;
            this.cmbFollowType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFollowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFollowType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbFollowType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cmbFollowType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cmbFollowType.FocusedState.Parent = this.cmbFollowType;
            this.cmbFollowType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFollowType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cmbFollowType.FormattingEnabled = true;
            this.cmbFollowType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.cmbFollowType.HoverState.Parent = this.cmbFollowType;
            this.cmbFollowType.ItemHeight = 40;
            this.cmbFollowType.Items.AddRange(new object[] {
            "Profilden Takip Et",
            "Gönderiyi Beğenenlerden Takip Et"});
            this.cmbFollowType.ItemsAppearance.Parent = this.cmbFollowType;
            this.cmbFollowType.Location = new System.Drawing.Point(43, 42);
            this.cmbFollowType.Name = "cmbFollowType";
            this.cmbFollowType.ShadowDecoration.Parent = this.cmbFollowType;
            this.cmbFollowType.Size = new System.Drawing.Size(532, 46);
            this.cmbFollowType.TabIndex = 21;
            this.cmbFollowType.SelectedIndexChanged += new System.EventHandler(this.cmbFollowType_SelectedIndexChanged);
            // 
            // btnFollowStart
            // 
            this.btnFollowStart.Animated = true;
            this.btnFollowStart.BackColor = System.Drawing.Color.White;
            this.btnFollowStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnFollowStart.BorderRadius = 15;
            this.btnFollowStart.BorderThickness = 2;
            this.btnFollowStart.CheckedState.Parent = this.btnFollowStart;
            this.btnFollowStart.CustomImages.Parent = this.btnFollowStart;
            this.btnFollowStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnFollowStart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFollowStart.ForeColor = System.Drawing.Color.White;
            this.btnFollowStart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFollowStart.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFollowStart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFollowStart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnFollowStart.HoverState.Parent = this.btnFollowStart;
            this.btnFollowStart.Location = new System.Drawing.Point(139, 226);
            this.btnFollowStart.Name = "btnFollowStart";
            this.btnFollowStart.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue;
            this.btnFollowStart.ShadowDecoration.Parent = this.btnFollowStart;
            this.btnFollowStart.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnFollowStart.Size = new System.Drawing.Size(319, 47);
            this.btnFollowStart.TabIndex = 15;
            this.btnFollowStart.Text = "Takip İşlemini Başlat";
            this.btnFollowStart.Click += new System.EventHandler(this.btnFollowStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(39, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "İşlem Yapılacak Süre (sn):";
            // 
            // numberFollowTime
            // 
            this.numberFollowTime.BackColor = System.Drawing.Color.White;
            this.numberFollowTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.numberFollowTime.BorderRadius = 8;
            this.numberFollowTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberFollowTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numberFollowTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numberFollowTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numberFollowTime.DisabledState.Parent = this.numberFollowTime;
            this.numberFollowTime.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numberFollowTime.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numberFollowTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.numberFollowTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.numberFollowTime.FocusedState.Parent = this.numberFollowTime;
            this.numberFollowTime.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberFollowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.numberFollowTime.Location = new System.Drawing.Point(277, 182);
            this.numberFollowTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numberFollowTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberFollowTime.Name = "numberFollowTime";
            this.numberFollowTime.ShadowDecoration.Parent = this.numberFollowTime;
            this.numberFollowTime.Size = new System.Drawing.Size(289, 36);
            this.numberFollowTime.TabIndex = 18;
            this.numberFollowTime.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.numberFollowTime.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // cbFollowPrivateAcc
            // 
            this.cbFollowPrivateAcc.Animated = true;
            this.cbFollowPrivateAcc.AutoSize = true;
            this.cbFollowPrivateAcc.BackColor = System.Drawing.Color.White;
            this.cbFollowPrivateAcc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.cbFollowPrivateAcc.CheckedState.BorderRadius = 2;
            this.cbFollowPrivateAcc.CheckedState.BorderThickness = 0;
            this.cbFollowPrivateAcc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(46)))));
            this.cbFollowPrivateAcc.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.cbFollowPrivateAcc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFollowPrivateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cbFollowPrivateAcc.Location = new System.Drawing.Point(43, 151);
            this.cbFollowPrivateAcc.Name = "cbFollowPrivateAcc";
            this.cbFollowPrivateAcc.Size = new System.Drawing.Size(213, 23);
            this.cbFollowPrivateAcc.TabIndex = 17;
            this.cbFollowPrivateAcc.Text = "Gizli Hesapları Takip Etme";
            this.cbFollowPrivateAcc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cbFollowPrivateAcc.UncheckedState.BorderRadius = 2;
            this.cbFollowPrivateAcc.UncheckedState.BorderThickness = 0;
            this.cbFollowPrivateAcc.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.cbFollowPrivateAcc.UseVisualStyleBackColor = false;
            // 
            // txtFollowContent
            // 
            this.txtFollowContent.Animated = true;
            this.txtFollowContent.BackColor = System.Drawing.Color.White;
            this.txtFollowContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtFollowContent.BorderRadius = 15;
            this.txtFollowContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFollowContent.DefaultText = "";
            this.txtFollowContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFollowContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFollowContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFollowContent.DisabledState.Parent = this.txtFollowContent;
            this.txtFollowContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFollowContent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtFollowContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtFollowContent.FocusedState.Parent = this.txtFollowContent;
            this.txtFollowContent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFollowContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtFollowContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.txtFollowContent.HoverState.Parent = this.txtFollowContent;
            this.txtFollowContent.Location = new System.Drawing.Point(43, 96);
            this.txtFollowContent.Margin = new System.Windows.Forms.Padding(5);
            this.txtFollowContent.Name = "txtFollowContent";
            this.txtFollowContent.PasswordChar = '\0';
            this.txtFollowContent.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtFollowContent.PlaceholderText = "Kullanıcı adını giriniz...";
            this.txtFollowContent.SelectedText = "";
            this.txtFollowContent.ShadowDecoration.Parent = this.txtFollowContent;
            this.txtFollowContent.Size = new System.Drawing.Size(523, 47);
            this.txtFollowContent.TabIndex = 15;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.cmbUser);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.txtAccountPassword);
            this.guna2GroupBox1.Controls.Add(this.txtAccountUserName);
            this.guna2GroupBox1.Controls.Add(this.btnLogin);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 8);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(618, 318);
            this.guna2GroupBox1.TabIndex = 6;
            this.guna2GroupBox1.Text = "Hesap İşlemleri";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // cmbUser
            // 
            this.cmbUser.Animated = true;
            this.cmbUser.BackColor = System.Drawing.Color.White;
            this.cmbUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbUser.BorderRadius = 15;
            this.cmbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.cmbUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.cmbUser.FocusedState.Parent = this.cmbUser;
            this.cmbUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.cmbUser.HoverState.Parent = this.cmbUser;
            this.cmbUser.ItemHeight = 40;
            this.cmbUser.ItemsAppearance.Parent = this.cmbUser;
            this.cmbUser.Location = new System.Drawing.Point(43, 49);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.ShadowDecoration.Parent = this.cmbUser;
            this.cmbUser.Size = new System.Drawing.Size(532, 46);
            this.cmbUser.TabIndex = 20;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(149, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kullandığınız hesapta 1 saat arayla cihaz değiştiriniz!";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(138, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Programı kullanırken farklı bir cihazdan giriş yapmayınız!";
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Animated = true;
            this.txtAccountPassword.BackColor = System.Drawing.Color.White;
            this.txtAccountPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtAccountPassword.BorderRadius = 15;
            this.txtAccountPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountPassword.DefaultText = "";
            this.txtAccountPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountPassword.DisabledState.Parent = this.txtAccountPassword;
            this.txtAccountPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtAccountPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtAccountPassword.FocusedState.Parent = this.txtAccountPassword;
            this.txtAccountPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAccountPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtAccountPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtAccountPassword.HoverState.Parent = this.txtAccountPassword;
            this.txtAccountPassword.Location = new System.Drawing.Point(43, 160);
            this.txtAccountPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.PasswordChar = '\0';
            this.txtAccountPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtAccountPassword.PlaceholderText = "Şifrenizi giriniz...";
            this.txtAccountPassword.SelectedText = "";
            this.txtAccountPassword.ShadowDecoration.Parent = this.txtAccountPassword;
            this.txtAccountPassword.Size = new System.Drawing.Size(532, 47);
            this.txtAccountPassword.TabIndex = 4;
            // 
            // txtAccountUserName
            // 
            this.txtAccountUserName.Animated = true;
            this.txtAccountUserName.BackColor = System.Drawing.Color.White;
            this.txtAccountUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.txtAccountUserName.BorderRadius = 15;
            this.txtAccountUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountUserName.DefaultText = "";
            this.txtAccountUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountUserName.DisabledState.Parent = this.txtAccountUserName;
            this.txtAccountUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtAccountUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtAccountUserName.FocusedState.Parent = this.txtAccountUserName;
            this.txtAccountUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAccountUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtAccountUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtAccountUserName.HoverState.Parent = this.txtAccountUserName;
            this.txtAccountUserName.Location = new System.Drawing.Point(43, 103);
            this.txtAccountUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccountUserName.Name = "txtAccountUserName";
            this.txtAccountUserName.PasswordChar = '\0';
            this.txtAccountUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.txtAccountUserName.PlaceholderText = "Kullanıcı adını giriniz...";
            this.txtAccountUserName.SelectedText = "";
            this.txtAccountUserName.ShadowDecoration.Parent = this.txtAccountUserName;
            this.txtAccountUserName.Size = new System.Drawing.Size(532, 47);
            this.txtAccountUserName.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLogin.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(139, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(328, 47);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.guna2Panel2;
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.VScrollBar1);
            this.Name = "Content";
            this.Size = new System.Drawing.Size(1200, 534);
            this.Load += new System.EventHandler(this.Content_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox6.ResumeLayout(false);
            this.guna2GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShareMedias)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUnFollowTime)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFollowTime)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2VScrollBar VScrollBar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountUserName;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFollowType;
        private Guna.UI2.WinForms.Guna2Button btnFollowStart;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numberFollowTime;
        private Guna.UI2.WinForms.Guna2CheckBox cbFollowPrivateAcc;
        private Guna.UI2.WinForms.Guna2TextBox txtFollowContent;
        private MyListDesign.MyListBox lstShowProcess;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numberUnFollowTime;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDownloadMediaType;
        private Guna.UI2.WinForms.Guna2Button btnDownloadMediaStart;
        private Guna.UI2.WinForms.Guna2TextBox txtDownloadMediaContent;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private System.Windows.Forms.DateTimePicker dtpShareTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpShareDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShareMedias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareMediaPath;
        private Guna.UI2.WinForms.Guna2Button btnShareStart;
        private Guna.UI2.WinForms.Guna2Button btnShareAddData;
        private Guna.UI2.WinForms.Guna2Button btnShareDeleteData;
        private Guna.UI2.WinForms.Guna2Button btnUnFollowStart;
        private Guna.UI2.WinForms.Guna2Button btnShareChoiseImage;
    }
}
