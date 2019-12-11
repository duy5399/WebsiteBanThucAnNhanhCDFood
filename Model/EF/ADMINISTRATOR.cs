namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMINISTRATOR")]
    public partial class ADMINISTRATOR
    {
        [Key]
        public int MaADMIN { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên đăng nhập")]
        public string TenDN { get; set; }

        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ và tên")]
        public string HoTenADMIN { get; set; }

        [StringLength(5)]
        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        public string DienThoai { get; set; }
    }
}
