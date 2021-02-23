using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcZodiac
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("WebForms/{weform}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                // defaults: new { controller = "AdminLogin", action = "LoginWMS2", id = UrlParameter.Optional },
                 defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional },
                //defaults: new { controller = " OnlineBooking_Areas/LoadPlanQuery", action = "Index", id = UrlParameter.Optional },
               
                namespaces: new string[] { "MvcZodiac.Controllers" }
            );
        }
    }
}