using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Pet_Clinic
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Doctors",
                url: "doctor",
                defaults: new { controller = "Doctors", action = "Index" }
            );
            routes.MapRoute(
                name: "Customers",
                url: "customer",
                defaults: new { controller = "Customers", action = "Index" }
            );
            routes.MapRoute(
                name: "Rooms",
                url: "room",
                defaults: new { controller = "Rooms", action = "Index" }
            );
            routes.MapRoute(
                name: "Appointments",
                url: "appointments",
                defaults: new { controller = "Appointments", action = "Index" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
          
        }
    }
}
