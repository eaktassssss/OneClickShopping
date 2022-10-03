using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OneClickShopping.Domain.Entities;
using OneClickShopping.Persistence.Context.Configurations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Persistence.Context
{
    public class OneClickShoppingContext : DbContext
    {

        public OneClickShoppingContext(DbContextOptions option) : base(option)
        {
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
        }
    }
}
