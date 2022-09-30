using Microsoft.EntityFrameworkCore;
using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Domain.Entities.Common;
using OneClickShopping.Persistence.Context;
using System.Linq.Expressions;

namespace OneClickShopping.Persistence.Repositories.EF
{
    public class EfQueryRepository<T> : IEfQueryRepository<T> where T :BaseEntity
    {
        readonly OneClickShoppingContext _shoppingContext;
        public EfQueryRepository(OneClickShoppingContext shoppingContext)
        {
            _shoppingContext = shoppingContext;
        }
        public DbSet<T> Table => _shoppingContext.Set<T>();
        public IQueryable<T> GetAll(bool tracking)
        {

            if (!tracking)
                return Table.AsNoTracking();
            else
                return Table.AsQueryable();
        }
        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, bool tracking)
        {

            if (!tracking)
                return Table.Where(expression).AsNoTracking();
            else
                return Table.Where(expression).AsQueryable();

        }
        public async Task<T> GetByIdAsync(int id, bool tracking)
        {

            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();

           return await query.FirstOrDefaultAsync(x=> x.Id==id);
        }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();

            return await query.FirstOrDefaultAsync(expression);
        }
    }
}
