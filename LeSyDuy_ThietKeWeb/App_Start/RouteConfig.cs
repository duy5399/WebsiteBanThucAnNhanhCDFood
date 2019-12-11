using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LeSyDuy_ThietKeWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //------------------Admin----------------//
            routes.MapRoute(
                name: "Dang Nhap Admin",
                url: "login-admin",
                defaults: new { controller = "AdminLogin", action = "AdminLoginView", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Thong tin admin",
                url: "thong-tin-admin",
                defaults: new { controller = "ThongTinAdmin", action = "TTAdmin", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Dang Xuat Admin",
                url: "logout-admin",
                defaults: new { controller = "AdminLogin", action = "Logout", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            //Khách hàng
            routes.MapRoute(
                name: "Danh sach khach hang",
                url: "dskhachhang",
                defaults: new { controller = "QLKH", action = "DSKH", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Them moi khach hang",
                url: "them-moi-khach-hang",
                defaults: new { controller = "QLKH", action = "Insert", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Chinh sua khach hang",
                url: "chinh-sua-khach-hang",
                defaults: new { controller = "QLKH", action = "Update", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            //Món ăn
            routes.MapRoute(
                name: "Danh sach mon an",
                url: "dsmonan",
                defaults: new { controller = "QLMonAn", action = "DSMonAn", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Them moi mon an",
                url: "them-moi-mon-an",
                defaults: new { controller = "QLMonAn", action = "Insert", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Chinh sua mon an",
                url: "chinh-sua-mon-an",
                defaults: new { controller = "QLMonAn", action = "Update", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            //Nhân viên
            routes.MapRoute(
                name: "Danh sach nhan vien",
                url: "dsnhanvien",
                defaults: new { controller = "QLNV", action = "DSNV", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Them moi nhan vien",
                url: "them-moi-nhan-vien",
                defaults: new { controller = "QLNV", action = "Insert", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Chinh sua nhan vien",
                url: "chinh-sua-nhan-vien",
                defaults: new { controller = "QLNV", action = "Update", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            //Đon hàng
            routes.MapRoute(
                name: "Quan ly don hang",
                url: "quan-ly-don-hang",
                defaults: new { controller = "QLDH", action = "DSDH", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Chi tiet don hang",
                url: "chi-tiet-don-hang/{SoDH}",
                defaults: new { controller = "QLDH", action = "ChiTietDH", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Phe duyet don hang",
                url: "phe-duyet-don-hang/{SoDH}",
                defaults: new { controller = "QLDH", action = "PheDuyetDH", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            routes.MapRoute(
                name: "Quan ly gop y",
                url: "quan-ly-gop-y",
                defaults: new { controller = "QLGY", action = "DSGY", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            ).DataTokens = new RouteValueDictionary(new { area = "Admin" });

            //--------------------User-----------------//

            //Login
            routes.MapRoute(
                name: "Dang Nhap",
                url: "dang-nhap",
                defaults: new { controller = "Login", action = "LoginView", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Dang Ky",
                url: "dang-ky",
                defaults: new { controller = "Login", action = "Register", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Dang Xuat",
                url: "logout-user",
                defaults: new { controller = "Login", action = "Logout", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Đang ky thanh cong",
                url: "dang-ky-thanh-cong",
                defaults: new { controller = "Login", action = "Congrats", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            //cart
            routes.MapRoute(
                name: "Thuc Don",
                url: "thuc-don",
                defaults: new { controller = "Cart", action = "ThucDon", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Chi tiet mon an",
                url: "chi-tiet/{MaCD}/{TenMonAn}/{MaMonAn}",
                defaults: new { controller = "Cart", action = "DetailMonAn", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Danh gia mon an",
                url: "danh-gia/{TenMonAn}/{MaMonAn}",
                defaults: new { controller = "Cart", action = "DanhGiaMonAn", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Form danh gia mon an",
                url: "form-danh-gia/{TenMonAn}/{MaMonAn}",
                defaults: new { controller = "Cart", action = "FormDanhGiaMonAn", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Add Cart",
                url: "them-gio-hang",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Cart",
                url: "gio-hang",
                defaults: new { controller = "Cart", action = "GioHang", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );

            routes.MapRoute(
                name: "Thanh Toan",
                url: "thanh-toan",
                defaults: new { controller = "Cart", action = "ThanhToan", id = UrlParameter.Optional },
                namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
            );
            routes.MapRoute(
               name: "Thanh Toan Thanh Cong",
               url: "hoan-thanh",
               defaults: new { controller = "Cart", action = "DatHang_Success", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );

            //home
            routes.MapRoute(
               name: "Trang chu",
               url: "trang-chu",
               defaults: new { controller = "Home", action = "HomePage", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );
            routes.MapRoute(
               name: "Gioi thieu",
               url: "gioi-thieu",
               defaults: new { controller = "Home", action = "Introduction", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );

            //logged
            routes.MapRoute(
               name: "Lich su mua hang",
               url: "lich-su-mua-hang/{MaKH}",
               defaults: new { controller = "Logged", action = "LSMuaHang", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );

            routes.MapRoute(
               name: "Chi tiet mua hang",
               url: "chi-tiet-mua-hang/{SoDH}",
               defaults: new { controller = "Logged", action = "ChiTietMuaHang", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );

            routes.MapRoute(
               name: "Doi mat khau",
               url: "doi-mat-khau",
               defaults: new { controller = "Logged", action = "ChangePassword", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );
            routes.MapRoute(
               name: "Doi mat khau thanh cong",
               url: "doi-mk-thanh-cong",
               defaults: new { controller = "Logged", action = "CP_Success", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );
            routes.MapRoute(
               name: "Gop y",
               url: "gop-y",
               defaults: new { controller = "Logged", action = "GopY", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );
            routes.MapRoute(
               name: "Gop y thanh cong",
               url: "gop-y-thanh-cong",
               defaults: new { controller = "Logged", action = "GY_Success", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );

            routes.MapRoute(
               name: "Thong tin khach hang",
               url: "thong-tin-khach-hang",
               defaults: new { controller = "Logged", action = "ThongTinUser", id = UrlParameter.Optional },
               namespaces: new[] { "LeSyDuy_ThietKeWeb.Controllers" }
           );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "HomePage", id = UrlParameter.Optional }
                //defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            ) ;
        }
    }
}
