using InstamRiseDataProcess.Models;
using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace InstamRiseDataProcess.DataProcess
{
    public class MediaDataProcess
    {
        public static async Task<List<InstaProfile>> getMediaLikers(IInstaApi api, string URL)
        {
            try
            {
                List<InstaProfile> ınstaProfiles = new List<InstaProfile>();
                int count = 0;
                var mediaID = await api.MediaProcessor.GetMediaIdFromUrlAsync(new Uri(URL));
                var likerList = await api.MediaProcessor.GetMediaLikersAsync(mediaID.Value);
                foreach (var likers in likerList.Value)
                {
                    InstaProfile ınstaProfile = new InstaProfile();
                    ınstaProfile.UserID = likers.Pk;
                    ınstaProfile.UserName = likers.UserName;
                    ınstaProfile.Priv = likers.IsPrivate;
                    ınstaProfiles.Add(ınstaProfile);
                    count++;
                    if (count > 100)
                    {
                        break;
                    }
                }
                ınstaProfiles = ınstaProfiles.OrderBy(a => Guid.NewGuid()).ToList();
                return ınstaProfiles;
            }
            catch (Exception)
            {
                return null;
            }
        }

     
    }
}
