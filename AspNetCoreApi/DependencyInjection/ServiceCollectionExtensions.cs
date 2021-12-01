using AspNetCoreApi.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AspNetCoreApi.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            foreach (Type serviceType in typeof(ServiceCollectionExtensions).Assembly.GetTypes()
                .Where(type => !type.IsAbstract && typeof(IService).IsAssignableFrom(type)))
            {
                services.AddTransient(serviceType);
            }
        }
    }
}
