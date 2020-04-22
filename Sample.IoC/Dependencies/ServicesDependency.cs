using Microsoft.Extensions.DependencyInjection;
using Sample.IoC.Domain.Interfaces;
using Sample.IoC.Services;

namespace Sample.IoC.Dependencies
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IServiceClub, ServiceClub>();
        }
    }
}

