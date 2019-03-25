using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MenuApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            
            routes.MapRoute(" Contact", "Contact", new { controller = "Home", action = "Contact" });
            routes.MapRoute(" About", "About", new { controller = "Home", action = "About" });
            routes.MapRoute(
                name: "Edit", 
                url: "Menu/{id}-Edit", 
                defaults: new { controller = "Home", action = "Edit", id = UrlParameter.Optional });
            routes.MapRoute(
                name: "Delete",
                url: "Menu/{id}-Delete",
                defaults: new { controller = "Home", action = "Delete", id = UrlParameter.Optional });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
