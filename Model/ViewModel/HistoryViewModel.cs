using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class HistoryViewModel
    {
        [Key]
        public int MaKH { get; set; }
        public int MaDH { get; set; }
        public string TenSanPham { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Thanhtien { get; set; }
        public DateTime? NgayMuaHang { get; set; }
        public DateTime? NgayGiaoHang { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChiNhan { get; set; }
    }
}
