using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Domain.Entities;

namespace OneClickShopping.Application.Repositories.Product
{
    public  interface IProductCommandRepository:IEfCommandRepository<Products>
    {
    }
}
