﻿using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using InstamRiseDataProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public static async Task<bool> UnFollowUsers(IInstaApi api, long UserID)
        {
            try
            {
               
                var user = await api.UserProcessor.UnFollowUserAsync(UserID);
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
                var getMediaInfo = await api.UserProcessor.GetUserMediaAsync(getMediaTypesText, PaginationParameters.MaxPagesToLoad(10));
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
                var followerList = await api.UserProcessor.GetUserFollowingAsync(UserName, PaginationParameters.MaxPagesToLoad(10));
                ExceptionStatus.Exception = followerList.Info.Message;
                ExceptionStatus.ResponseType = followerList.Info.ResponseType.ToString();
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
                        if (count > 1000)
                        {
                            break;
                        }
                    }
                    ınstaProfiles = ınstaProfiles.OrderBy(a => Guid.NewGuid()).ToList();
                    return ınstaProfiles;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                ExceptionStatus.Exception = ex.Message;
                return null;
            }

        }
        public static async Task<List<InstaProfile>> Followers(IInstaApi api, string UserName)
        {
            try
            {
                
                List<InstaProfile> ınstaProfiles = new List<InstaProfile>();
                var userID = await api.UserProcessor.GetUserInfoByUsernameAsync(UserName);
                if (userID.Succeeded)
                {
                    var followerList = await api.UserProcessor.GetUserFollowersByIdAsync(userID.Value.Pk, PaginationParameters.MaxPagesToLoad(5));
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
                            if (count > 100)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        ExceptionStatus.Exception = followerList.Info.Message;
                        ExceptionStatus.ResponseType = followerList.Info.ResponseType.ToString();
                        return null;
                    }
                }
                else {
                    ExceptionStatus.Exception = userID.Info.Message;
                    ExceptionStatus.ResponseType = userID.Info.ResponseType.ToString();
                    return null;
                }
                

                ınstaProfiles = ınstaProfiles.OrderBy(a => Guid.NewGuid()).ToList();
                return ınstaProfiles;
            }
            catch (Exception ex)
            {
                ExceptionStatus.Exception = ex.Message;
                return null;
            }

        }
    }
}
