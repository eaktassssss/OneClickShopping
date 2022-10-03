using OneClickShopping.Application.Repositories.Category;
using OneClickShopping.Domain.Entities;
using OneClickShopping.Persistence.Context;
using OneClickShopping.Persistence.Repositories.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Persistence.Repositories.Category
{
    public class CategoryQueryRepository:EfQueryRepository<Categories>,ICategoryQueryRepository
    {
        private readonly OneClickShoppingContext _oneClickShoppingContext;
        public CategoryQueryRepository(OneClickShoppingContext oneClickShoppingContext) : base(oneClickShoppingContext)
        {
            _oneClickShoppingContext = oneClickShoppingContext;
        }
    }
}
