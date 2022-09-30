using OneClickShopping.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Repositories.EF
{
    public interface IEfCommandRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<T> RemoveAsync(T entity);
        Task<T> RemoveAsync(string id);
        Task<T> UpdateAsync(T entity);
    }
}
