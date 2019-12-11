namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GOPY")]
    public partial class GOPY
    {
        [Key]
        [Display(Name = "Mã góp ý")]
        public int MaGopY { get; set; }

        [Display(Name = "Mã khách hàng")]
        public int? MaKH { get; set; }

        [Display(Name = "Ngày góp ý")]
        [Column(TypeName = "date")]
        public DateTime? NgayGopY { get; set; }

        [Display(Name = "Tiêu đề")]
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề góp ý")]
        [StringLength(100)]
        public string TieuDe { get; set; }

        [Display(Name = "Nội dung")]
        [Required(ErrorMessage = "Vui lòng nhập nội dung góp ý")]
        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
