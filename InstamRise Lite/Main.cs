using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstamRise_Lite.Design;
using InstamRise_Lite.UserInterface;
namespace InstamRise_Lite
{
    public partial class Main : Form
    {
        public static Guna.UI2.WinForms.Guna2Panel panel;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel = pnlContainer;
            if (true)
            {
                LicencePage licencePage = new LicencePage();
                new ChangeContainerPanel(licencePage, panel);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
