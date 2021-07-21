using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstamRise.DirectoryProcess
{
    public class OpenFileDialogChoisePicture
    {
        public string ChoisePicture()
        {
            string returnPath = "";
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG Dosyaları (*.jpg)|*.jpg";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Resim Seçiniz...";
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                returnPath = file.FileName;
            }
            return returnPath;
        }
    }
}
