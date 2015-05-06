using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectXXX
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "home",
                defaults: new { controller = "Home", action = "Index" }
                );

            routes.MapRoute(
                name: "EventList",
                url: "eventlist",
                defaults: new { controller = "Events", action = "EventList" }
                );

            routes.MapRoute(
                name: "Description",
                url: "description/{id}",
                defaults: new { controller = "Events", action = "Description", id = 0 }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}