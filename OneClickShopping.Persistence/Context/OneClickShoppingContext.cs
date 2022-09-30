using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OneClickShopping.Domain.Entities;
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

            #region Product
            modelBuilder.Entity<Products>().HasOne(c => c.Categories).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<Products>().HasKey(x => x.Id);
            modelBuilder.Entity<Products>().Property(x => x.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Products>().Property(x => x.Price).IsRequired();
            modelBuilder.Entity<Products>().Property(x => x.CurrentQty).IsRequired();
            modelBuilder.Entity<Products>().Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Products>().Property(x => x.IsDeleted).HasDefaultValue(false);
            #endregion

            #region Category
            modelBuilder.Entity<Categories>().HasMany(c => c.Products).WithOne(x => x.Categories);
            modelBuilder.Entity<Categories>().HasKey(x => x.Id);
            modelBuilder.Entity<Categories>().Property(x => x.CategoryName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Products>().Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Products>().Property(x => x.IsDeleted).HasDefaultValue(false);
            #endregion
        }
    }
}
