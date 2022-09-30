using Microsoft.EntityFrameworkCore;
using OneClickShopping.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Application.Repositories.EF
{
    public interface IRepository<T> where T:BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
