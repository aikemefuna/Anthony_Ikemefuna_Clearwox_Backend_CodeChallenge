using ClearwoxCodeChallenge.Application.Interfaces;
using ClearwoxCodeChallenge.Domain.Settings;
using ClearwoxCodeChallenge.Infrastructure.Shared.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClearwoxCodeChallenge.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
        }
    }
}
