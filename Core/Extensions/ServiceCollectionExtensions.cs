using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }

            return  ServiceTool.Create(serviceCollection);
        }
        //IServiceColection API bağımlılıklarını eklediğimiz servistir.
    }

    //EKLENEN TUM INJECTIONLARI BIR ARADA TUTMAK ICIN UYGULANAN ISLEM
}
