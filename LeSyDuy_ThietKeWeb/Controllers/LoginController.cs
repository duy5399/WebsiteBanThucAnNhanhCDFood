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
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginView()
        {
            var session = (UserLogin)Session[CommonConstants.SESSION];
            if (session == null)
            {
                return View();
            }
            else
                return Redirect("/thong-tin-khach-hang");
        }
        public ActionResult Login(UserLoginModel model)
        {
            if (ModelState.IsValid) //kiểm tra form rỗng
            {
                var dao = new UserDao();
                var result = dao.Login(model.TenDN, Encryptor.MD5Hash(model.MatKhau));
                if (result == 1)
                {
                    var user = dao.GetByName(model.TenDN);
                    var userSession = new UserLogin();
                    userSession.TenDN = user.TenDN;
                    userSession.MaKH = user.MaKH;
                    Session.Add(CommonConstants.SESSION, userSession);
                    return Redirect("/trang-chu");
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
            return View("LoginView");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.CheckTenDN(model.Username))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.CheckEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email đã sử dụng cho 1 tài khoản khác");
                }
                else if (dao.CheckSDT(model.Phone))
                {
                    ModelState.AddModelError("", "Số điện thoại đã sử dụng cho 1 tài khoản khác");
                }
                else
                {
                    var kh = new KHACHHANG();
                    kh.TenDN = model.Username;
                    kh.MatKhau = Encryptor.MD5Hash(model.Password);
                    kh.HoTenKH = model.Name;
                    kh.Email = model.Email;
                    kh.DienThoaiKH = model.Phone;
                    kh.GioiTinh = model.Sex;
                    kh.NgaySinh = model.NgaySinh;
                    var result = new AdminDao().InsertKH(kh);
                    if (result > 0)
                    {
                        ViewBag.Register_Success = "Đăng ký thành công";
                        model = new RegisterModel();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký tài khoản thất bại!");
                    }
                }
            }
            return View(model);
        }

        public ActionResult Congrats()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session[CommonConstants.SESSION] = null;
            return Redirect("/");
        }
    }
}