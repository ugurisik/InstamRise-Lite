using InstamRise_Lite.Design;
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
    public partial class LicencePage : UserControl
    {
        public LicencePage()
        {
            InitializeComponent();
        }

        private void btnLicenceControl_Click(object sender, EventArgs e)
        {
            ContentPage contentPage = new ContentPage();
            new ChangeContainerPanel(contentPage, Main.panel);
        }
    }
}
