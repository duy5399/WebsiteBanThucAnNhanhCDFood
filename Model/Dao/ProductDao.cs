using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Model.ViewModel;

namespace Model.Dao
{
    public class ProductDao
    {
        QLCDFoodEntities db = null;
        public ProductDao()
        {
            db = new QLCDFoodEntities();
        }

        public MONAN GetByMaMonAn(int maMonAn)
        {
            return db.MONANs.SingleOrDefault(x => x.MaMonAn == maMonAn);
        }

        public List<MONAN> ListMonAn_New(int quantity)
        {
            return db.MONANs.OrderByDescending(x => x.NgayCapNhat).Take(quantity).ToList();
        }

        public List<MONAN> ListMonAn_Hot(int quantity)
        {
            return db.MONANs.OrderByDescending(x => x.SoLuongBan).Take(quantity).ToList();
        }

        public List<MONAN> ListMonAn_KR()
        {
            return db.MONANs.Where(x => x.MaCD == "KR").OrderByDescending(x => x.SoLuongBan).ToList();
        }

        public List<MONAN> ListMonAn_JP()
        {
            return db.MONANs.Where(x => x.MaCD == "JP").OrderByDescending(x => x.SoLuongBan).ToList();
        }

        public List<MONAN> ListMonAn_DRINK()
        {
            return db.MONANs.Where(x => x.MaCD == "DRINK").OrderByDescending(x => x.SoLuongBan).ToList();
        }

        //--------------------------------------------//
        public List<MONAN> ListMonAn_KR_Home(int quantity)
        {
            return db.MONANs.Where(x => x.MaCD == "KR").OrderByDescending(x => x.SoLuongBan).Take(quantity).ToList();
        }

        public List<MONAN> ListMonAn_JP_Home(int quantity)
        {
            return db.MONANs.Where(x => x.MaCD == "JP").OrderByDescending(x => x.SoLuongBan).Take(quantity).ToList();
        }

        public List<MONAN> ListMonAn_DRINK_Home(int quantity)
        {
            return db.MONANs.Where(x => x.MaCD == "DRINK").OrderByDescending(x => x.NgayCapNhat).Take(quantity).ToList();
        }

        public MONAN Detail(int MaMonAn)
        {
            return db.MONANs.Find(MaMonAn);
        }

        public List<MONAN> ListMonAn_Related(int id, int quantity)
        {
            var monan = db.MONANs.Find(id);
            return db.MONANs.Where(x => x.MaMonAn != id && x.MaCD == monan.MaCD).OrderBy(Guid=>new Guid()).Take(quantity).ToList();
        }

        public bool InsertDGMonAn(DANHGIAMONAN entity)
        {
            try
            {
                db.DANHGIAMONANs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        //public IEnumerable<DANHGIAMONAN> ListDGMonAn_AllPaging(int maMonAn,int page, int pageSize)
        //{
        //    return db.DANHGIAMONANs.Where(x=>x.MaMonAn == maMonAn).OrderByDescending(x => x.NgayDG).ToPagedList(page, pageSize);
        //}

        public List<DanhGiaViewModel> ListDG_Monan(int maMonAn)
        {
            var model = from dg_monan in db.DANHGIAMONANs
                        join kh in db.KHACHHANGs
                        on dg_monan.MaKH equals kh.MaKH
                        where dg_monan.MaMonAn == maMonAn
                        select new DanhGiaViewModel()
                        {
                            MaKH = kh.MaKH,
                            TenKH = kh.HoTenKH,
                            Rate = dg_monan.Rate,
                            NoiDungDG = dg_monan.NoiDungDG,
                            NgayDG = dg_monan.NgayDG,
                        };
            //model.OrderByDescending(x => x.NgayMuaHang).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.OrderByDescending(x => x.NgayDG).ToList();
        }
    }
}
