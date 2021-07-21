using InstamRise.UserProcess;
using InstamRiseDataProcess.DataProcess;
using InstamRiseDataProcess.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise.FollowUnFollow
{
    public class UnFollow
    {
        int count = 0, processcount=0;
        Random random = new Random();
        ListBox listBox = new ListBox();
        public async void UnFollowUserinFollowingUsers(string FollowingUserName, int numberUnFollowTime, ListBox listBox1) {
            listBox = listBox1;
            this.listBox.DrawMode = DrawMode.OwnerDrawVariable;
            this.listBox.DrawItem += new DrawItemEventHandler(listBox1_DrawItem);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<InstaProfile> ınstaProfiles = await UserDataProcess.Following(CurrentUser.GetCurrenUser(), FollowingUserName);
            if (ınstaProfiles != null)
            {
                listBox.Items.Insert(0, DateTime.Now.ToString("hh:mm") + " --> Çekilen yeni kullanıcı sayısı : " + ınstaProfiles.Count.ToString() + " Geçen süre : " + stopwatch.Elapsed.Milliseconds+ " milisaniyedir.");
                stopwatch.Stop();
                foreach (var item in ınstaProfiles)
                {
                    stopwatch = new Stopwatch();
                    stopwatch.Start();
                    listBox.Items.Insert(0, DateTime.Now.ToString("hh:mm") + " --> İşlem yapılacak kullanıcı : " + item.UserName);
                    await Task.Delay(777);
                    int rndDelay = random.Next(numberUnFollowTime / 4 * 3, numberUnFollowTime * 2);
                    listBox.Items.Insert(0, DateTime.Now.ToString("hh:mm") + " --> " + rndDelay + " saniye bekleniyor...");
                    await Task.Delay(rndDelay * 1000);
                    if (await UserDataProcess.UnFollowUsers(CurrentUser.GetCurrenUser(), item.UserID))
                    {
                        count++;
                        listBox.Items.Insert(0, DateTime.Now.ToString("hh:mm") + " --> Çıkarılan kullanıcı sayısı : " + count );
                        await Task.Delay(666);
                        listBox.Items.Insert(0, DateTime.Now.ToString("hh:mm") + " --> Çıkarılan kullanıcı : " + item.UserName);
                        await Task.Delay(888);
                    }
                    else
                    {
                        listBox.Items.Insert(0, DateTime.Now.ToString("hh:mm") + " --> Kullanıcı çıkarılamadı : " + item.UserName );
                        await Task.Delay(444);
                    }
                    listBox.Items.Insert(0, DateTime.Now.ToString("hh:mm") + " --> " + processcount + ". işlem tamamlandı. Toplam işlem süresi :" + stopwatch.Elapsed.Seconds + " saniyedir.");
                    processcount++;
                    stopwatch.Stop();
                }
            }
               
        }
        void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            Color c = Color.FromArgb(64, 60, 46);
            e.Graphics.DrawString(this.listBox.Items[e.Index].ToString(), new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), new SolidBrush(c), e.Bounds);
        }
    }
}
