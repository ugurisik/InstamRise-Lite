using InstagramApiSharp.Classes.Models;
using InstamRise.Models;
using InstamRise.UserProcess;
using InstamRiseDataProcess.DataProcess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise.MediaProcess
{
    public class DownloadMedia
    {
        public string MediaPathDirectory = @"C:\InstamRise\Lite\Indirilenler";
        public string UserName = "";
        ListBox listbox = new ListBox();
        public async Task<List<MediaDownload>> GetMediaInProfile(string username) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int videoCount = 0, imageCount = 0;
            List<MediaDownload> mediaDownload = new List<MediaDownload>();

            MediaPath.MediaPathDirectory = MediaPathDirectory;
            MediaPath.MediaPathVideo = MediaPathDirectory + "\\" + username + "\\Video";
            MediaPath.MediaPathImage = MediaPathDirectory + "\\" + username + "\\Resim";
            
            DirectoryProcess.CreateMediaPath.CreatePath(MediaPath.MediaPathDirectory);
            listbox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hesabın gönderileri getiriliyor... ");
            await Task.Delay(777);
            List<InstaMedia> ınstaMedias = await UserDataProcess.Media(CurrentUser.GetCurrenUser(), username);
            listbox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Hesabın gönderileri getirildi. Getirilen gönderi adedi : "+ınstaMedias.Count);
            await Task.Delay(777);
            DirectoryProcess.CreateMediaPath.CreateDownloadSecondPath(username);

            listbox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Video klasörü kuruldu : "+ MediaPath.MediaPathVideo);
            await Task.Delay(777);
            listbox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Resim klasörü kuruldu : " + MediaPath.MediaPathImage);
            await Task.Delay(1000);
            listbox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Gönderi indirme işlemi başlatılıyor... ");
            await Task.Delay(888);
            foreach (var medias in ınstaMedias)
            {
                MediaDownload media = new MediaDownload();
                media.isVideo = false;
                foreach (var item in medias.Videos)
                {
                    videoCount++;
                    media.VideoUrL = item.Uri;
                    media.isVideo = true;
                    await Task.Delay(2);
                    break;
                }
                foreach (var item in medias.Images)
                {
                    imageCount++;
                    media.ImageURL = item.Uri;
                    break;
                }
                media.VideoCount = videoCount;
                media.ImageCount = imageCount;
                if (medias.Caption != null)
                {
                    media.MediaCaption = medias.Caption.Text;
                }
                else {
                    media.MediaCaption = " ";
                }
               
                mediaDownload.Add(media);
            }
            return mediaDownload;
        }
        public async void Download() {
            List<MediaDownload> mediaDownloads = await GetMediaInProfile(UserName);
            listbox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İndirme işlemi başladı ");
            foreach (var media in mediaDownloads)
            {
                if (media.VideoUrL != null || media.ImageURL != null)
                {
                    if (media.isVideo)
                    {
                        using (WebClient wcVideo = new WebClient())
                        {
                            wcVideo.DownloadFile(media.VideoUrL, MediaPath.MediaPathVideo + @"\" + media.VideoCount + "_Video.mp4");
                            /* wcVideo.DownloadFileAsync(
                                 new System.Uri(media.VideoUrL), @"" + MediaPath.MediaPathVideo + @"\" + media.VideoCount + "_Video.mp4"
                             );*/

                        }
                        using (WebClient wc = new WebClient())
                        {
                            wc.DownloadFile(media.ImageURL, MediaPath.MediaPathVideo + @"\" + media.VideoCount + "_VideoTumbnail.jpg");
                            //  wc.DownloadFileAsync(new System.Uri(media.ImageURL), @"" + MediaPath.MediaPathVideo + @"\" + media.VideoCount + "_VideoTumbnail.jpg");
                        }
                        AddMediaCaption(@"" + MediaPath.MediaPathVideo + @"\" + media.VideoCount + "_Aciklama.txt", media.MediaCaption);

                    }
                    else
                    {
                        using (WebClient wcImage = new WebClient())
                        {
                            wcImage.DownloadFile(media.ImageURL, MediaPath.MediaPathImage + @"\" + media.ImageCount + "_Resim.jpg");
                            //  wcImage.DownloadFileAsync(new System.Uri(media.ImageURL), @"" + MediaPath.MediaPathImage + @"\" + media.ImageCount + "_Resim.jpg");

                        }
                        AddMediaCaption(@"" + MediaPath.MediaPathImage + @"\" + media.ImageCount + "_Aciklama.txt", media.MediaCaption);
                    }
                }
            }
            listbox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İndirme işlemi tamamlandı ");
        }
        public void DownloadMediaInProfile(string username,ListBox listBox_) {

            this.listbox.DrawMode = DrawMode.OwnerDrawVariable;
            this.listbox.DrawItem += new DrawItemEventHandler(listBox1_DrawItem);

            Thread t = new Thread(new ThreadStart(Download));
            t.Start();
            UserName = username;
            this.listbox = listBox_;
        }
        void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            Color c = Color.FromArgb(52, 44, 47);
            e.Graphics.DrawString(this.listbox.Items[e.Index].ToString(), new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), new SolidBrush(c), e.Bounds);
        }
        public void AddMediaCaption(string path, string caption) {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(caption);
                }
            }
        }
    }
}
