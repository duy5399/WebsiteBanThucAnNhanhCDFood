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
    public class UserDao
    {
        QLCDFoodEntities db = null;
        public UserDao()    //khởi tạo UserDao khởi tạo luôn biến db
        {
            db = new QLCDFoodEntities();
        }

        //--------------------------Khách hàng-----------------------//
        //Đăng nhập cho khách hàng
        public int Login(string userName, string passWord)
        {
            var result = db.KHACHHANGs.SingleOrDefault(x => x.TenDN == userName);
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

        //lấy tên đăng nhập Khách hàng để gán cho Session
        public KHACHHANG GetByName(string tenDN)
        {
            return db.KHACHHANGs.SingleOrDefault(x => x.TenDN == tenDN);
        }

        //đổi mật khẩu
        public int ChangePassword(int id, string matkhaucu_txt, string matkhaumoi_txt, string matkhaumoi2_txt)
        {
            var result = db.KHACHHANGs.SingleOrDefault(x => x.MaKH == id);
            if (result.MatKhau == matkhaucu_txt && matkhaumoi_txt!=result.MatKhau)
            {
                if (matkhaumoi2_txt == matkhaumoi_txt)
                {
                    result.MatKhau = matkhaumoi_txt;
                    db.SaveChanges();
                    return 1;
                }
                else
                    return 0;
            }
            else
                return -1;
        }

        //góp ý
        public int GopY(GOPY entity, int maKH)
        {
            entity.MaKH = maKH;
            entity.NgayGopY = DateTime.Now;
            db.GOPies.Add(entity);
            db.SaveChanges();
            return entity.MaGopY;
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

        //public List<HistoryViewModel> ListLSMuaHang(int maKH)
        //{
            
        //    var model = from chitiet_dh in db.CTDATHANGs
        //                join don_dh in db.DONDATHANGs
        //                on chitiet_dh.SoDH equals don_dh.SoDH
        //                join monan in db.MONANs
        //                on chitiet_dh.MaMonAn equals monan.MaMonAn
        //                 where don_dh.MaKH == maKH
        //                 select new HistoryViewModel()
        //                 {
        //                     MaDH = don_dh.SoDH,
        //                     TenSanPham = monan.TenMonAn,
        //                     NgayMuaHang = don_dh.NgayDH,
        //                     NgayGiaoHang = don_dh.NgayGiaoHang,
        //                     DiaChiNhan = don_dh.DiaChiNhan,
        //                     NguoiNhan = don_dh.TenNguoiNhan,
        //                     SoLuong = chitiet_dh.SoLuong,
        //                     Thanhtien = chitiet_dh.ThanhTien
        //                 };
        //    //model.OrderByDescending(x => x.NgayMuaHang).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        //    return model.OrderByDescending(x=>x.MaDH).ToList();
        //}


        //Lấy danh sách DONDATHANG có trong Database - IEnumerable là 1 danh sách
        public IEnumerable<DONDATHANG> ListLSMuaHang_AllPaging(int maKH,string searchDonHang, int page, int pageSize)
        {
            IQueryable<DONDATHANG> model = db.DONDATHANGs.Where(x=>x.MaKH == maKH).OrderByDescending(x => x.SoDH);
            if (!string.IsNullOrEmpty(searchDonHang))
            {
                model = model.Where(x => x.MaKH == maKH && (x.NgayDH.ToString().Contains(searchDonHang) || x.SoDH.ToString().Contains(searchDonHang) || x.TenNguoiNhan.Contains(searchDonHang)));
            }
            return model.OrderByDescending(x => x.SoDH).ToPagedList(page, pageSize);
        }

        //Chi tiết đơn hàng
        public List<CTDonHangViewModel> ListCTMuaHang(int soDH)
        {
            var model = from chitiet_dh in db.CTDATHANGs
                        join monan in db.MONANs
                        on chitiet_dh.MaMonAn equals monan.MaMonAn
                        where chitiet_dh.SoDH == soDH
                        select new CTDonHangViewModel()
                        {
                            SoDH = soDH,
                            TenMonAn = monan.TenMonAn,
                            HinhMinhHoa = monan.HinhMinhHoa,
                            SoLuong = chitiet_dh.SoLuong,
                            DonGia = monan.DonGia,
                            Thanhtien = chitiet_dh.ThanhTien
                        };
            //model.OrderByDescending(x => x.NgayMuaHang).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.OrderByDescending(x => x.SoDH).ToList();
        }

    }
}