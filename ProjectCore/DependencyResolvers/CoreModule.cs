using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ProjectCore.CrossCuttingConcerns.Caching;
using ProjectCore.CrossCuttingConcerns.Caching.Microsoft;
using ProjectCore.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCore.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddMemoryCache();
            serviceDescriptors.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceDescriptors.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
