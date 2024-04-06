using Domain.Service;
using Domain.Service.Interface;

namespace Microsoft.Extensions.DependencyInjection
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
