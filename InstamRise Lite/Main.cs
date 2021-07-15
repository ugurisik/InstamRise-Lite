using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public const string AccountPathDirectory = @"C:\InstamRise\Lite\Hesaplar";

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
            if (!Directory.Exists(AccountPathDirectory))
                Directory.CreateDirectory(AccountPathDirectory);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
