using InstagramApiSharp.API;
using InstamRiseBusiness.LoginProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRiseBusiness.UserProcess
{
    public class CurrentUser
    {
        public static IInstaApi instaApi;
        public static void SetCurrentUser(string username) {
            instaApi = Helper.ApiList.FirstOrDefault(api => api.GetLoggedUser().LoggedInUser.UserName.ToLower() == username.ToLower());
        }
        public static IInstaApi GetCurrenUser() {
            return instaApi;
        }
    }
}
