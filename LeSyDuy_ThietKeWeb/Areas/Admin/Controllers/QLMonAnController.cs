using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeSyDuy_ThietKeWeb.Areas.Admin.Controllers
{
    public class QLMonAnController : BaseAdminController
    {
        // GET: Admin/QLMonAn
        public ActionResult DSMonAn(string searchMonAn, int page = 1, int pageSize = 5)
        {
            var dao = new AdminDao();
            var model = dao.ListMonAn_AllPaging(searchMonAn, page, pageSize);
            ViewBag.SearchMonAn = searchMonAn;
            return View(model);
        }

        //----------------Thêm khách món ăn mới--------------------//

        [HttpGet]
        public ActionResult Insert()
        {
            SetViewBag();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Insert(MONAN monan)
        {
            if (ModelState.IsValid)
            {
                var dao = new AdminDao();
                if (dao.CheckTenMonAn(monan.TenMonAn))
                {
                    ModelState.AddModelError("", "Tên món ăn đã tồn tại");
                }
                else
                {
                    int id = dao.InsertMonAn(monan);
                    if (id > 0)
                    {
                        return Redirect("/dsmonan");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm không thành công!");
                    }
                }
            }
            SetViewBag();
            return View();
        }

        //----------------Chỉnh sửa thông tin món ăn--------------------//

        public ActionResult Update(int id)
        {
            var monan = new AdminDao().GetByMaMonAn(id);
            SetViewBag(monan.MaMonAn);
            return View(monan);
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Update(MONAN monan)
        {
            if (ModelState.IsValid)
            {
                var dao = new AdminDao();
                if(dao.CheckTenMonAnUpdate(monan.TenMonAn, monan.MaMonAn))
                {
                    ModelState.AddModelError("", "Tên món ăn đã tồn tại!");
                }
                else
                {
                    bool result = dao.UpdateMonAn(monan);
                    if (result)
                    {
                        return Redirect("/dsmonan");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Chỉnh sửa không thành công!");
                    }
                }
            }
            SetViewBag(monan.MaMonAn);
            return View();
        }

        //----------------Xóa món ăn--------------------//

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new AdminDao().DeleteMonAn(id);
            return RedirectToAction("DSMonAn", "QLMonAn");
        }

        public void SetViewBag(int? selectedID = null)
        {
            var dao = new AdminDao();
            ViewBag.MaCD = new SelectList(dao.ListMaCD(), "MaCD", "MaCD", selectedID);
        }
    }
}