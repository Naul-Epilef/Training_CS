using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Suporte
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "MoviesByReleaseDate",
                "Movies/Released/{year}/{month}",
                new { controller = "Movies", action = "ByReleaseDate" },
                new { year = @"\d{4}", month = @"\d{2}"}
            );

            routes.MapRoute(
                "UserSpecified",
                "Users/{name}/{id}",
                new { controller = "Users", action = "Index", name = UrlParameter.Optional, id = UrlParameter.Optional },
                new { name = @"\d{40}", id = @"\d{4}" }
            );

            routes.MapRoute(
                "UsersListed",
                "Users/UsersList",
                new { controller = "Users", action = "UsersList" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
