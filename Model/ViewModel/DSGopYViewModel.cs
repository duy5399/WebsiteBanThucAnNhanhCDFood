using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class DSGopYViewModel
    {
        [Key]
        public int? MaGopY { get; set; }
        public string TenKH { get; set; }
        public string DienThoaiKH { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string Email { get; set; }
        public DateTime? NgayGopY { get; set; }
    }
}
