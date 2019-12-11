using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeSyDuy_ThietKeWeb.Common
{
    [Serializable]
    public class UserLogin
    {
        public int MaKH { set; get; }
        public string TenDN { set; get; }
    }

    [Serializable]
    public class AdminLogin
    {
        public int MaADMIN { set; get; }
        public string TenDN { set; get; }
    }

}