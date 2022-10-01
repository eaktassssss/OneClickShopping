using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace OneClickShopping.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServiceReg(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistration));
        }
    }
}
