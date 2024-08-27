using CleanArchitecture.Application.Services.CustomerService;
using Microsoft.Extensions.DependencyInjection;


namespace CleanArchitecture.Application
{
    public static class ApplicationConfiguration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }

}
