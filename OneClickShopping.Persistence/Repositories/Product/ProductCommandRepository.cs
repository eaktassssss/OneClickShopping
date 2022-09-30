using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Application.Repositories.Product;
using OneClickShopping.Domain.Entities;
using OneClickShopping.Persistence.Context;
using OneClickShopping.Persistence.Repositories.EF;

namespace OneClickShopping.Application.Repositories.Product
{
    public  class ProductCommandRepository: EfCommandRepository<Products>,IProductCommandRepository
    {
        private readonly OneClickShoppingContext _oneClickShoppingContext;
        public ProductCommandRepository(OneClickShoppingContext oneClickShoppingContext) :base(oneClickShoppingContext)
        {
            _oneClickShoppingContext=oneClickShoppingContext;
        }
    }
}
