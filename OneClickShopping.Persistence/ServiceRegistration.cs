using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OneClickShopping.Persistence.Context;
using System.Configuration;

namespace OneClickShopping.Persistence
{
    public static  class ServiceRegistration
    {
        public static void AddPersistenceServiceReg(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OneClickShoppingContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
