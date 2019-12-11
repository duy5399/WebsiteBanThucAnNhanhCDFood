using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class DanhGiaViewModel
    {
        [Key]
        public int? MaKH { get; set; }
        public string TenKH { get; set; }
        public int? Rate { get; set; }
        public string NoiDungDG { get; set; }
        public DateTime? NgayDG { get; set; }
    }
}
