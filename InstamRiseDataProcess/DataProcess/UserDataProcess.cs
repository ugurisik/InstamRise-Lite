using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using InstamRiseDataProcess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstamRiseDataProcess.DataProcess
{
    public class UserDataProcess
    {
        public static async Task<bool> FollowUsers(IInstaApi api, long UserID)
        {
            try
            {
                var user = await api.UserProcessor.FollowUserAsync(UserID);
                if (user.Succeeded)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static async Task<bool> UnFollowUsers(IInstaApi api, string UserName)
        {
            try
            {
                var getuserID = await api.UserProcessor.GetUserAsync(UserName);
                var user = await api.UserProcessor.UnFollowUserAsync(getuserID.Value.Pk);
                if (!user.Succeeded)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static async Task<List<InstaMedia>> Media(IInstaApi api, string getMediaTypesText)
        {
            try
            {
                var getMediaInfo = await api.UserProcessor.GetUserMediaAsync(getMediaTypesText, PaginationParameters.MaxPagesToLoad(5));
                if (getMediaInfo.Succeeded)
                {
                    return getMediaInfo.Value;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public static async Task<List<InstaProfile>> Following(IInstaApi api, string UserName)
        {
            try
            {
                List<InstaProfile> ınstaProfiles = new List<InstaProfile>();
                var followerList = await api.UserProcessor.GetUserFollowingAsync(UserName, PaginationParameters.MaxPagesToLoad(5));
                if (followerList.Succeeded)
                {
                    int count = 0;
                    foreach (var followers in followerList.Value)
                    {
                        InstaProfile ınstaProfile = new InstaProfile();
                        ınstaProfile.UserID = followers.Pk;
                        ınstaProfile.UserName = followers.UserName;
                        ınstaProfile.Priv = followers.IsPrivate;

                        ınstaProfiles.Add(ınstaProfile);
                        count++;
                        if (count > 5000)
                        {
                            break;
                        }
                    }
                    return ınstaProfiles;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}
