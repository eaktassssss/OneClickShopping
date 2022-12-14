// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneClickShopping.Persistence.Context;

#nullable disable

namespace OneClickShopping.Persistence.Migrations.SQL
{
    [DbContext(typeof(OneClickShoppingContext))]
    partial class OneClickShoppingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OneClickShopping.Domain.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(764));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Category 1",
                            CreatedDate = new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(1135),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Category 2",
                            CreatedDate = new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(1138),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Category 2",
                            CreatedDate = new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(1139),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("OneClickShopping.Domain.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 10, 3, 0, 21, 33, 747, DateTimeKind.Local).AddTicks(9423));

                    b.Property<int>("CurrentQty")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("StockStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(91),
                            CurrentQty = 800,
                            Description = "Example Product Description 1",
                            IsDeleted = false,
                            Name = "Product 1",
                            Price = 1200m,
                            StockStatus = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(94),
                            CurrentQty = 400,
                            Description = "Example Product Description 2",
                            IsDeleted = false,
                            Name = "Product 2",
                            Price = 1300m,
                            StockStatus = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(96),
                            CurrentQty = 300,
                            Description = "Example Product Description 3",
                            IsDeleted = false,
                            Name = "Product 3",
                            Price = 1400m,
                            StockStatus = true
                        });
                });

            modelBuilder.Entity("OneClickShopping.Domain.Entities.Products", b =>
                {
                    b.HasOne("OneClickShopping.Domain.Entities.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("OneClickShopping.Domain.Entities.Categories", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
