using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise_Lite.Design
{
    class ChangeContainerPanel
    {
        public ChangeContainerPanel(UserControl userControl, Guna.UI2.WinForms.Guna2Panel panel) {
            panel.Controls.Clear();
            panel.BringToFront();
            panel.Controls.Add(userControl);
        }
    }
}
