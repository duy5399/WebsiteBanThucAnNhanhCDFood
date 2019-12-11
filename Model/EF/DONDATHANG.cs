namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONDATHANG")]
    public partial class DONDATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONDATHANG()
        {
            CTDATHANGs = new HashSet<CTDATHANG>();
        }

        [Key]
        [Display(Name = "Số đơn hàng")]
        public int SoDH { get; set; }

        [Display(Name = "Mã đơn hàng")]
        public int? MaKH { get; set; }

        [Display(Name = "Ngày đặt hàng")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayDH { get; set; }

        [Display(Name = "Trị giá")]
        [Column(TypeName = "money")]
        public decimal? TriGia { get; set; }

        [Display(Name = "Đã giao")]
        public bool? DaGiao { get; set; }

        [Display(Name = "Ngày giao hàng")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayGiaoHang { get; set; }

        [Display(Name = "Tên người nhận")]
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }

        [Display(Name = "Địa chỉ nhận")]
        [StringLength(50)]
        public string DiaChiNhan { get; set; }

        [Display(Name = "Số điện thoại")]
        [StringLength(15)]
        public string DienThoaiNhan { get; set; }

        [Display(Name = "Hình thức thanh toán")]
        [StringLength(50)]
        public string HTThanhToan { get; set; }

        [Display(Name = "Hình thức giao hàng")]
        [StringLength(50)]
        public string HTGiaoHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDATHANG> CTDATHANGs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
