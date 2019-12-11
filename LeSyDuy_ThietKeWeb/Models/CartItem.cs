using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeSyDuy_ThietKeWeb.Models
{
    [Serializable]
    public class CartItem
    {
        public MONAN MonAn { set; get; }
        public int SoLuong { set; get; }
    }
}