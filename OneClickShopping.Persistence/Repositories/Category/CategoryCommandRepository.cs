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
    public class CategoryCommandRepository:EfCommandRepository<Categories>,ICategoryCommandRepository
    {
        private readonly OneClickShoppingContext _oneClickShoppingContext;
        public CategoryCommandRepository(OneClickShoppingContext oneClickShoppingContext) : base(oneClickShoppingContext)
        {
            _oneClickShoppingContext = oneClickShoppingContext;
        }
    }
}
