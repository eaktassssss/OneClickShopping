using Microsoft.EntityFrameworkCore;
using OneClickShopping.Application.Repositories.EF;
using OneClickShopping.Persistence.Context;

namespace OneClickShopping.Persistence.Repositories.EF
{
    public class EfCommandRepository<T> : IEfCommandRepository<T> where T : class
    {
        readonly OneClickShoppingContext _shoppingContext;
        public EfCommandRepository(OneClickShoppingContext shoppingContext)
        {
            _shoppingContext = shoppingContext;
        }
        public DbSet<T> Table => _shoppingContext.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            if (entity == null)
                return null;
            {
                await Table.AddAsync(entity);
                await _shoppingContext.SaveChangesAsync();
                return entity;
            }
        }

        public async Task<T> RemoveAsync(T entity)
        {
            if (entity == null)
                return null;
            else
            {
                Table.Remove(entity);
                await _shoppingContext.SaveChangesAsync();
                return entity;
            }
        }

        public async Task<T> RemoveAsync(string id)
        {
            var entity = await Table.FindAsync(id);
            if (entity == null)
                return null;
            else
            {
                Table.Remove(entity);
                await _shoppingContext.SaveChangesAsync();
                return entity;

            }

        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
                return null;
            else
            {
                Table.Update(entity);
                await _shoppingContext.SaveChangesAsync();
                return entity;

            }
        }
    }
}
