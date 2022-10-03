using OneClickShopping.Application.Repositories.Category;
using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Domain.Entities;
using OneClickShopping.Persistence.Context;
using OneClickShopping.Persistence.Repositories.EF;

namespace OneClickShopping.Application.Repositories.Product
{
    public class ProductQueryRepository : EfQueryRepository<Products>, IProductQueryRepository
    {
        private readonly OneClickShoppingContext _oneClickShoppingContext;
        private readonly ICategoryQueryRepository _categoryQueryRepository;
        public ProductQueryRepository(OneClickShoppingContext oneClickShoppingContext, ICategoryQueryRepository categoryQueryRepository) : base(oneClickShoppingContext)
        {
            _oneClickShoppingContext = oneClickShoppingContext;
            _categoryQueryRepository = categoryQueryRepository;
        }
    }
}
