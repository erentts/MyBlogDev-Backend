using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace MyBlogDev.Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection collection);
    }
}
