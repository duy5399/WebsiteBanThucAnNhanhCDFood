namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLCDFoodEntities : DbContext
    {
        public QLCDFoodEntities()
            : base("name=QLCDFoodEntities")
        {
        }

        public virtual DbSet<ADMINISTRATOR> ADMINISTRATORs { get; set; }
        public virtual DbSet<CHUDE> CHUDEs { get; set; }
        public virtual DbSet<CTDATHANG> CTDATHANGs { get; set; }
        public virtual DbSet<DANHGIAMONAN> DANHGIAMONANs { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public virtual DbSet<GOPY> GOPies { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<MONAN> MONANs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADMINISTRATOR>()
                .Property(e => e.TenDN)
                .IsUnicode(false);

            modelBuilder.Entity<ADMINISTRATOR>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<ADMINISTRATOR>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ADMINISTRATOR>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<CHUDE>()
                .Property(e => e.MaCD)
                .IsUnicode(false);

            modelBuilder.Entity<CTDATHANG>()
                .Property(e => e.DonGia)
                .HasPrecision(9, 2);

            modelBuilder.Entity<CTDATHANG>()
                .Property(e => e.ThanhTien)
                .HasPrecision(20, 2);

            modelBuilder.Entity<DONDATHANG>()
                .Property(e => e.TriGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DONDATHANG>()
                .Property(e => e.DienThoaiNhan)
                .IsUnicode(false);

            modelBuilder.Entity<DONDATHANG>()
                .HasMany(e => e.CTDATHANGs)
                .WithRequired(e => e.DONDATHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.TenDN)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DienThoaiKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DANHGIAMONANs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONAN>()
                .Property(e => e.MaCD)
                .IsUnicode(false);

            modelBuilder.Entity<MONAN>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MONAN>()
                .Property(e => e.HinhMinhHoa)
                .IsUnicode(false);

            modelBuilder.Entity<MONAN>()
                .HasMany(e => e.CTDATHANGs)
                .WithRequired(e => e.MONAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.DienThoaiNV)
                .IsUnicode(false);
        }
    }
}
