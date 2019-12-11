using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.ViewModel;
using PagedList;

namespace Model.Dao
{
    public class AdminDao
    {
        QLCDFoodEntities db = null;
        public AdminDao()    //khởi tạo AdminDao khởi tạo luôn biến db
        {
            db = new QLCDFoodEntities();
        }

        //--------------------------Admin-----------------------//
        //Đăng nhập cho admin
        public int AdminLogin(string userName, string passWord)
        {
            var result = db.ADMINISTRATORs.SingleOrDefault(x => x.TenDN == userName);
            if (result == null)
                return 0;
            else
            {
                if (result.MatKhau == passWord)
                    return 1;
                else
                    return -1;
            }
        }

        //lấy Tên đăng nhập Admin để tí gán cho Session
        public ADMINISTRATOR GetByNameADMIN(string tenDN)
        {
            return db.ADMINISTRATORs.SingleOrDefault(x => x.TenDN == tenDN);
        }

        //--------------------------Khách hàng-----------------------//
        //Lấy danh sách Khách hàng có trong Database - IEnumerable là 1 danh sách
        public IEnumerable<KHACHHANG> ListKH_AllPaging(string searchKH, int page, int pageSize)
        {
            IQueryable<KHACHHANG> model = db.KHACHHANGs.OrderBy(x => x.MaKH);
            if (!string.IsNullOrEmpty(searchKH))
            {
                model = model.Where(x => x.HoTenKH.Contains(searchKH) || x.MaKH.ToString().Contains(searchKH) || x.TenDN.Contains(searchKH));
            }
            return model.OrderBy(x => x.MaKH).ToPagedList(page, pageSize);
        }

        public bool CheckTenDN(string tenDN)
        {
            return db.KHACHHANGs.Count(x => x.TenDN == tenDN) > 0;
        }
        public bool CheckEmail(string email)
        {
            return db.KHACHHANGs.Count(x => x.Email == email) > 0;
        }
        public bool CheckSDT(string sdt)
        {
            return db.KHACHHANGs.Count(x => x.DienThoaiKH == sdt) > 0;
        }
        public bool CheckTenDNUpdate(string tenDN, int maKH)
        {
            return db.KHACHHANGs.Count(x => x.TenDN == tenDN && x.MaKH != maKH) > 0;
        }
        public bool CheckEmailUpdate(string email, int maKH)
        {
            return db.KHACHHANGs.Count(x => x.Email == email && x.MaKH != maKH) > 0;
        }
        public bool CheckSDTUpdate(string sdt, int maKH)
        {
            return db.KHACHHANGs.Count(x => x.DienThoaiKH == sdt && x.MaKH != maKH) > 0;
        }

        //Thêm khách hàng mới
        public int InsertKH(KHACHHANG entity)
        {
            db.KHACHHANGs.Add(entity);
            db.SaveChanges();
            return entity.MaKH;
        }

