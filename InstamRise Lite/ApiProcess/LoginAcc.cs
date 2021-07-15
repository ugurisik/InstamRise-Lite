using InstagramApiSharp.Classes.SessionHandlers;
using InstamRiseDataProcess.Models;
using System.Threading.Tasks;
using static InstamRise_Lite.ApiProcess.MultipleAcc;
namespace InstamRise_Lite.ApiProcess
{
    class LoginAcc
    {
        public async Task<ExceptionStatus> MultiLogin(string username, string password, Guna.UI2.WinForms.Guna2ComboBox cmbUsers)
        {
            ExceptionStatus exceptionStatus = new ExceptionStatus();
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
                    LoadUsers(cmbUsers);
                    exceptionStatus.Exception = loginResult.Value.ToString();
                    return exceptionStatus;
                }
                else
                {
                    if (loginResult.Value.ToString() == "BadPassword")
                    {
                        exceptionStatus.Exception = loginResult.Value.ToString();
                    }
                    else {
                        exceptionStatus.Exception = loginResult.Info.Message;
                    }
                 
                    return exceptionStatus;
                }
            }
            catch (System.Exception ex )
            {
                exceptionStatus.Exception = ex.Message;
                return exceptionStatus;
            }
        }
        public async void LoadUsers(Guna.UI2.WinForms.Guna2ComboBox cmbUsers)
        {
            cmbUsers.DataSource = null;
            LoadSessions();
            await Task.Delay(1500);
            cmbUsers.DataSource = LoggedInUsers;
            cmbUsers.SelectedIndex = 0;
        }
    }
}
