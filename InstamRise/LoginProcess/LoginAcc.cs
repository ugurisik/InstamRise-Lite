using InstagramApiSharp.Classes.SessionHandlers;
using InstamRiseDataProcess.Models;
using System.Threading.Tasks;
using static InstamRise.LoginProcess.MultipleAcc;
namespace InstamRise.LoginProcess
{
    public class LoginAcc
    {
        public static async Task<bool> MultiLogin(string username, string password, Guna.UI2.WinForms.Guna2ComboBox cmbUsers)
        {

            try
            {

                var userN = username.ToLower();
                var api = BuildApi(userN, password);
                var sessionHandler = new FileSessionHandler { FilePath = userN.GetAccountPath(), InstaApi = api };
                api.SessionHandler = sessionHandler;
                var loginResult = await api.LoginAsync();

                if (loginResult.Succeeded)
                {
                    LoggedInUsers.Add(api.GetLoggedUser().LoggedInUser.UserName.ToLower());
                    ApiList.Add(api);
                    api.SessionHandler.Save();
                    await LoadUsers(cmbUsers);
                    ExceptionStatus.Exception = loginResult.Value.ToString();
                    return true;
                }
                else
                {
                    if (loginResult.Value.ToString() == "BadPassword")
                    {
                        ExceptionStatus.Exception = loginResult.Value.ToString();
                    }
                    else
                    {
                        ExceptionStatus.Exception = loginResult.Info.Message;
                    }

                    return false;
                }
            }
            catch (System.Exception ex)
            {
                ExceptionStatus.Exception = ex.Message;
                return false;
            }
        }
        public static async Task LoadUsers(Guna.UI2.WinForms.Guna2ComboBox cmbUsers)
        {
            cmbUsers.DataSource = null;
            LoadSessions();
            await Task.Delay(1500);
            cmbUsers.DataSource = LoggedInUsers;
            if (cmbUsers.Items.Count > 0)
            {
                cmbUsers.SelectedIndex = 0;
            }

        }
    }
}
