using Microsoft.Extensions.DependencyInjection;
using ProjectCore.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceDescriptors, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceDescriptors);
            }
            return ServiceTool.Create(serviceDescriptors);
        }
    }
}
