using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Repositories.EF
{
    public interface IEfCommandRepository<T> : IRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<T> RemoveAsync(T entity);
        Task<T> RemoveAsync(string id);
        Task<T> UpdateAsync(T entity);
    }
}
