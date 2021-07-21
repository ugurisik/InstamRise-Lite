using InstamRise.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise
{
    public partial class InstamRise : Form
    {
        public static Guna.UI2.WinForms.Guna2Button btnContent_;
        public InstamRise()
        {
            InitializeComponent();
            btnContent_ = btnContent;
            guna2AnimateWindow1.SetAnimateWindow(this,Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE,1000);
            btnContent_.Visible = false;

            Home home = new Home();
            pnlContainer.Controls.Clear();
            pnlContainer.BringToFront();
            pnlContainer.Controls.Add(home);
        }

        private void btnLicence_Click(object sender, EventArgs e)
        {
            
            Licence licencePage = new Licence();
            pnlContainer.Controls.Clear();
            pnlContainer.BringToFront();
            pnlContainer.Controls.Add(licencePage);
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            pnlContainer.Controls.Clear();
            pnlContainer.BringToFront();
            pnlContainer.Controls.Add(home);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            Content content = new Content();
            pnlContainer.Controls.Clear();
            pnlContainer.BringToFront();
            pnlContainer.Controls.Add(content);
        }
    }
}
