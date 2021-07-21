using InstagramApiSharp.Classes.SessionHandlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRiseBusiness.LoginProcess
{
    static class Helper
    {
        public static InstaApiList ApiList { get; private set; } = new InstaApiList();
        public const string AccountPathDirectory = @"C:\InstamRise\Lite\Hesaplar";
        public const string SessionExtension = ".InstamRiseLite";
        public static void CreateAccountDirectory()
        {
            if (!Directory.Exists(AccountPathDirectory))
                Directory.CreateDirectory(AccountPathDirectory);
        }
        public static string GetAccountPath(this string username) => $"{AccountPathDirectory}/{username}{SessionExtension}";
        static public void LoadSessions()
        {
            ApiList = new InstaApiList();
            if (Directory.Exists(Helper.AccountPathDirectory))
            {
                var files = Directory.GetFiles(Helper.AccountPathDirectory);
                if (files?.Length > 0)
                {
                    foreach (var path in files)
                    {
                        if (Path.GetExtension(path) == Helper.SessionExtension)
                        {
                            // load session!
                            var api = MultipleAcc.BuildApi();
                            var sessionHandler = new FileSessionHandler { FilePath = path, InstaApi = api };

                            api.SessionHandler = sessionHandler;

                            api.SessionHandler.Load();
                            if (api.IsUserAuthenticated)
                            {
                                MultipleAcc.LoggedInUsers.Clear();
                                MultipleAcc.LoggedInUsers.Add(api.GetLoggedUser().LoggedInUser.UserName.ToLower());
                                ApiList.Add(api);

                            }
                        }
                    }
                }
            }
            else
                Directory.CreateDirectory(Helper.AccountPathDirectory);
        }
        static public void SaveSessions()
        {
            Helper.CreateAccountDirectory();
            if (ApiList == null)
                return;
            if (ApiList.Any())
            {
                foreach (var instaApi in ApiList)
                {
                    var state = instaApi.GetStateDataAsStream();
                    var path = Path.Combine(Helper.AccountPathDirectory, $"{instaApi.GetLoggedUser().UserName}{Helper.SessionExtension}");
                    using (var fileStream = File.Create(path))
                    {
                        state.Seek(0, SeekOrigin.Begin);
                        state.CopyTo(fileStream);
                    }
                }
            }
        }
    }
}
