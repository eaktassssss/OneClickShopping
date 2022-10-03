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
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasMany(c => c.Products).WithOne(x => x.Categories);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.HasData(
               new Categories()
               {
                   Id = 1,
                   CategoryName = "Category 1",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,

               },
               new Categories()

               {
                   Id = 2,
                   CategoryName = "Category 2",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               },
               new Categories()

               {
                   Id = 3,
                   CategoryName = "Category 2",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
        }
    }
}
