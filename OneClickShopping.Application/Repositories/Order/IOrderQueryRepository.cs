using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Domain.Entities;

namespace OneClickShopping.Application.Repositories.Order
{
    public interface IOrderQueryRepository : IEfQueryRepository<Orders>
    {
    }
}
