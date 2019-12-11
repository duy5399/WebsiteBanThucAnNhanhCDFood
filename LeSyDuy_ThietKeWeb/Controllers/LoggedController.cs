using LeSyDuy_ThietKeWeb.Common;
using LeSyDuy_ThietKeWeb.Models;
using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeSyDuy_ThietKeWeb.Controllers
{
    public class LoggedController : BaseController
    {
        private QLCDFoodEntities db = new QLCDFoodEntities();
        // GET: Logged
        public ActionResult ThongTinUser()
        {
            var session = (UserLogin)Session[CommonConstants.SESSION];
            if (session == null)
            {
                return Redirect("/dang-nhap");
            }
            else
            {
                var user = new UserDao().GetByName(session.TenDN);
                return View(user);
            }
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(string matkhaucu_txt, string matkhaumoi_txt, string matkhaumoi2_txt)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstants.SESSION];
                var dao = new UserDao();
                if(Encryptor.MD5Hash(matkhaucu_txt) != dao.GetByName(session.TenDN).MatKhau)
                {
                    ModelState.AddModelError("", "Mật khẩu cũ không chính xác!");
                    return View();
                }
                
                if(Encryptor.MD5Hash(matkhaumoi_txt) == dao.GetByName(session.TenDN).MatKhau)
                    ModelState.AddModelError("", "Mật khẩu mới phải khác với mật khẩu cũ!");
                else if(matkhaumoi_txt.Length < 6)
                    ModelState.AddModelError("", "Mật khẩu mới phải có độ dài lớn hơn 5 kí tự");
                else if(Encryptor.MD5Hash(matkhaumoi2_txt) != Encryptor.MD5Hash(matkhaumoi_txt))
                    ModelState.AddModelError("", "Nhập lại mật khẩu mới không chính xác!");
                else
                {
                    int result = dao.ChangePassword(session.MaKH, Encryptor.MD5Hash(matkhaucu_txt), Encryptor.MD5Hash(matkhaumoi_txt), Encryptor.MD5Hash(matkhaumoi2_txt));
                    if (result == 1)
                    {
                        return Redirect("/doi-mk-thanh-cong");
                    }
                }
                
            }
            return View();
        }

        public ActionResult CP_Success()
        {
            return View();
        }

        public ActionResult GopY()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GopY(GOPY gy)
        {
            var session = (UserLogin)Session[CommonConstants.SESSION];
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                int id = dao.GopY(gy, session.MaKH);
                if (id > 0)
                {
                    return Redirect("/gop-y-thanh-cong");
                }
                else
                {
                    ModelState.AddModelError("", "Góp ý không thành công!");
                    return View();
                }
            }
            return View();
        }

        public ActionResult GY_Success()
        {
            return View();
        }

        //public ActionResult LS_MuaHang(int maKH)
        //{
        //    var model = new UserDao().ListLSMuaHang(maKH);        
        //    return View(model);
        //}

        //-----------------------------------------------//
        public ActionResult LSMuaHang(int maKH,string searchDonHang, int page = 1, int pageSize = 5)
        {
            var dao = new UserDao();
            var model = dao.ListLSMuaHang_AllPaging(maKH, searchDonHang, page, pageSize);
            ViewBag.SearchDonHang = searchDonHang;
            return View(model);
        }

        public ActionResult ChiTietMuaHang(int soDH)
        {
            var model = new UserDao().ListCTMuaHang(soDH);
            return View(model);
        }

    }
}