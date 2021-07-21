using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRise.DirectoryProcess
{
    public static class CreateMediaPath
    {
        public static bool CreatePath(string Path) {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
                return true;
            }
            else {
                return false;
            }
             
        }
        public static void CreateDownloadSecondPath(string username) {
            for (int i = 2; i < 50; i++)
            {

                if (CreatePath(Models.MediaPath.MediaPathVideo) && CreatePath(Models.MediaPath.MediaPathImage))
                {
                    break;
                }
                else {
                    Models.MediaPath.MediaPathVideo = Models.MediaPath.MediaPathDirectory + "\\" + username + "_" + i + "_\\Video";
                    Models.MediaPath.MediaPathImage = Models.MediaPath.MediaPathDirectory + "\\" + username + "_" + i + "_\\Resim";
                    if (CreatePath(Models.MediaPath.MediaPathVideo) && CreatePath(Models.MediaPath.MediaPathImage))
                    {
                        break;
                    }
                }
            }
        }
    }
}
