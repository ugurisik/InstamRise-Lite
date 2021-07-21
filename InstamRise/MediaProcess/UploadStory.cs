using InstagramApiSharp.Classes.Models;
using InstamRise.UserProcess;
using InstamRiseDataProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRise.MediaProcess
{
    public class UploadStory
    {
        public static async Task<bool> StoryUpload(string Path)
        {
            try
            {
                
                var image = new InstaImage { Uri = Path };
                var uploadStory = await CurrentUser.GetCurrenUser().StoryProcessor.UploadStoryPhotoAsync(image, "");
                if (uploadStory.Succeeded)
                {
                    ExceptionStatus.Exception = uploadStory.Info.Message;
                    return true;
                }
                else
                {
                    ExceptionStatus.Exception = uploadStory.Info.Message;
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
