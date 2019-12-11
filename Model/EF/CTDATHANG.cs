namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDATHANG")]
    public partial class CTDATHANG
    {
        [Key]
        [Display(Name = "Số đơn hàng")]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoDH { get; set; }

        [Key]
        [Display(Name = "Mã món ăn")]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMonAn { get; set; }

        [Display(Name = "Số lượng")]
        public int? SoLuong { get; set; }

        [Display(Name = "Đơn giá")]
        public decimal? DonGia { get; set; }

        [Display(Name = "Thành tiền")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ThanhTien { get; set; }

        public virtual DONDATHANG DONDATHANG { get; set; }

        public virtual MONAN MONAN { get; set; }
    }
}
