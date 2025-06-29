using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WealthTracker.Repository.Extensions;
using WealthTracker.Services.Services;
using WealthTracker.Services.Services.Interfaces;

namespace WealthTracker.Services.Extensions
{
    public static class ServiceServiceExtensions
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserAccountService, UserAccountService>();
            services.AddRepositoryServices(configuration);
            return services;

        }
    }
}
