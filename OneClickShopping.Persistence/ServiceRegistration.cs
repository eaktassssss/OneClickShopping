using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OneClickShopping.Application.Repositories.Order;
using OneClickShopping.Application.Repositories.Product;
using OneClickShopping.Persistence.Context;
using System.Configuration;

namespace OneClickShopping.Persistence
{
    public static  class ServiceRegistration
    {
        public static void AddPersistenceServiceReg(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OneClickShoppingContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IProductCommandRepository,ProductCommandRepository>();
            services.AddScoped<IProductQueryRepository,ProductQueryRepository>();
            services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
            services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();

        }
    }
}
