using System.Web.Http;

namespace WebCount
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //    );

            config.Routes.MapHttpRoute(
                name: "GetAll",
                routeTemplate: "api/{controller}",
                defaults: new { action = "Get" }
                );

            config.Routes.MapHttpRoute(
                name: "Get",
                routeTemplate: "api/{controller}/{id}"
                );

            config.Routes.MapHttpRoute(
                name: "Add",
                routeTemplate: "api/{controller}/add/{id}"
                );
        }
    }
}