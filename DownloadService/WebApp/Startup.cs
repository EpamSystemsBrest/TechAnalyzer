using System.Web.Http;
using DownloadService.Infrastructure;
using Ninject;
using Owin;

namespace DownloadService
{
    public class Startup
    {
        private readonly Statistics _statistics;

        public Startup(Statistics statistics)
        {
            _statistics = statistics;
        }

        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}",
                defaults: new {controller = RouteParameter.Optional}
                );

            var kernel = new StandardKernel();
            kernel.Bind<Statistics>().ToConstant(_statistics).InThreadScope();
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
            appBuilder.UseWebApi(config);
        }
    }
}
