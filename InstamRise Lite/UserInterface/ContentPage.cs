using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise_Lite.UserInterface
{
    public partial class ContentPage : UserControl
    {
        public ContentPage()
        {
            InitializeComponent();
            panel1.Location = new Point(0, 0);
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
    }
}
