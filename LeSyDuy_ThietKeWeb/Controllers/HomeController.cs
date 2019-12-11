using LeSyDuy_ThietKeWeb.Common;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeSyDuy_ThietKeWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            var productDao = new ProductDao();
            ViewBag.MonAn_KR_Home = productDao.ListMonAn_KR_Home(5);
            ViewBag.MonAn_JP_Home = productDao.ListMonAn_JP_Home(5);
            ViewBag.MonAn_DRINK_Home = productDao.ListMonAn_DRINK_Home(5);
            return View();
        }

        public ActionResult Introduction()
        {
            return View();
        }
    }
}