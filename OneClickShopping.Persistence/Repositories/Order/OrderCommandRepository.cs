using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Domain.Entities;
using OneClickShopping.Persistence.Context;
using OneClickShopping.Persistence.Repositories.EF;

namespace OneClickShopping.Application.Repositories.Order
{
    public  class OrderCommandRepository: EfCommandRepository<Orders>,IOrderCommandRepository
    {
        private readonly OneClickShoppingContext _oneClickShoppingContext;
        public OrderCommandRepository(OneClickShoppingContext oneClickShoppingContext) :base(oneClickShoppingContext)
        {
            _oneClickShoppingContext=oneClickShoppingContext;
        }
    }
}
