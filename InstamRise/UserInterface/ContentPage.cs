using InstamRise.DirectoryProcess;
using InstamRise.LoginProcess;
using InstamRise.MediaProcess;
using InstamRiseDatabaseProcess.DatabaseSettings;
using InstamRiseDatabaseProcess.DatabaseProcess;
using InstamRiseDatabaseProcess.Models;
using InstamRise.Models;
using InstamRise.UserProcess;
using InstamRiseDataProcess.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.ComponentModel;

namespace InstamRise.UserInterface
{
    public partial class ContentPage : UserControl
    {
        public string MediaPath = null;

        public ContentPage()
        {
            InitializeComponent();
            guna2Panel1.Location = new Point(0,0);

            
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            guna2Panel1.Location = new Point(0,0-VScrollBar1.Value);
        }

        private async void btnAccountLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAccountUserName.Text) && !string.IsNullOrEmpty(txtAccountPassword.Text))
            {
                if (await LoginAcc.MultiLogin(txtAccountUserName.Text, txtAccountPassword.Text, cmbUser))
                {
                    if (ExceptionStatus.Exception == "Success")
                    {
                        MessageBox.Show("Başarıyla giriş yapıldı");
                    }
                }else
                {
                    if (ExceptionStatus.Exception == "BadPassword")
                    {
                        MessageBox.Show("Şifreniz ya da kullanıcı adınız hatalı");
                    }
                    else
                    {
                        MessageBox.Show(ExceptionStatus.Exception);
                    }
                }
                
            }
        }

        private void ContentPage_Load(object sender, EventArgs e)
        {
            LoginAcc.LoadUsers(cmbUser);
            DatabaseConnString.ConnectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            dgvShareMedias.Columns.Clear();
            GetDatabaseData();


            dtpShareTime.Value= Convert.ToDateTime(DateTime.Now.ToString("HH:mm"));
            dtpShareDate.Value = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            //Colors.ColorLightOrange.AddRange(new int[] { 254, 65, 60}); 
            //Colors.ColorTransparentOrange.AddRange(new int[] { 52, 44, 47 });
            //Colors.ColorLightYellow.AddRange(new int[] { 255,188, 44 });
            //Colors.ColorTransparentYellow.AddRange(new int[] { 64, 60, 46 }); 
        }
       
        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex!=-1)
            {
                CurrentUser.SetCurrentUser(cmbUser.SelectedItem.ToString());
            }
        }

        private void btnFollowStart_Click(object sender, EventArgs e)
        {
            if (cmbFollowType.SelectedIndex!=-1)
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

                }
            }
         
        }

        private void btnUnFollowStart_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex!=-1)
            {
                FollowUnFollow.UnFollow unFollow = new FollowUnFollow.UnFollow();
                unFollow.UnFollowUserinFollowingUsers(cmbUser.SelectedItem.ToString(),Convert.ToInt32(numberUnFollowTime.Value),lstShowProcess);
            }
            
        }

        private void cmbDownloadMediaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDownloadMediaType.SelectedIndex!=-1)
            {
                if (cmbDownloadMediaType.SelectedIndex == 0)
                {
                    txtDownloadMediaContent.PlaceholderText = "Kullanıcı adı giriniz...";
                }
                else {
                    txtDownloadMediaContent.PlaceholderText = "";
                }
            }
        }

        private void btnDownloadMediaStart_Click(object sender, EventArgs e)
        {
            if (cmbDownloadMediaType.SelectedIndex != -1)
            {
                if (!String.IsNullOrEmpty(txtDownloadMediaContent.Text))
                {
                    if (cmbDownloadMediaType.SelectedIndex == 0)
                    {
                        DownloadMedia downloadMedia = new DownloadMedia();
                        downloadMedia.DownloadMediaInProfile(txtDownloadMediaContent.Text,lstShowProcess);
                    }
                }
                
            }
        }

        private void btnShareChoiseImage_Click(object sender, EventArgs e)
        {
            MediaPath = null;
            OpenFileDialogChoisePicture dialogChoisePicture = new OpenFileDialogChoisePicture();
            MediaPath = dialogChoisePicture.ChoisePicture();
        }

        private void btnShareAddData_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (cmbUser.SelectedIndex!=-1)
            {
                if (MediaPath != null)
                {
                    if (Convert.ToDateTime(dtpShareDate.Value.ToString("dd/MM/yyyy")) == DateTime.Today && Convert.ToDateTime(dtpShareTime.Value.ToString("HH:mm")) <= Convert.ToDateTime(dateTime.ToString("HH:mm")))
                    {
                        //Lütfen İleri Bir Saate Ayarlayınız!
                    }
                    else if (Convert.ToDateTime(dtpShareDate.Value.ToString("dd/MM/yyyy")) < Convert.ToDateTime(dateTime.ToString("dd/MM/yyyy")))
                    {
                        //Lütfen İleri Bir Güne Ayarlayınız!
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
                    }
                }
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

        void GetDatabaseData() {
            GetDatabaseData getDatabaseData = new GetDatabaseData();
            dgvShareMedias.DataSource = null;
            dgvShareMedias.DataSource = getDatabaseData.GetDataTable();
            dgvShareMedias.Sort(this.dgvShareMedias.Columns["Paylaşım_Tarihi"], ListSortDirection.Ascending);
            dgvShareMedias.Columns[0].Width = 35;
            dgvShareMedias.Columns[1].Width = 120;
            dgvShareMedias.Columns[2].Width = 120;
        }
        async void ShareStory() {
            for (int i = 0; i < dgvShareMedias.RowCount - 1; i++)
            {
                string _datetime_ = dgvShareMedias.Rows[i].Cells[2].Value.ToString();
                string[] parcala = _datetime_.Split(' ');
                DateTime date = Convert.ToDateTime(parcala[0]);
                DateTime time = Convert.ToDateTime(parcala[1]);
                lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Paylaşım zamanı : "+_datetime_);
                string username = dgvShareMedias.Rows[i].Cells[1].Value.ToString();
                if (username == cmbUser.SelectedItem.ToString())
                {
                    DateTime dt = Convert.ToDateTime(DateTime.Now.ToString("HH:mm"));
                    if (date == DateTime.Today && time >= dt)
                    {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hikaye paylaşım süresi bekleniyor.");
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Saat "+time.ToString("HH:mm")+" paylaşım yapılacaktır.");
                        int count = 0;
                        while (time > DateTime.Now) { count++; if (count % 300 == 0) { lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Paylaşım için bekleniliyor..."); } Thread.Sleep(1000); }
                        if (await UploadStory.StoryUpload(dgvShareMedias.Rows[i].Cells[3].Value.ToString()))
                        {
                            Update update = new Update();
                            update.UpdateData(Convert.ToInt32(dgvShareMedias.Rows[i].Cells[0].Value));
                            lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hikaye paylaşıldı. ");

                        }
                        else {
                            lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hikaye paylaşılamadı. ");
                            lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Sebep : "+ExceptionStatus.Exception);
                        }
                        
                    } else if (date <=DateTime.Today) {
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Paylaşım tarihi geçmiştir, hikaye paylaşımı iptal ediliyor.");
                        Delete delete = new Delete();
                        delete.DeleteData(Convert.ToInt32(dgvShareMedias.Rows[i].Cells[0].Value));
                        lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İptal edilen hikaye : "+ dgvShareMedias.Rows[i].Cells[3].Value.ToString());
                    }
                }
                else
                {
                    lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlem yapılacak kullanıcı paylaşım hesabına ait değildir.");
                }

            }
        }
        private void btnShareStart_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex != -1)
            {
                if (dgvShareMedias.RowCount > 0)
                {
                    Thread t = new Thread(new ThreadStart(ShareStory));
                    t.Start();
                }
            }
            else {
                lstShowProcess.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hikaye paylaşım işlemi başlatıldı.");
            }
           
           
        }

        private void cmbFollowType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
