using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class CTDonHangViewModel
    {
        [Key]
        public int? SoDH { get; set; }
        public string TenMonAn { get; set; }
        public string HinhMinhHoa { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? Thanhtien { get; set; }
    }
}
