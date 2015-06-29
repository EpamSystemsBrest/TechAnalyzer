using System.Web.Http;
using DownloadService.Infrastructure;
using Ninject;
using Owin;

namespace DownloadService
{
    public class Startup
    {

        public void Configuration(IAppBuilder appBuilder, params object[] singletons)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}",
                defaults: new {controller = RouteParameter.Optional}
                );

            var kernel = new StandardKernel();
            foreach (var singleton in singletons)
            {
                kernel.Bind(singleton.GetType()).ToConstant(singleton).InThreadScope();  
            }
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
            appBuilder.UseWebApi(config);
        }
    }
}
