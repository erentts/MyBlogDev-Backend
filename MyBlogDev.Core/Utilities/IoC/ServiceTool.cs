using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Core;
using Microsoft.Extensions.DependencyInjection;

namespace MyBlogDev.Core.Utilities.IoC
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
