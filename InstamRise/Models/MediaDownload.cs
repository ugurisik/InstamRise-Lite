using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRise.Models
{
    public class MediaDownload
    {
        public string MediaCaption { get; set; }
        public string VideoUrL { get; set; }
        public string ImageURL { get; set; }
        public bool isVideo { get; set; }
        public int VideoCount { get; set; }
        public int ImageCount { get; set; }
    }
}
