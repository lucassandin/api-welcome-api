using Domain.WelcomeContext.Interface;
using Domain.WelcomeContext.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.WelcomeContext
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddSingleton<IWelcomeService, WelcomeService>();

            return services;
        }
    }
}
