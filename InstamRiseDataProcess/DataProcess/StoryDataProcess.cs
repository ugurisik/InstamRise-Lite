using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRiseDataProcess.DataProcess
{
    public class StoryDataProcess
    {
        public static async Task<bool> UploadStory(IInstaApi api, string URL)
        {
            try
            {
                var image = new InstaImage { Uri = URL };
                var uploadStory = await api.StoryProcessor.UploadStoryPhotoAsync(image, "");
                if (uploadStory.Succeeded)
                {
                    return true;
                }
                else {
                    return false;
                }
               
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
