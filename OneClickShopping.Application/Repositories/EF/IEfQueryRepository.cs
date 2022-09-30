using OneClickShopping.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Repositories.EF
{
    public interface IEfQueryRepository<T> : IRepository<T> where T  :BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = false);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression, bool tracking=false);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking=false);
        Task<T> GetByIdAsync(int id, bool tracking=false);
    }
}
