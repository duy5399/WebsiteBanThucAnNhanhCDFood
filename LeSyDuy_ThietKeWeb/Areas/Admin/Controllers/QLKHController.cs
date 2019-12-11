using LeSyDuy_ThietKeWeb.Common;
using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeSyDuy_ThietKeWeb.Areas.Admin.Controllers
{
    public class QLKHController : BaseAdminController
    {
        // GET: Admin/QLKH
        public ActionResult DSKH(string searchKH, int page = 1, int pageSize = 5)
        {
            var dao = new AdminDao();
            var model = dao.ListKH_AllPaging(searchKH, page, pageSize);
            ViewBag.SearchKH = searchKH;
            return View(model);
        }

        //----------------Thêm khách hàng mới--------------------//

        [HttpGet]
        public ActionResult Insert()
        {
            SetSex();
            return View();
        }

        [HttpPost]
        public ActionResult Insert(KHACHHANG kh)
        {
            if (ModelState.IsValid)
            {
                var dao = new AdminDao();
                if (dao.CheckTenDN(kh.TenDN))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.CheckEmail(kh.Email))
                {
                    ModelState.AddModelError("", "Email đã sử dụng cho 1 tài khoản khác");
                }
                else if (dao.CheckSDT(kh.DienThoaiKH))
                {
                    ModelState.AddModelError("", "Số điện thoại đã sử dụng cho 1 tài khoản khác");
                }
                else
                {
                    var encryptedMD5Pass = Encryptor.MD5Hash(kh.MatKhau);
                    kh.MatKhau = encryptedMD5Pass;
                    SetSex(kh.GioiTinh);    
                    int id = dao.InsertKH(kh);
                    if (id > 0)
                    {
                        return Redirect("/dskhachhang");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm không thành công!");
                    }
                }
            }
            SetSex();
            return View();
        }

        //----------------Chỉnh sửa thông tin khách hàng--------------------//

        public ActionResult Update(int id)
        {
            var kh = new AdminDao().GetByID(id);
            SetSex();
            return View(kh);
        }

        [HttpPost]
        public ActionResult Update(KHACHHANG kh)
        {
            if (ModelState.IsValid)
            {
                var dao = new AdminDao();
                if (dao.CheckTenDNUpdate(kh.TenDN, kh.MaKH) )
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.CheckEmailUpdate(kh.Email, kh.MaKH))
                {
                    ModelState.AddModelError("", "Email đã sử dụng cho 1 tài khoản khác");
                }
                else if (dao.CheckSDTUpdate(kh.DienThoaiKH, kh.MaKH))
                {
                    ModelState.AddModelError("", "Số điện thoại đã sử dụng cho 1 tài khoản khác");
                }
                else
                {
                    SetSex(kh.GioiTinh);
                    bool result = dao.UpdateKH(kh);
                    if (result)
                    {

                        return Redirect("/dskhachhang");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Chỉnh sửa không thành công!");
                    }
                }
            }
            SetSex();
            return View();
        }

        //----------------Xóa khách hàng--------------------//

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new AdminDao().DeleteKH(id);
            return RedirectToAction("DSKH", "QLKH");
        }

        public void SetSex(string sl = null)
        {
            var temp = new SelectList(new List<SelectListItem>
            {
                new SelectListItem{Text ="Nam", Value="Nam"},
                new SelectListItem{Text ="Nữ", Value="Nữ"}
            }, "Value", "Text", sl);
            ViewBag.GioiTinh = temp;
        }
    }
}