        //Sửa thông tin khách hàng
        public bool UpdateKH(KHACHHANG entity)
        {
            try
            {
                var khachhang = db.KHACHHANGs.Find(entity.MaKH);
                khachhang.TenDN = entity.TenDN;
                khachhang.HoTenKH = entity.HoTenKH;
                khachhang.GioiTinh = entity.GioiTinh;
                khachhang.NgaySinh = entity.NgaySinh;
                khachhang.Email = entity.Email;
                khachhang.DienThoaiKH = entity.DienThoaiKH;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //lấy MaKH để cho Update thông tin khách hàng
        public KHACHHANG GetByID(int id)
        {
            return db.KHACHHANGs.Find(id);
        }

        //Xóa 1 khách hàng
        public bool DeleteKH(int id)
        {
            try
            {
                var khachhang = db.KHACHHANGs.Find(id);
                db.KHACHHANGs.Remove(khachhang);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //--------------------------Nhân viên-----------------------//
        //Lấy danh sách Nhân viên có trong Database - IEnumerable là 1 danh sách
        public IEnumerable<NHANVIEN> ListNV_AllPaging(string searchNV, int page, int pageSize)
        {
            IQueryable<NHANVIEN> model = db.NHANVIENs.OrderBy(x => x.MaNV);
            if (!string.IsNullOrEmpty(searchNV))
            {
                model = model.Where(x => x.HoTenNV.Contains(searchNV) || x.MaNV.ToString().Contains(searchNV) || x.ViTri.Contains(searchNV));
            }
            return model.OrderBy(x => x.MaNV).ToPagedList(page, pageSize);
        }

        public bool CheckEmailNV(string email)
        {
            return db.NHANVIENs.Count(x => x.Email == email) > 0;
        }
        public bool CheckSDTNV(string sdt)
        {
            return db.NHANVIENs.Count(x => x.DienThoaiNV == sdt) > 0;
        }
        public bool CheckEmailNVUpdate(string email, int maNV)
        {
            return db.NHANVIENs.Count(x => x.Email == email && x.MaNV != maNV) > 0;
        }
        public bool CheckSDTNVUpdate(string sdt, int maNV)
        {
            return db.NHANVIENs.Count(x => x.DienThoaiNV == sdt && x.MaNV != maNV) > 0;
        }

        //Thêm nhân viên mới
        public int InsertNV(NHANVIEN entity)
        {
            db.NHANVIENs.Add(entity);
            db.SaveChanges();
            return entity.MaNV;
        }

        //Sửa thông tin nhân viên
        public bool UpdateNV(NHANVIEN entity)
        {
            try
            {
                var nhanvien = db.NHANVIENs.Find(entity.MaNV);
                nhanvien.HoTenNV = entity.HoTenNV;
                nhanvien.ViTri = entity.ViTri;
                nhanvien.NgayVaoLam = entity.NgayVaoLam;
                nhanvien.GioiTinh = entity.GioiTinh;
                nhanvien.NgaySinh = entity.NgaySinh;
                nhanvien.Email = entity.Email;
                nhanvien.DienThoaiNV = entity.DienThoaiNV;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //lấy MaNV để cho Update thông tin nhân viên
        public NHANVIEN GetByMaNV(int id)
        {
            return db.NHANVIENs.Find(id);
        }

        //Xóa 1 nhân viên
        public bool DeleteNV(int id)
        {
            try
            {
                var nhanvien = db.NHANVIENs.Find(id);
                db.NHANVIENs.Remove(nhanvien);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //--------------------------Món ăn-----------------------//

        //Lấy danh sách Món ăn có trong Database - IEnumerable là 1 danh sách
        public IEnumerable<MONAN> ListMonAn_AllPaging(string searchMonAn, int page, int pageSize)
        {
            IQueryable<MONAN> model = db.MONANs.OrderBy(x => x.MaMonAn);
            if (!string.IsNullOrEmpty(searchMonAn))
            {
                model = model.Where(x => x.TenMonAn.Contains(searchMonAn) || x.MaCD.Contains(searchMonAn));
            }
            return model.OrderBy(x => x.MaMonAn).ToPagedList(page, pageSize);
        }

        public bool CheckTenMonAn(string tenMonAn)
        {
            return db.MONANs.Count(x => x.TenMonAn == tenMonAn) > 0;
        }
        public bool CheckTenMonAnUpdate(string tenMonAn, int maMonAn)
        {
            return db.MONANs.Count(x => x.TenMonAn == tenMonAn && x.MaMonAn != maMonAn) > 0;
        }

        //Thêm món ăn mới
        public int InsertMonAn(MONAN entity)
        {
            entity.SoLuongBan = 0;
            entity.NgayCapNhat = DateTime.Now;
            db.MONANs.Add(entity);
            db.SaveChanges();
            return entity.MaMonAn;
        }

        //Sửa thông tin món ăn
        public bool UpdateMonAn(MONAN entity)
        {
            try
            {
                var monan = db.MONANs.Find(entity.MaMonAn);
                monan.TenMonAn = entity.TenMonAn;
                monan.MaCD = entity.MaCD;
                monan.MoTa = entity.MoTa;
                monan.DonGia = entity.DonGia;
                monan.HinhMinhHoa = entity.HinhMinhHoa;
                monan.NgayCapNhat = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //lấy MaMonAn để cho Update thông tin món ăn
        public MONAN GetByMaMonAn(int id)
        {
            return db.MONANs.Find(id);
        }

        //Xóa 1 món ăn
        public bool DeleteMonAn(int id)
        {
            try
            {
                var monan = db.MONANs.Find(id);
                db.MONANs.Remove(monan);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CHUDE> ListMaCD()
        {
            return db.CHUDEs.Where(x => x.MaCD != null).ToList();
        }

        //--------------------------Đơn hàng-----------------------//
        //Lấy danh sách DONDATHANG có trong Database - IEnumerable là 1 danh sách
        public IEnumerable<DONDATHANG> ListDH_AllPaging(string searchDonHang, int page, int pageSize)
        {
            IQueryable<DONDATHANG> model = db.DONDATHANGs.OrderByDescending(x => x.SoDH);
            if (!string.IsNullOrEmpty(searchDonHang))
            {
                model = model.Where(x => x.NgayDH.ToString().Contains(searchDonHang) || x.MaKH.ToString().Contains(searchDonHang) || x.SoDH.ToString().Contains(searchDonHang) || x.TenNguoiNhan.Contains(searchDonHang));
            }
            return model.OrderByDescending(x => x.SoDH).ToPagedList(page, pageSize);
        }

        public bool DuyetDH(int soDH)
        {
            var dh = db.DONDATHANGs.Find(soDH);
            dh.DaGiao = true;
            dh.NgayGiaoHang = DateTime.Now;
            db.SaveChanges();
            return true;
        }

        //Lấy danh sách CTDONDATHANG có trong Database - IEnumerable là 1 danh sách
        public IEnumerable<CTDATHANG> ListCTDH_AllPaging(int soDH, int page, int pageSize)
        {
            return db.CTDATHANGs.Where(x => x.SoDH == soDH).OrderBy(x=>x.SoDH).ToPagedList(page, pageSize);
        }

        //danh sách góp ý
        public List<DSGopYViewModel> ListGopY()
        {
            var model = from gopy in db.GOPies
                        join kh in db.KHACHHANGs
                        on gopy.MaKH equals kh.MaKH
                        select new DSGopYViewModel()
                        {
                            TenKH = kh.HoTenKH,
                            DienThoaiKH = kh.DienThoaiKH,
                            Email = kh.Email,
                            TieuDe = gopy.TieuDe,
                            NoiDung = gopy.NoiDung,
                            NgayGopY = gopy.NgayGopY
                        };
            //model.OrderByDescending(x => x.NgayMuaHang).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.OrderByDescending(x => x.NgayGopY).ToList();
        }

    }
}
