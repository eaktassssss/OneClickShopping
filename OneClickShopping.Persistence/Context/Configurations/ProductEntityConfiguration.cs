using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OneClickShopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickShopping.Persistence.Context.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {

            builder.HasOne(c => c.Categories).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.CurrentQty).IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.StockStatus).HasDefaultValue(false);
            builder.Property(x => x.Description);
            builder.HasData(
                new Products()
                {
                    Id = 1,
                    Name = "Product 1",
                    Price = 1200,
                    CurrentQty = 800,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Description = "Example Product Description 1",
                    CategoryId = 2,
                    StockStatus = true
                },
                new Products()

                {
                    Id = 2,
                    Name = "Product 2",
                    Price = 1300,
                    CurrentQty = 400,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Description = "Example Product Description 2",
                    CategoryId = 2,
                    StockStatus = true
                },
                new Products()

                {
                    Id = 3,
                    Name = "Product 3",
                    Price = 1400,
                    CurrentQty = 300,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Description = "Example Product Description 3",
                    CategoryId = 2,
                    StockStatus = true
                });
        }
    }
}
