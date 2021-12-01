using Microsoft.Extensions.DependencyInjection;
using MsDiStackOverflowDemo.Services;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MsDiStackOverflowDemo.DependencyInjection
{
    internal static class ServiceCollectionExtensions
    {
        public static void AddServicesAndControllers(this IServiceCollection services)
        {
            services.AddServices();
            services.AddControllers();
        }

        private static void AddServices(this IServiceCollection services)
        {
            foreach (Type serviceType in typeof(ServiceCollectionExtensions).Assembly.GetTypes()
                .Where(type => !type.IsAbstract && typeof(IService).IsAssignableFrom(type)))
            {
                services.AddTransient(serviceType);
            }
        }

        private static void AddControllers(this IServiceCollection services)
        {
            foreach (Type controllerType in typeof(ServiceCollectionExtensions).Assembly.GetTypes()
                .Where(type => !type.IsAbstract && typeof(IController).IsAssignableFrom(type)))
            {
                services.AddTransient(controllerType);
            }
        }
    }
}