using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS_DTCK.Common
{
    [Serializable]
    public class AdminLogin
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string User { get; set; }
    }
}