namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHGIAMONAN")]
    public partial class DANHGIAMONAN
    {
        [Key]
        [Display(Name = "Mã khách hàng")]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKH { get; set; }

        [Key]
        [Display(Name = "Mã món ăn")]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMonAn { get; set; }

        [Display(Name = "Đánh giá")]
        public int? Rate { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập nội dung đánh giá")]
        [Display(Name = "Nội dung đánh giá")]
        [Column(TypeName = "ntext")]
        public string NoiDungDG { get; set; }

        [Display(Name = "Ngày đánh giá")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayDG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
