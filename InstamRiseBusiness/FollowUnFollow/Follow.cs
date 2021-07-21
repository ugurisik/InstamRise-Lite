using InstamRiseBusiness.UserProcess;
using InstamRiseDataProcess.DataProcess;
using InstamRiseDataProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRiseBusiness.FollowUnFollow
{
    public class Follow
    {
        Random random = new Random();
        bool follow= false;
        int count = 0;
        public async void FollowProfileFollowerUsers(string content,int numberFollowTime,bool cbFollowPrivateAcc) {
            
            List<InstaProfile> ınstaProfiles = await UserDataProcess.Followers(CurrentUser.GetCurrenUser(), content);
            //lblGetListCount.Text = "Çekilen yeni kullanıcı sayısı : " + ınstaProfiles.Count.ToString();
            foreach (var item in ınstaProfiles)
            {
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
                    await Task.Delay(rndDelay * 1000);
                    if (await UserDataProcess.FollowUsers(CurrentUser.GetCurrenUser(), item.UserID))
                    {
                        count++;
                        //lblFollowCount.Text = "Takip Edilen Kullanıcı Sayısı : " + count;
                        //lblFollowUser.Text = "Takip Edilen Kullanıcı : " + item.UserName;
                    }
                    else
                    {
                        //lblUnFollowUser.Text = "Kullanıcı Takip Edilemedi : " + item.UserName;
                    }
                }
            }
        }
        public async void FollowMediaLikeUsers(string content, int numberFollowTime, bool cbFollowPrivateAcc)
        {
            
            List<InstaProfile> ınstaProfiles = await MediaDataProcess.getMediaLikers(CurrentUser.GetCurrenUser(), content);
            //lblGetListCount.Text = "Çekilen yeni kullanıcı sayısı : " + ınstaProfiles.Count.ToString();
            foreach (var item in ınstaProfiles)
            {
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
                    await Task.Delay(rndDelay * 1000);
                    if (await UserDataProcess.FollowUsers(CurrentUser.GetCurrenUser(), item.UserID))
                    {
                        count++;
                        //lblFollowCount.Text = "Takip Edilen Kullanıcı Sayısı : " + count;
                        //lblFollowUser.Text = "Takip Edilen Kullanıcı : " + item.UserName;
                    }
                    else
                    {
                        //lblFollowUser.Text = "Kullanıcı Takip Edilemedi : " + item.UserName;
                    }
                }
            }
        }

        public int GetCountNumber() {
            return count;
        }
    }
}
