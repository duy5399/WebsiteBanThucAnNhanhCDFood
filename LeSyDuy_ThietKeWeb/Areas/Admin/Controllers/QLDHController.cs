using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeSyDuy_ThietKeWeb.Areas.Admin.Controllers
{
    public class QLDHController : BaseAdminController
    {
        // GET: Admin/QLDH
        public ActionResult DSDH(string searchDonHang, int page = 1, int pageSize = 5)
        {
            var dao = new AdminDao();
            var model = dao.ListDH_AllPaging(searchDonHang, page, pageSize);
            ViewBag.SearchDonHang = searchDonHang;
            return View(model);
        }

        public ActionResult ChiTietDH(int soDH)
        {
            var model = new UserDao().ListCTMuaHang(soDH);
            return View(model);
        }

        public ActionResult PheDuyetDH(int soDH)
        {
            var dao = new AdminDao();
            dao.DuyetDH(soDH);
            return Redirect("/quan-ly-don-hang");
        }
    }
}