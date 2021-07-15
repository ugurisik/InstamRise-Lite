using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRise_Lite.ApiProcess
{
    static class Helper
    {
        public const string AccountPathDirectory = @"C:\InstamRise\Lite\Hesaplar";
        public const string SessionExtension = ".InstamRiseLite";
        public static void CreateAccountDirectory()
        {
            if (!Directory.Exists(AccountPathDirectory))
                Directory.CreateDirectory(AccountPathDirectory);
        }
        public static string GetAccountPath(this string username) => $"{AccountPathDirectory}/{username}{SessionExtension}";
    }
}
