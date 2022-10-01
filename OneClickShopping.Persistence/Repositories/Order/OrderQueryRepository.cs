using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Domain.Entities;
using OneClickShopping.Persistence.Context;
using OneClickShopping.Persistence.Repositories.EF;

namespace OneClickShopping.Application.Repositories.Order
{
    public class OrderQueryRepository : EfQueryRepository<Orders>, IOrderQueryRepository
    {
        private readonly OneClickShoppingContext _oneClickShoppingContext;
        public OrderQueryRepository(OneClickShoppingContext oneClickShoppingContext) : base(oneClickShoppingContext)
        {
            _oneClickShoppingContext = oneClickShoppingContext;
        }
    }
}
