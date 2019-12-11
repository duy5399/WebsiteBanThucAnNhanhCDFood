using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeSyDuy_ThietKeWeb.Areas.Admin.Controllers
{
    public class QLGYController : BaseAdminController
    {
        // GET: Admin/QLGY
        public ActionResult DSGY()
        {
            var model = new AdminDao().ListGopY();
            return View(model);
        }
    }
}