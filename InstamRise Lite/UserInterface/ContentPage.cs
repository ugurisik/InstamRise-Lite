using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstamRiseDataProcess.Models;
using InstamRiseDataProcess.DataProcess;
using InstamRise_Lite.ApiProcess;
using static InstamRise_Lite.ApiProcess.MultipleAcc;
using InstagramApiSharp.API;

namespace InstamRise_Lite.UserInterface
{
    public partial class ContentPage : UserControl
    {
        public static IInstaApi instaApi;
        string CurrentUserName=null;
        public ContentPage()
        {
            InitializeComponent();
            panel1.Location = new Point(0, 0);
            LoginAcc.LoadUsers(cmbUsers);

            //InstaProfile i = await ProfileDataProcess.ProfileInfo(firstApi, "ali");
            //if (i.ExceptionStatus == null)
            //{

            //}
            
        }

        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Location = new Point(0,0-VScrollBar.Value);
        }

        private void cmbGetListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGetListType.SelectedIndex == 0)
            {
                txtListContent.PlaceholderText = "Kullanıcı adı giriniz...";
            }
            else if (cmbGetListType.SelectedIndex == 1)
            {
                txtListContent.PlaceholderText = "Gönderi linki giriniz...";
            }
            else {
                txtListContent.PlaceholderText = "";
            }
        }

        private void cmbDownloadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDownloadType.SelectedIndex == 0)
            {
                txtDownloadUsername.PlaceholderText = "Kullanıcı adı giriniz...";
            }
            else
            {
                txtListContent.PlaceholderText = "";
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                ExceptionStatus exception = await LoginAcc.MultiLogin(txtUsername.Text, txtPassword.Text, cmbUsers);
                if (exception.Exception == "BadPassword")
                {
                    MessageBox.Show("Şifreniz ya da kullanıcı adınız hatalı");
                }
                else if (exception.Exception == "Success")
                {
                    MessageBox.Show("Başarıyla giriş yapıldı");
                }
                else {
                    MessageBox.Show(exception.Exception);
                }
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentUserName = cmbUsers.SelectedItem.ToString();
            instaApi = ApiList.FirstOrDefault(api => api.GetLoggedUser().LoggedInUser.UserName.ToLower() == CurrentUserName.ToLower());
        }

        private async void btnUnFollow_Click(object sender, EventArgs e)
        {
            List<InstaProfile> ınstaProfiles = await UserDataProcess.Following(instaApi,cmbUsers.SelectedItem.ToString());
            
        }
    }
}
