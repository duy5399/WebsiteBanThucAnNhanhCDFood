using LeSyDuy_ThietKeWeb.Common;
using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace LeSyDuy_ThietKeWeb.Areas.Admin.Controllers
{
    public class QLNVController : BaseAdminController
    {
        // GET: Admin/QLNV

        public ActionResult DSNV(string searchNV, int page = 1, int pageSize = 5)
        {
            var dao = new AdminDao();
            var model = dao.ListNV_AllPaging(searchNV, page, pageSize);
            ViewBag.SearchNV = searchNV;
            return View(model);
        }

        //----------------Thêm nhân viên mới--------------------//

        [HttpGet]
        public ActionResult Insert()
        {
            SetSex();
            return View();
        }

        [HttpPost]
        public ActionResult Insert(NHANVIEN nv)
        {
            if (ModelState.IsValid)
            {
                var dao = new AdminDao();
                if (dao.CheckEmailNV(nv.Email))
                {
                    ModelState.AddModelError("", "Email đã sử dụng cho 1 nhân viên khác");
                }
                else if (dao.CheckSDTNV(nv.DienThoaiNV))
                {
                    ModelState.AddModelError("", "Số điện thoại đã sử dụng cho 1 nhân viên khác");
                }
                else
                {
                    SetSex(nv.GioiTinh);
                    int id = dao.InsertNV(nv);
                    if (id > 0)
                    {
                        return Redirect("/dsnhanvien");
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

        //----------------Chỉnh sửa thông tin nhân viên--------------------//

        public ActionResult Update(int id)
        {
            SetSex();
            var nv = new AdminDao().GetByMaNV(id);
            return View(nv);
        }

        [HttpPost]
        public ActionResult Update(NHANVIEN nv)
        {
            if (ModelState.IsValid)
            {
                var dao = new AdminDao();
                if (dao.CheckEmailNVUpdate(nv.Email, nv.MaNV))
                {
                    ModelState.AddModelError("", "Email đã sử dụng cho 1 nhân viên khác");
                }
                else if (dao.CheckSDTNVUpdate(nv.DienThoaiNV, nv.MaNV))
                {
                    ModelState.AddModelError("", "Số điện thoại đã sử dụng cho 1 nhân viên khác");
                }
                else
                {
                    SetSex(nv.GioiTinh);
                    bool result = dao.UpdateNV(nv);
                    if (result)
                    {

                        return Redirect("/dsnhanvien");
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

        //----------------Xóa nhân viên--------------------//

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new AdminDao().DeleteNV(id);
            return RedirectToAction("DSNV", "QLNV");
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