using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class OrderDetailDao
    {
        QLCDFoodEntities db = null;
        public OrderDetailDao()    //khởi tạo OrderDetailDao khởi tạo luôn biến db
        {
            db = new QLCDFoodEntities();
        }
        public bool Insert(CTDATHANG chitiet)
        {
            try
            {
                db.CTDATHANGs.Add(chitiet);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
