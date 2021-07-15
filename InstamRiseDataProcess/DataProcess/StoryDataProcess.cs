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
        public static async Task<bool> UploadStory(IInstaApi api, Uri URL)
        {
            try
            {
                var image = new InstaImage { Uri = URL.ToString() };
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
