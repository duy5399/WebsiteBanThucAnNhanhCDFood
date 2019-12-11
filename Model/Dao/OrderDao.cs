using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class OrderDao
    {
        QLCDFoodEntities db = null;
        public OrderDao()    //khởi tạo OrderDao khởi tạo luôn biến db
        {
            db = new QLCDFoodEntities();
        }
        public int Insert(DONDATHANG dondathang)
        {
            db.DONDATHANGs.Add(dondathang);
            db.SaveChanges();
            return dondathang.SoDH;
        }

        public void InsertTotal(int soDH, decimal total)
        {
            var don_dh = db.DONDATHANGs.Find(soDH);
            don_dh.TriGia = total;
            db.SaveChanges();
        }

        public void InsertSLBan(int maMonAn, int soluong)
        {
            var monan = db.MONANs.Find(maMonAn);
            monan.SoLuongBan += soluong;
            db.SaveChanges();
        }
    }
}
