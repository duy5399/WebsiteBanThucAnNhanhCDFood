namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONAN")]
    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            CTDATHANGs = new HashSet<CTDATHANG>();
        }

        [Key]
        [Display(Name = "Mã món ăn")]
        public int MaMonAn { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên món ăn")]
        [Display(Name = "Tên món ăn")]
        [StringLength(100)]
        public string TenMonAn { get; set; }

        [Display(Name = "Mã chủ đề")]
        [StringLength(10)]
        public string MaCD { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        [Display(Name = "Mô tả")]
        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập đơn giá")]
        [Range(0, Int64.MaxValue, ErrorMessage = "Vui lòng chỉ nhập số")]
        [Display(Name = "Đơn giá")]
        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ảnh minh họa cho món ăn")]
        [Display(Name = "Hình minh họa")]
        [StringLength(50)]
        public string HinhMinhHoa { get; set; }

        [Display(Name = "Ngày cập nhật")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayCapNhat { get; set; }

        [Display(Name = "Số lượng bán")]
        public int? SoLuongBan { get; set; }

        public virtual CHUDE CHUDE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDATHANG> CTDATHANGs { get; set; }
    }
}
