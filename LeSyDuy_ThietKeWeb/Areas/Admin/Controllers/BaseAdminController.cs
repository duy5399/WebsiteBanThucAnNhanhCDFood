using LeSyDuy_ThietKeWeb.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LeSyDuy_ThietKeWeb.Areas.Admin.Controllers
{
    public class BaseAdminController : Controller
    {
        // GET: Admin/Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (AdminLogin)Session[CommonConstants.SESSION_ADMIN];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "AdminLogin", action = "AdminLogin", Area ="Admin" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}