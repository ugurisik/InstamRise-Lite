using InstagramApiSharp.API;
using InstamRiseDataProcess.Models;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;


namespace InstamRiseDataProcess.DataProcess
{
    public class ProfileDataProcess
    {
        public static async Task<InstaProfile> ProfileInfo(IInstaApi api, string UserName)
        {
            try
            {
                InstaProfile ınstaProfile = new InstaProfile();
                string PictureURL = "";
                var getuserID = await api.UserProcessor.GetUserAsync(UserName);
                if (getuserID.Succeeded)
                {
                    ınstaProfile.ExceptionStatus = null;
                    ınstaProfile.UserID = getuserID.Value.Pk;

                    var user = await api.UserProcessor.GetFullUserInfoAsync(ınstaProfile.UserID);
                    if (user.Succeeded)
                    {
                        ınstaProfile.Biographi = user.Value.UserDetail.Biography;
                        ınstaProfile.UserName = user.Value.UserDetail.Username;
                        ınstaProfile.Followers = user.Value.UserDetail.FollowerCount.ToString();
                        ınstaProfile.Following = user.Value.UserDetail.FollowingCount.ToString();
                        ınstaProfile.Postcount = user.Value.UserDetail.MediaCount.ToString();
                        ınstaProfile.Priv = user.Value.UserDetail.IsPrivate;
                        ınstaProfile.Verify = user.Value.UserDetail.IsVerified;
                        ınstaProfile.Fullname = user.Value.UserDetail.FullName;
                        PictureURL = user.Value.UserDetail.HdProfilePicUrlInfo.Uri;
                    }
                    else
                    {
                        var secondResult = await api.UserProcessor.GetUserInfoByIdAsync(ınstaProfile.UserID);
                        if (secondResult.Succeeded)
                        {
                            ınstaProfile.Biographi = secondResult.Value.Biography;
                            ınstaProfile.UserName = secondResult.Value.Username;
                            ınstaProfile.Followers = secondResult.Value.FollowerCount.ToString();
                            ınstaProfile.Following = secondResult.Value.FollowingCount.ToString();
                            ınstaProfile.Postcount = secondResult.Value.MediaCount.ToString();
                            ınstaProfile.Priv = secondResult.Value.IsPrivate;
                            ınstaProfile.Verify = secondResult.Value.IsVerified;
                            ınstaProfile.Fullname = secondResult.Value.FullName;
                            PictureURL = secondResult.Value.HdProfilePicUrlInfo.Uri;
                        }
                        ınstaProfile.ExceptionStatus = user.Info.Message;
                    }
                }
                else
                {
                    ınstaProfile.ExceptionStatus = getuserID.Info.Message;
                }

                if (!string.IsNullOrEmpty(PictureURL))
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(PictureURL);
                    MemoryStream ms = new MemoryStream(bytes);
                    ınstaProfile.Picture = Image.FromStream(ms);
                }

                return ınstaProfile;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
