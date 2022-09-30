using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Domain.Entities;
using OneClickShopping.Persistence.Context;
using OneClickShopping.Persistence.Repositories.EF;

namespace OneClickShopping.Application.Repositories.Product
{
    public class ProductQueryRepository : EfQueryRepository<Products>, IProductQueryRepository
    {
        private readonly OneClickShoppingContext _oneClickShoppingContext;
        public ProductQueryRepository(OneClickShoppingContext oneClickShoppingContext) : base(oneClickShoppingContext)
        {
            _oneClickShoppingContext = oneClickShoppingContext;
        }
    }
}
