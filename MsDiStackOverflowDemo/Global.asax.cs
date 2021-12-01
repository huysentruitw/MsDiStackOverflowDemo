using Microsoft.Extensions.DependencyInjection;
using MsDiStackOverflowDemo.DependencyInjection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MsDiStackOverflowDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var services = new ServiceCollection();
            services.AddServicesAndControllers();
            var serviceProvider = services.BuildServiceProvider();
            DependencyResolver.SetResolver(new MsDiMvcDependencyResolver(serviceProvider));
        }
    }
}
