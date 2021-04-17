using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using MyBlogDev.Core.Utilities.IoC;

namespace MyBlogDev.Core.DependencyResolvers
{
    public class CoreModule:ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
