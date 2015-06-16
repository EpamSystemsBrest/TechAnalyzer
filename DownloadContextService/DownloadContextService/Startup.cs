using System.Web.Http;
using Owin;

namespace ServiceLibrary
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}",
                defaults: new { controller = RouteParameter.Optional }
                );

            appBuilder.UseWebApi(config);
        }
    }
}
