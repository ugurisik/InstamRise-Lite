using InstamRise.Models;
using InstamRise.UserProcess;
using InstamRiseDataProcess.DataProcess;
using InstamRiseDataProcess.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise.FollowUnFollow
{
    public class Follow
    {
        Random random = new Random();
        bool follow = false;
        int count = 0;
        int processcount = 1;
        ListBox listBox = new ListBox();
        public async void FollowProfileFollowerUsers(string content, int numberFollowTime, bool cbFollowPrivateAcc,ListBox listBox1)
        {
            listBox = listBox1;
            this.listBox.DrawMode = DrawMode.OwnerDrawVariable;
            this.listBox.DrawItem += new DrawItemEventHandler(listBox1_DrawItem);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<InstaProfile> ınstaProfiles = await UserDataProcess.Followers(CurrentUser.GetCurrenUser(), content);
            if (ınstaProfiles != null)
            {
                listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Çekilen yeni kullanıcı sayısı : " + ınstaProfiles.Count.ToString() + " Geçen süre : " + stopwatch.Elapsed.Milliseconds +" milisaniyedir");
                stopwatch.Stop();
                foreach (var item in ınstaProfiles)
                {
                    stopwatch = new Stopwatch();
                    stopwatch.Start();
                    listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlem yapılacak kullanıcı : " + item.UserName);
                    await Task.Delay(777);
                    follow = true;
                    if (cbFollowPrivateAcc)
                    {
                        if (item.Priv == true)
                        {
                            follow = false;
                        }
                    }
                    if (follow)
                    {

                        int rndDelay = random.Next((Convert.ToInt32(numberFollowTime)) / 4 * 3, (Convert.ToInt32(numberFollowTime)) * 2);
                        listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> " + rndDelay + " saniye bekleniyor...");
                        await Task.Delay(rndDelay * 1000);
                        if (await UserDataProcess.FollowUsers(CurrentUser.GetCurrenUser(), item.UserID))
                        {
                            count++;
                            listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Takip edilen kullanıcı sayısı : " + count);
                            await Task.Delay(666);
                            listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Takip edilen kullanıcı : " + item.UserName);
                            await Task.Delay(888);

                        }
                        else
                        {
                            listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Kullanıcı takip edilemedi : " + item.UserName);
                            await Task.Delay(444);
                        }
                    }
                    else
                    {
                        listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Gizli hesap takip edilmedi ");
                        await Task.Delay(444);
                    }
                    listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> " + processcount + ". işlem tamamlandı. Toplam işlem süresi :" + stopwatch.Elapsed.Seconds + " saniyedir.");
                    processcount++;
                    stopwatch.Stop();
                }
            }
            else {
                if (ExceptionStatus.ResponseType == "Spam")
                {
                    listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " -->  Hesabınız spama düştüğünden dolayı işlem başlatılamadı.");
                }
                else {
                    listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " -->  Bir sorun oluştu : "+ ExceptionStatus.Exception);
                }
                stopwatch.Stop();
            }
            
        }
        public async void FollowMediaLikeUsers(string content, int numberFollowTime, bool cbFollowPrivateAcc, ListBox listBox1)
        {
            listBox = listBox1;
            this.listBox.DrawMode = DrawMode.OwnerDrawVariable;
            this.listBox.DrawItem += new DrawItemEventHandler(listBox1_DrawItem);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<InstaProfile> ınstaProfiles = await MediaDataProcess.getMediaLikers(CurrentUser.GetCurrenUser(), content);
            listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Çekilen yeni kullanıcı sayısı : " + ınstaProfiles.Count.ToString() + " Geçen süre : " + stopwatch.Elapsed.Milliseconds+" milisaniyedir");
            stopwatch.Stop();
            foreach (var item in ınstaProfiles)
            {
                stopwatch = new Stopwatch();
                stopwatch.Start();
                listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> İşlem yapılacak kullanıcı : " + item.UserName);
                await Task.Delay(777);
                follow = true;
                if (cbFollowPrivateAcc)
                {
                    if (item.Priv == true)
                    {
                        follow = false;
                    }
                }
                if (follow)
                {
                    int rndDelay = random.Next((Convert.ToInt32(numberFollowTime)) / 4 * 3, (Convert.ToInt32(numberFollowTime)) * 2);
                    listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> " + rndDelay + " saniye bekleniyor...");
                    await Task.Delay(rndDelay * 1000);
                    if (await UserDataProcess.FollowUsers(CurrentUser.GetCurrenUser(), item.UserID))
                    {
                        count++;
                        listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Takip edilen kullanıcı sayısı : " + count);
                        await Task.Delay(666);
                        listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Takip edilen kullanıcı : " + item.UserName);
                        await Task.Delay(888);
                    }
                    else
                    {
                        listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Kullanıcı takip edilemedi : " + item.UserName);
                        await Task.Delay(444);
                    }
                }
                else {
                    listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> Gizli hesap takip edilmedi ");
                    await Task.Delay(444);
                }
                listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") + " --> " + processcount + ". işlem tamamlandı. Toplam işlem süresi :" + stopwatch.Elapsed.Seconds + " saniyedir.");
                processcount++;
                stopwatch.Stop();
              
            }
        }

        void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            Color c = Color.FromArgb(254, 65, 60);
            e.Graphics.DrawString(this.listBox.Items[e.Index].ToString(), new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), new SolidBrush(c), e.Bounds);
        }


    }
}
