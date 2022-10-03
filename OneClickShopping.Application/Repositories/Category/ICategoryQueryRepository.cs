using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Repositories.Category
{
    public  interface ICategoryQueryRepository:IEfQueryRepository<Categories>
    {
    }
}
