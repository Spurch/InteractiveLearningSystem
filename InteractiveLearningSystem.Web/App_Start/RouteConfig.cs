using InteractiveLearningSystem.Web.App_Start.RouteConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace InteractiveLearningSystem.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Administrator",
                url: "{controller}/{action}",
                defaults: new { area = "Administrator", controller = "Index", action = "Index" },
                constraints: new { authenticated = new AuthenticatedConstraint() }
            );

            routes.MapRoute(
                name: "Groups",
                url: "{controller}/Group/Details/{id}",
                defaults: new { controller = "Group", action = "Details" },
                constraints: new { id = @"\d+" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
                constraints: new { controller = new NotEqual("Administrator") }
            );
        }
    }
}
