using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace irakligdev
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional }
            );
            

            routes.MapRoute(
                name: "Start",
                url: "Main/Start/{id}",
                defaults: new { controller = "Main", action = "Start", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login",
                url: "Main/Login/{id}",
                defaults: new { controller = "Main", action = "Login", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Register",
                url: "Main/Register/{id}",
                defaults: new { controller = "Main", action = "Register", id = UrlParameter.Optional }
            );

        }
    }
}
