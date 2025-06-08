
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetBoiler.Application.Interfaces;
using NetBoiler.Infrastructure.ExternalServices;
using NetBoiler.Infrastructure.Persistence;

namespace NetBoiler.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static class ServiceCollectionExtensions
        {
            public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
            {
                services.AddHttpClient();
                services.AddScoped<ITextFetcher, TextFetcherService>();
                services.AddScoped<ITextRepository, TextRepository>();
                return services;
            }
        }
    }
}