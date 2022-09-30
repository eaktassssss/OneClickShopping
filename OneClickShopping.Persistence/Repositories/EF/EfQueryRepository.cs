using Microsoft.EntityFrameworkCore;
using OneClickShopping.Application.Repositories;
using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Persistence.Repositories.EF
{
    public class EfQueryRepository<T> : IEfQueryRepository<T> where T : class
    {
        readonly OneClickShoppingContext _shoppingContext;
        public EfQueryRepository(OneClickShoppingContext shoppingContext)
        {
            _shoppingContext = shoppingContext;
        }
        public DbSet<T> Table => _shoppingContext.Set<T>();
        public IQueryable<T> GetAll()
        {
            return Table.AsNoTracking();
        }
        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression).AsNoTracking();
        }
        public async Task<T> GetByIdAsync(string id)
        {
            return await Table.FindAsync(id);
        }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.FirstOrDefaultAsync(expression);
        }
    }
}
