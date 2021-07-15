using InstagramApiSharp.API;
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
    }
}
