using InstamRise.DirectoryProcess;
using InstamRise.LoginProcess;
using InstamRise.MediaProcess;
using InstamRise.UserProcess;
using InstamRiseDatabaseProcess.DatabaseProcess;
using InstamRiseDatabaseProcess.Models;
using InstamRiseDataProcess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise.UserInterface
{
    public partial class Content : UserControl
    {
        string MediaPath = null;
        public Content()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            pnlContainer.Location = new Point(14, 3);
            this.MouseWheel += new MouseEventHandler(this_MouseWheel);
            guna2Panel1.MouseWheel += new MouseEventHandler(this_MouseWheel);
            lstShowProcess.MouseWheel += new MouseEventHandler(this_MouseWheel);

        }
        private void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Convert.ToString(e.Delta) == "120")
            {
                if (VScrollBar1.Value > 0)
                {
                    VScrollBar1.Value = VScrollBar1.Value - 25;
                }
            }
            else if (Convert.ToString(e.Delta) == "-120")
            {
                if (VScrollBar1.Value < 1100)
                {
                    VScrollBar1.Value = VScrollBar1.Value + 25;
                }
            }
        }
        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pnlContainer.Location = new Point(14, 0 - VScrollBar1.Value);
        }

        private void cmbFollowType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFollowType.SelectedIndex == 0)
            {
                txtFollowContent.PlaceholderText = "Kullanıcı adı giriniz...";
            }
            else if (cmbFollowType.SelectedIndex == 1)
            {
                txtFollowContent.PlaceholderText = "Gönderi linki giriniz...";
            }
            else
            {
                txtFollowContent.PlaceholderText = "";
            }
        }

        private void cmbDownloadMediaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDownloadMediaType.SelectedIndex == 0)
            {
                txtDownloadMediaContent.PlaceholderText = "Kullanıcı adı giriniz...";
            }
            else
            {
                txtDownloadMediaContent.PlaceholderText = "";
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAccountUserName.Text) && !string.IsNullOrEmpty(txtAccountPassword.Text))
            {
                lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hesaba giriş yapılıyor... ");

                if (await LoginAcc.MultiLogin(txtAccountUserName.Text, txtAccountPassword.Text, cmbUser))
                {
                    if (ExceptionStatus.Exception == "Success")
                    {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Başarıyla giriş yapıldı... ");
                    }
                }
                else
                {
                    if (ExceptionStatus.Exception == "BadPassword")
                    {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hesaba giriş yapılamadı, şifre ya da kullanıcı adı hatalı... ");
                    }
                    else if (ExceptionStatus.Exception == "Invalid Credentials")
                    {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hesap bulunamadı, giriş bilgileri geçersiz. ");

                    }
                    else if (ExceptionStatus.Exception == "Challenge is required") {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hesap doğrulamaya düştü. ");
                    }
                    else
                    {
                        MessageBox.Show(ExceptionStatus.Exception);
                    }
                }

            }
        }

        private void btnFollowStart_Click(object sender, EventArgs e)
        {
            if (AccControl())
            {
                if (!String.IsNullOrEmpty(txtFollowContent.Text))
                {
                    if (cmbFollowType.SelectedIndex == 0)
                    {
                        FollowUnFollow.Follow follow = new FollowUnFollow.Follow();
                        follow.FollowProfileFollowerUsers(txtFollowContent.Text, Convert.ToInt32(numberFollowTime.Value), cbFollowPrivateAcc.Checked, lstShowProcess);
                    }
                    else
                    {
                        FollowUnFollow.Follow follow = new FollowUnFollow.Follow();
                        follow.FollowMediaLikeUsers(txtFollowContent.Text, Convert.ToInt32(numberFollowTime.Value), cbFollowPrivateAcc.Checked, lstShowProcess);
                    }
                }
                else
                {
                    lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Takip işlemi için gerekli alanları doldurunuz. ");
                }
            }
        }

        private void btnUnFollowStart_Click(object sender, EventArgs e)
        {
            if (AccControl())
            {
                FollowUnFollow.UnFollow unFollow = new FollowUnFollow.UnFollow();
                unFollow.UnFollowUserinFollowingUsers(cmbUser.SelectedItem.ToString(), Convert.ToInt32(numberUnFollowTime.Value), lstShowProcess);
            }
        }

        private void btnDownloadMediaStart_Click(object sender, EventArgs e)
        {
            if (AccControl())
            {
                if (cmbDownloadMediaType.SelectedIndex != -1)
                {
                    if (!String.IsNullOrEmpty(txtDownloadMediaContent.Text))
                    {
                        if (cmbDownloadMediaType.SelectedIndex == 0)
                        {
                            DownloadMedia downloadMedia = new DownloadMedia();
                            downloadMedia.DownloadMediaInProfile(txtDownloadMediaContent.Text, lstShowProcess);
                        }
                    }

                }
                else {
                    lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İndirme türü seçiniz. ");
                }
            }
        }

        private void btnShareChoiseImage_Click(object sender, EventArgs e)
        {
            if (AccControl())
            {
                MediaPath = null;
                OpenFileDialogChoisePicture dialogChoisePicture = new OpenFileDialogChoisePicture();
                MediaPath = dialogChoisePicture.ChoisePicture();
            }
        }

        private void btnShareAddData_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (cmbUser.SelectedIndex != -1)
            {
                if (MediaPath != null)
                {
                    if (Convert.ToDateTime(dtpShareDate.Value.ToString("dd/MM/yyyy")) == DateTime.Today && Convert.ToDateTime(dtpShareTime.Value.ToString("HH:mm")) <= Convert.ToDateTime(dateTime.ToString("HH:mm")))
                    {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İleri bir saate ayarlayınız. ");
                       
                    }
                    else if (Convert.ToDateTime(dtpShareDate.Value.ToString("dd/MM/yyyy")) < Convert.ToDateTime(dateTime.ToString("dd/MM/yyyy")))
                    {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İleri bir güne ayarlayınız. ");
                    }
                    else
                    {

                        ShareModels.ShareAccount = cmbUser.SelectedItem.ToString();
                        ShareModels.ShareDate = dtpShareDate.Value.ToString("dd/MM/yyyy");
                        ShareModels.ShareTime = dtpShareTime.Value.ToString("HH:mm");
                        ShareModels.ShareImagePath = MediaPath;
                        ShareModels.Status = 0;

                        Insert ınsert = new Insert();
                        ınsert.InsertData();

                        GetDatabaseData();
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Paylaşım eklendi. ");
                    }
                }
                else {
                    lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlem yapılabilmesi için görsel seçiniz. ");
                }
            }
            else {
                lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlem yapılabilmesi için bir hesap seçiniz. ");
            }
        }
        public bool AccControl()
        {
            if (cmbUser.SelectedIndex == -1)
            {
                lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlem yapılabilmesi için bir hesaba giriniz. ");
                return false;
            }
            else {
                return true;
            }
        }
        async void GetDatabaseData()
        {
            GetDatabaseData getDatabaseData = new GetDatabaseData();
            dgvShareMedias.DataSource = null;
            dgvShareMedias.DataSource = getDatabaseData.GetDataTable();
            if (dgvShareMedias.RowCount>0)
            {
                dgvShareMedias.Sort(this.dgvShareMedias.Columns["Paylaşım_Tarihi"], ListSortDirection.Ascending);
                dgvShareMedias.Columns[0].Width = 35;
                dgvShareMedias.Columns[1].Width = 130;
                dgvShareMedias.Columns[2].Width = 130;
            }
          
        }

        private void btnShareDeleteData_Click(object sender, EventArgs e)
        {
            if (dgvShareMedias.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dgvShareMedias.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    Delete delete = new Delete();
                    delete.DeleteData(Convert.ToInt32(dgvShareMedias.SelectedRows[0].Cells[0].Value.ToString()));
                    GetDatabaseData();
                }
            }
            else
            {
                //Lütfen Bir Satır Seçiniz!
            }
        }

        private void btnShareStart_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex != -1)
            {
                if (dgvShareMedias.RowCount > 0)
                {
                    lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hikaye paylaşım işlemi başlatıldı.");
                    Thread t = new Thread(new ThreadStart(ShareStory));
                    t.Start();
                }
            }
            else
            {
                lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlemin başlatılması için bir hesap giriniz.");
            }
        }
        async void ShareStory()
        {
            for (int i = 0; i < dgvShareMedias.RowCount; i++)
            {
                string _datetime_ = dgvShareMedias.Rows[i].Cells[2].Value.ToString();
                string[] parcala = _datetime_.Split(' ');
                DateTime date = Convert.ToDateTime(parcala[0]);
                DateTime time = Convert.ToDateTime(parcala[1]);
                lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Paylaşım zamanı : " + _datetime_);
                string username = dgvShareMedias.Rows[i].Cells[1].Value.ToString();
                if (username == cmbUser.SelectedItem.ToString())
                {
                    DateTime dt = Convert.ToDateTime(DateTime.Now.ToString("HH:mm"));
                    if (date == DateTime.Today && time >= dt)
                    {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hikaye paylaşım süresi bekleniyor.");
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Saat " + time.ToString("HH:mm") + " paylaşım yapılacaktır.");
                        int count = 0;
                        while (time > DateTime.Now) { count++; if (count % 300 == 0) { lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Paylaşım için bekleniliyor..."); } Thread.Sleep(1000); }
                        if (await UploadStory.StoryUpload(dgvShareMedias.Rows[i].Cells[3].Value.ToString()))
                        {
                            Update update = new Update();
                            update.UpdateData(Convert.ToInt32(dgvShareMedias.Rows[i].Cells[0].Value));
                            lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hikaye paylaşıldı. ");
                            lstShowProcess.Items.Insert(0, "-----------------------------------------------------------------------------------------");
                        }
                        else
                        {
                            lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hikaye paylaşılamadı. ");
                            lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Sebep : " + ExceptionStatus.Exception);
                        }

                    }
                    else if (date <= DateTime.Today)
                    {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Paylaşım tarihi geçmiştir, hikaye paylaşımı iptal ediliyor.");
                        Delete delete = new Delete();
                        delete.DeleteData(Convert.ToInt32(dgvShareMedias.Rows[i].Cells[0].Value));
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İptal edilen hikaye : " + dgvShareMedias.Rows[i].Cells[3].Value.ToString());
                    }
                }
                else
                {
                    lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlem yapılacak kullanıcı paylaşım hesabına ait değildir.");
                }

            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex != -1)
            {
                CurrentUser.SetCurrentUser(cmbUser.SelectedItem.ToString());
                lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlem yapılacak kullanıcı : " + cmbUser.SelectedItem);
            }
        }

        private async void Content_Load(object sender, EventArgs e)
        {
            await LoginAcc.LoadUsers(cmbUser);
            DatabaseConnString.ConnectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            dgvShareMedias.Columns.Clear();
            GetDatabaseData();


            dtpShareTime.Value = Convert.ToDateTime(DateTime.Now.ToString("HH:mm"));
            dtpShareDate.Value = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
        }
    }
}
