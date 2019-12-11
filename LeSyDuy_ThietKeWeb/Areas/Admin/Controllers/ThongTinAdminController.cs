using LeSyDuy_ThietKeWeb.Common;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeSyDuy_ThietKeWeb.Areas.Admin.Controllers
{
    public class ThongTinAdminController : BaseAdminController
    {
        // GET: Admin/ThongTinAdmin
        public ActionResult TTAdmin()
        {
            var session = (AdminLogin)Session[CommonConstants.SESSION_ADMIN];
            var admin = new AdminDao().GetByNameADMIN(session.TenDN);
            return View(admin);
        }
    }
}