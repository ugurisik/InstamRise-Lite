using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using InstamRise.UserInterface;
namespace InstamRise
{
    public partial class InstamRiseLite : Form
    {
        public static Guna2Panel guna2Panel;
        public InstamRiseLite()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            guna2Panel = guna2Panel2;
        }

        private void InstamRiseLite_Load(object sender, EventArgs e)
        {
            LicencePage licencePage = new LicencePage();

            guna2Panel.Controls.Add(licencePage);
        }

        private void lblClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
