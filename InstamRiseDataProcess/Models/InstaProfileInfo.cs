using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRiseDataProcess.Models
{
    public class InstaProfile
    {
        public string Biographi { get; set; }

        public string UserName { get; set; }

        public string Followers { get; set; }

        public string Following { get; set; }

        public string Postcount { get; set; }

        public bool Priv { get; set; }

        public bool Verify { get; set; }

        public string Fullname { get; set; }

        public Image Picture { get; set; }

        public long UserID { get; set; }

        public string ExceptionStatus { get; set; }
    }
}
