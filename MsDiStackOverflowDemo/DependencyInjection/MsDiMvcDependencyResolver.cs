using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace MsDiStackOverflowDemo.DependencyInjection
{
    public sealed class MsDiMvcDependencyResolver : IDependencyResolver
    {
        private const string HttpContextKey = "perRequestServiceScope";

        private readonly IServiceProvider _serviceProvider;

        public MsDiMvcDependencyResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object GetService(Type serviceType)
        {
            if (typeof(IController).IsAssignableFrom(serviceType))
            {
                return ChildScope.ServiceProvider.GetRequiredService(serviceType);
            }

            return ChildScope.ServiceProvider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ChildScope.ServiceProvider.GetServices(serviceType);
        }

        private IServiceScope ChildScope
        {
            get
            {
                var childScope = HttpContext.Current.Items[HttpContextKey] as IServiceScope;

                if (childScope == null)
                {
                    HttpContext.Current.Items[HttpContextKey] = childScope = _serviceProvider.CreateScope();
                    HttpContext.Current.AddOnRequestCompleted(ctx =>
                    {
                        childScope.Dispose();
                    });
                }

                return childScope;
            }
        }
    }
}