using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRise.DirectoryProcess
{
    public class CreateDataBasePath
    {
        public static void CreatePath()
        {
            string path = @"C:\InstamRise\Lite\Veritabanı";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
