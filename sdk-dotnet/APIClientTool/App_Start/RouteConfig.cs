using System.Web.Mvc;
using System.Web.Routing;

namespace APIClientTool
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "formw2", action = "formw2return", id = UrlParameter.Optional }
            );
        }
    }
}
