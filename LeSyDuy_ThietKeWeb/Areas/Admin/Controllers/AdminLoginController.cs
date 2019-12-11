using LeSyDuy_ThietKeWeb.Areas.Admin.Models;
using LeSyDuy_ThietKeWeb.Common;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeSyDuy_ThietKeWeb.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Admin/AdminLogin
        public ActionResult AdminLoginView()
        {
            return View();
        }

        public ActionResult AdminLogin(AdminLoginModel model)
        {
            if (ModelState.IsValid) //kiểm tra form rỗng
            {
                var dao = new AdminDao();
                var result = dao.AdminLogin(model.TenDN, Encryptor.MD5Hash(model.MatKhau));
                if (result == 1)
                {
                    var admin = dao.GetByNameADMIN(model.TenDN);
                    var adminSession = new AdminLogin();
                    adminSession.TenDN = admin.TenDN;
                    adminSession.MaADMIN = admin.MaADMIN;
                    Session.Add(CommonConstants.SESSION_ADMIN, adminSession);
                    return Redirect("/thong-tin-admin");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tên đăng nhập không đúng. Vui lòng kiểm tra lại!");
                }
                else
                {
                    ModelState.AddModelError("", "Mật khẩu không chính xác. Vui lòng nhập lại!");
                }
            }
            return View("AdminLoginView");
        }

        public ActionResult Logout()
        {
            Session[CommonConstants.SESSION_ADMIN] = null;
            return Redirect("/login-admin");
        }
    }
}