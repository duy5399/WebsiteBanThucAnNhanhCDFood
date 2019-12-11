using LeSyDuy_ThietKeWeb.Common;
using LeSyDuy_ThietKeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Model.EF;
using Model.Dao;
using Common;
using System.Configuration;

namespace LeSyDuy_ThietKeWeb.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        // GET: Cart
        public ActionResult GioHang()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        public ActionResult ThucDon()
        {
            var productDao = new ProductDao();
            ViewBag.MonAn_New = productDao.ListMonAn_New(4);
            ViewBag.MonAn_Hot = productDao.ListMonAn_Hot(4);
            ViewBag.MonAn_KR = productDao.ListMonAn_KR();
            ViewBag.MonAn_JP = productDao.ListMonAn_JP();
            ViewBag.MonAn_DRINK = productDao.ListMonAn_DRINK();
            return View();
        }

        public ActionResult DetailMonAn(int MaMonAn)
        {
            var monan = new ProductDao().Detail(MaMonAn);
            ViewBag.RelatedMonAn = new ProductDao().ListMonAn_Related(MaMonAn, 4);
            return View(monan);
        }

        //thông báo giỏ hàng nhỏ
        [ChildActionOnly]
        public PartialViewResult CartAlert()
        {
            var cart = Session[CommonConstants.CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return PartialView(list);
        }

        public ActionResult DanhGiaMonAn(int maMonAn)
        {
            var dao = new ProductDao();
            ViewBag.MaMonAn = dao.GetByMaMonAn(maMonAn).MaMonAn;
            ViewBag.ChuDe = dao.GetByMaMonAn(maMonAn).MaCD;
            ViewBag.TenMonAn = dao.GetByMaMonAn(maMonAn).TenMonAn;
            ViewBag.HinhMinhHoa = dao.GetByMaMonAn(maMonAn).HinhMinhHoa;
            var model = dao.ListDG_Monan(maMonAn);
            return View(model);
        }

        public ActionResult FormDanhGiaMonAn(int maMonAn)
        {
            var session = (UserLogin)Session[CommonConstants.SESSION];
            if (session == null)
            {
                return Redirect("/dang-nhap");
            }
            else
            {
                var dao = new ProductDao();
                TempData["MaMonAn"] = dao.GetByMaMonAn(maMonAn).MaMonAn;
                TempData["ChuDe"] = dao.GetByMaMonAn(maMonAn).MaCD;
                TempData["TenMonAn"] = dao.GetByMaMonAn(maMonAn).TenMonAn;
                TempData["HinhMinhHoa"] = dao.GetByMaMonAn(maMonAn).HinhMinhHoa;
                TempData.Keep();
                return View("FormDanhGiaMonAn");
            }
        }

        [HttpPost]
        public ActionResult FormDanhGiaMonAn(DANHGIAMONAN dg, int maMonAn)
        {
            if (ModelState.IsValid)
            {
                var session = (UserLogin)Session[CommonConstants.SESSION.ToString()];
                var dao = new ProductDao();
                dg.MaKH = session.MaKH;
                dg.MaMonAn = maMonAn;
                dg.NgayDG = DateTime.Now;
                var result = dao.InsertDGMonAn(dg);
                if (result)
                {
                    ViewBag.DanhGia_Success = "Đánh giá thành công";
                }
                else
                {
                    ModelState.AddModelError("", "Bạn đã đánh giá món ăn này rồi!");
                }
            }
            return View("FormDanhGiaMonAn");
        }

        //thêm vào giỏ hàng
        public ActionResult AddItem(int maMonAn, int soluong)
        {
            var monan = new ProductDao().Detail(maMonAn);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if(list.Exists(x=>x.MonAn.MaMonAn == maMonAn))
                {
                    foreach (var item in list)
                    {
                        if (item.MonAn.MaMonAn == maMonAn)
                        {
                            item.SoLuong += soluong;
                        }
                    }
                }
                else
                {
                    //tạo mới đối tượng card item
                    var item = new CartItem();
                    item.MonAn = monan;
                    item.SoLuong = soluong;
                    list.Add(item);
                }
                //gán vào session
                Session[CartSession] = list;
            }
            else
            {
                //tạo mới đối tượng card item
                var item = new CartItem();
                item.MonAn = monan;
                item.SoLuong = soluong;
                var list = new List<CartItem>();
                list.Add(item);

                //gán vào session
                Session[CartSession] = list;
            }
            return Redirect("/gio-hang");
        }

        //cập nhật giỏ hàng
        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartItem>>(cartModel);
            var sessionCart = (List<CartItem>)Session[CartSession];
            foreach(var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.MonAn.MaMonAn == item.MonAn.MaMonAn);
                if(jsonItem != null)
                {
                    item.SoLuong = jsonItem.SoLuong;
                }
            }
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        //xóa tất cả trong gio3 hàng
        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });
        }

        //xóa 1 mặt hàng trong giỏ h
        public JsonResult Delete(int maMonAn)
        {
            var sessionCart = (List<CartItem>)Session[CartSession];
            sessionCart.RemoveAll(x => x.MonAn.MaMonAn == maMonAn);
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        public ActionResult ThanhToan()
        {
            var session = (UserLogin)Session[CommonConstants.SESSION];
            if (session == null)
            {
                return Redirect("/dang-nhap");
            }
            else
            {
                var cart = Session[CartSession];
                var list = new List<CartItem>();
                if (cart != null)
                {
                    list = (List<CartItem>)cart;
                }
                return View(list);
            }
        }

        [HttpPost]
        public ActionResult ThanhToan(string shipName, string address, string mobile, string httt, string htgh)
        {
            var od = new OrderDao();
            var session = (UserLogin)Session[CommonConstants.SESSION];
            var dondathang = new DONDATHANG();
            dondathang.MaKH = new UserDao().GetByName(session.TenDN).MaKH;
            dondathang.NgayDH = DateTime.Now;
            dondathang.TenNguoiNhan = shipName;
            dondathang.DiaChiNhan = address;
            dondathang.DienThoaiNhan = mobile;
            dondathang.HTThanhToan = httt;
            dondathang.HTGiaoHang = htgh;

            
                var soDH = od.Insert(dondathang);
                var cart = (List<CartItem>)Session[CartSession];
                var chitietDao = new OrderDetailDao();
                decimal total = 0;
            //string tenmonan = null, gia = null;
            foreach (var item in cart)
                {
                    var chitiet = new CTDATHANG();
                    chitiet.SoDH = soDH;
                    chitiet.MaMonAn = item.MonAn.MaMonAn;
                    chitiet.DonGia = item.MonAn.DonGia;
                    chitiet.SoLuong = item.SoLuong;
                    chitiet.ThanhTien = item.MonAn.DonGia * item.SoLuong;
                    od.InsertSLBan(item.MonAn.MaMonAn, item.SoLuong);
                    chitietDao.Insert(chitiet);

                    total += (item.MonAn.DonGia.GetValueOrDefault(0) * item.SoLuong);
                //tenmonan += item.MonAn.TenMonAn + "<br />";
                //gia += item.MonAn.DonGia.GetValueOrDefault(0).ToString("N0") + "<br />";
            }

                od.InsertTotal(soDH, total);
            //try
            //{
            //    var content = System.IO.File.ReadAllText(Server.MapPath("/Template/MailOrder.html"));

            //    var toEmail_User = new UserDao().GetByName(session.TenDN).Email;
            //    string time = DateTime.Now.ToString("dd MMMM yyyy hh:mm:ss tt");

            //    content = content.Replace("{{SoDH}}", soDH.ToString());
            //    content = content.Replace("{{Time}}", time);
            //    content = content.Replace("{{CustomerName}}", shipName);
            //    content = content.Replace("{{Phone}}", mobile);
            //    content = content.Replace("{{Address}}", address);
            //    content = content.Replace("{{Email}}", toEmail_User);
            //    content = content.Replace("{{Item}}", tenmonan);
            //    content = content.Replace("{{Price}}", gia);
            //    content = content.Replace("{{Total}}", total.ToString("N0"));

            //    var mailHelper = new MailHelper();
            //    mailHelper.SendMail(toEmail_User, "Đơn hàng mới từ CD Food", content);
            //    Session[CartSession] = null;
            //}
            //catch (Exception ex)
            //{

            //    ViewBag.LoiThanhToan = ex;
            //    return View(cart);
            //}
            Session[CartSession] = null;
            return Redirect("/hoan-thanh");
        }

        public ActionResult DatHang_Success()
        {
            return View();
        }
    }
}