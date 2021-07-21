using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise.UserInterface
{
    public partial class LicencePage : UserControl
    {
        public LicencePage()
        {
            InitializeComponent();
        }

        private void LicencePage_Load(object sender, EventArgs e)
        {
            foreach (var item in lstAnnouncement.Items)
            {
                var i = item.ToString().Length;
            }
        }

        private void btnLicenceControl_Click(object sender, EventArgs e)
        {
            ContentPage contentPage = new ContentPage();
            InstamRiseLite.guna2Panel.Controls.Clear();
            InstamRiseLite.guna2Panel.BringToFront();
            InstamRiseLite.guna2Panel.Controls.Add(contentPage);
        
        }
    }
}
