using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HR.LeaveManagement.Application
{
    public static class ApplicationServiceRegistration
    {
        //Adds automapper and mdiatr to the project
        //setup the registration class so that when the calling application needs access to these,they can 
        //just call this method instead of trying to do all of these by itself.
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(options => {
                options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            return services;

        }
    }
}
