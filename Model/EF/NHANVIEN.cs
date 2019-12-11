namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        [Display(Name = "Mã nhân viên")]
        public int MaNV { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ và tên nhân viên")]
        [Display(Name = "Họ và tên")]
        [StringLength(50)]
        public string HoTenNV { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập vị trí nhân viên")]
        [Display(Name = "Vị trí")]
        [StringLength(50)]
        public string ViTri { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày vào làm")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Ngày vào làm")]
        [Column(TypeName = "date")]
        public DateTime? NgayVaoLam { get; set; }

        [Display(Name = "Giới tính")]
        [StringLength(5)]
        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Ngày sinh")]
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Sai định dạng Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [Display(Name = "Số điện thoại")]
        [RegularExpression(@"^03([0-9]{8})+$", ErrorMessage = "Số điện thoại không đúng định dạng")]
        [StringLength(10)]
        public string DienThoaiNV { get; set; }
    }
}
