using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstamRiseDataProcess.Models;
using InstamRiseDataProcess.DataProcess;
using InstamRise_Lite.ApiProcess;
using static InstamRise_Lite.ApiProcess.MultipleAcc;
using InstagramApiSharp.API;
using System.Threading;
using InstagramApiSharp.Classes.Models;
using System.IO;
using System.Net;

namespace InstamRise_Lite.UserInterface
{
    public partial class ContentPage : UserControl
    {
        public static IInstaApi instaApi;
        string CurrentUserName=null;
        public string MediaPathDirectory = @"C:\InstamRise\Lite\Indirilenler";
        public ContentPage()
        {
            InitializeComponent();
            panel1.Location = new Point(0, 0);
            LoginAcc.LoadUsers(cmbUsers);

            //InstaProfile i = await ProfileDataProcess.ProfileInfo(firstApi, "ali");
            //if (i.ExceptionStatus == null)
            //{

            //}
            
        }

        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Location = new Point(0,0-VScrollBar.Value);
        }

        private void cmbGetListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGetListType.SelectedIndex == 0)
            {
                txtListContent.PlaceholderText = "Kullanıcı adı giriniz...";
            }
            else if (cmbGetListType.SelectedIndex == 1)
            {
                txtListContent.PlaceholderText = "Gönderi linki giriniz...";
            }
            else {
                txtListContent.PlaceholderText = "";
            }
        }

        private void cmbDownloadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDownloadType.SelectedIndex == 0)
            {
                txtDownloadUsername.PlaceholderText = "Kullanıcı adı giriniz...";
            }
            else
            {
                txtListContent.PlaceholderText = "";
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                ExceptionStatus exception = await LoginAcc.MultiLogin(txtUsername.Text, txtPassword.Text, cmbUsers);
                if (exception.Exception == "BadPassword")
                {
                    MessageBox.Show("Şifreniz ya da kullanıcı adınız hatalı");
                }
                else if (exception.Exception == "Success")
                {
                    MessageBox.Show("Başarıyla giriş yapıldı");
                }
                else {
                    MessageBox.Show(exception.Exception);
                }
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentUserName = cmbUsers.SelectedItem.ToString();
            instaApi = ApiList.FirstOrDefault(api => api.GetLoggedUser().LoggedInUser.UserName.ToLower() == CurrentUserName.ToLower());
        }







        private async void btnUnFollow_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex != -1)
            {
                await UnFollowUser();
            }
            else {
                MessageBox.Show("İşlem yapılacak hesap seçiniz");
            }
           
            
        }
        public async Task UnFollowUser() {
            int count = 0;
            Random random = new Random();
            List<InstaProfile> ınstaProfiles = await UserDataProcess.Following(instaApi, cmbUsers.SelectedItem.ToString());
            foreach (var item in ınstaProfiles)
            {
                int rndDelay = random.Next((Convert.ToInt32(numberUnFollowTime.Value)) / 4 * 3, (Convert.ToInt32(numberUnFollowTime.Value)) * 2);
                await Task.Delay(rndDelay*1000);
                if (await UserDataProcess.UnFollowUsers(instaApi, item.UserID))
                {
                    count++;
                    lblUnFollowCount.Text = "Çıkarılan Kullanıcı Sayısı : " + count;
                    lblUnFollowUser.Text = "Çıkarılan Kullanıcı : " + item.UserName;
                }else {
                    lblUnFollowUser.Text = "Kullanıcı Çıkarılamadı : " + item.UserName;
                }
               

            }
        }
        public async Task FollowUser() {
            bool follow = true;
            int count = 0;
            Random random = new Random();
            if (cmbGetListType.SelectedIndex == 0)
            {
                List<InstaProfile> ınstaProfiles = await UserDataProcess.Followers(instaApi, txtListContent.Text);
                lblGetListCount.Text = "Çekilen yeni kullanıcı sayısı : " + ınstaProfiles.Count.ToString();
                foreach (var item in ınstaProfiles)
                {
                    follow = true;
                    if (cbFollowPrivateAcc.Checked)
                    {
                        if (item.Priv==true)
                        {
                            follow = false;
                        }
                    }
                    if (follow)
                    {
                        int rndDelay = random.Next((Convert.ToInt32(numberFollowTime.Value)) / 4 * 3, (Convert.ToInt32(numberFollowTime.Value)) * 2);
                        await Task.Delay(rndDelay * 1000);
                        if (await UserDataProcess.FollowUsers(instaApi, item.UserID))
                        {
                            count++;
                            lblFollowCount.Text = "Takip Edilen Kullanıcı Sayısı : " + count;
                            lblFollowUser.Text = "Takip Edilen Kullanıcı : " + item.UserName;
                        }
                        else
                        {
                            lblUnFollowUser.Text = "Kullanıcı Takip Edilemedi : " + item.UserName;
                        }
                    }
                }
            }
            else if (cmbGetListType.SelectedIndex == 1) {
                List<InstaProfile> ınstaProfiles = await MediaDataProcess.getMediaLikers(instaApi, txtListContent.Text);
                lblGetListCount.Text = "Çekilen yeni kullanıcı sayısı : " + ınstaProfiles.Count.ToString();
                foreach (var item in ınstaProfiles)
                {
                    follow = true;
                    if (cbFollowPrivateAcc.Checked)
                    {
                        if (item.Priv == true)
                        {
                            follow = false;
                        }
                    }
                    if (follow)
                    {
                        int rndDelay = random.Next((Convert.ToInt32(numberFollowTime.Value)) / 4 * 3, (Convert.ToInt32(numberFollowTime.Value)) * 2);
                        await Task.Delay(rndDelay * 1000);
                        if (await UserDataProcess.FollowUsers(instaApi, item.UserID))
                        {
                            count++;
                            lblFollowCount.Text = "Takip Edilen Kullanıcı Sayısı : " + count;
                            lblFollowUser.Text = "Takip Edilen Kullanıcı : " + item.UserName;
                        }
                        else
                        {
                            lblUnFollowUser.Text = "Kullanıcı Takip Edilemedi : " + item.UserName;
                        }
                    }
                }
            }
        }
        public async Task GetMedia() {

            if (!Directory.Exists(MediaPathDirectory))
                Directory.CreateDirectory(MediaPathDirectory);
            bool isVideo = false;
            List<string> vs = new List<string>();
            string videoPath = "", imagePath = "";

            List<InstaMedia> ınstaMedias = await UserDataProcess.Media(instaApi,txtDownloadUsername.Text);
            videoPath = MediaPathDirectory + "\\" + txtDownloadUsername.Text + "\\Video";
            imagePath = MediaPathDirectory + "\\" + txtDownloadUsername.Text + "\\Resim";
            for (int i = 2; i < 50; i++)
            {
                if (!Directory.Exists(videoPath))
                {
                    Directory.CreateDirectory(videoPath);
                    break;
                }
                else
                {
                    videoPath = MediaPathDirectory + "\\" + txtDownloadUsername.Text + "_" + i + "_\\Video";
                    imagePath = MediaPathDirectory + "\\" + txtDownloadUsername.Text + "_" + i + "_\\Resim";
                    if (!Directory.Exists(videoPath))
                    {
                        Directory.CreateDirectory(videoPath);
                        break;
                    }
                }
            }
            if (!Directory.Exists(imagePath))
                Directory.CreateDirectory(imagePath);
            int videoCount = 0, imageCount = 0;
            foreach (var medias in ınstaMedias)
            {

                isVideo = false;
                foreach (var item in medias.Videos)
                {
                    using (WebClient wcVideo = new WebClient())
                    {
                        wcVideo.DownloadFileAsync(
                            new System.Uri(item.Uri), @"" + videoPath + @"\" + videoCount + "_Video.mp4"
                        );

                    }
                    await Task.Delay(2);
                    isVideo = true;
                    break;
                }


                foreach (var item in medias.Images)
                {
                    if (isVideo)
                    {
                        using (WebClient wc = new WebClient())
                        {
                            wc.DownloadFileAsync(new System.Uri(item.Uri), @"" + videoPath + @"\" + videoCount + "_VideoTumbnail.jpg");
                        }
                        addMediaCaptionforDownloadPosts(@"" + videoPath + @"\" + videoCount + "_Aciklama.txt", medias.Caption.Text);
                        videoCount++;
                    }
                    else
                    {
                        using (WebClient wcImage = new WebClient())
                        {
                            wcImage.DownloadFileAsync(new System.Uri(item.Uri), @"" + imagePath + @"\" + imageCount + "_Resim.jpg");

                        }
                        addMediaCaptionforDownloadPosts(@"" + imagePath + @"\" + imageCount + "_Aciklama.txt", medias.Caption.Text);
                        imageCount++;
                    }
                    break;
                }
                

            }
        }
        public void addMediaCaptionforDownloadPosts(string path,string caption) {
            
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(caption);
                }
            }
        }

        public string ChoisePicture() {
            string returnPath = "";
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Dosyaları (*.jpg)|*.jpg";//|MP4 Dosyaları (*.mp4)|*.mp4
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Resim Seçiniz...";
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                returnPath = file.FileName; 
            }
            return returnPath;
        }






        private async void btnFollow_Click(object sender, EventArgs e)
        {
            if (cmbGetListType.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(txtListContent.Text))
                {
                    await FollowUser();
                }
                else
                {
                    MessageBox.Show("Lütfen boş alanı doldurunuz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen takip edilecek liste türü seçiniz");
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (cmbDownloadType.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(txtDownloadUsername.Text))
                {
                   await GetMedia();
                }
                else
                {
                    MessageBox.Show("Lütfen boş alanı doldurunuz");
                }
            }
            else {
                MessageBox.Show("Lütfen indirme türünü seçiniz");
            }
        }
    }
}
