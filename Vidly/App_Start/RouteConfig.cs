using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           
            //attribute routing
            routes.MapMvcAttributeRoutes();

            //custom  Routes
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new {controller = "Movies", action = "ByReleaseDate" },
            //    //new {year = @"\d{4}", month = @"\d{2}"  //this says to use a year of 4 digits and month with 2
            //    new {year = @"2015|2016", month = @"\d{2}" //this limits year to 2015 or 2016
            //    });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional 
                });
        }
    }
}
