using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlShortener
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // TODO: add a routing rule that matches shortUrl of a Url object, and then redirects users to longUrl
            //       hint, use RedirectPermanent in a controller
            //       localhost/shortUrl -> redirect to longUrl
            // TODO: do not allow users to enter a date from views, instead auto generate when a row is inserted
            // TODO: remove all unnecessary views from your Views folder
            // TODO: modify the layout of all the views (remember _Layout & Shared)
            // TODO: make views colorful (make them pretty regardless of your workload)

            routes.MapRoute(
                name: "URL",
                url: "RedirectTo/{shortURL}",
                defaults: new { controller = "Home", action = "RedirectToLong", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );


        }
    }
}
