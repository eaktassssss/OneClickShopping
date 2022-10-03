using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneClickShopping.Persistence.Migrations.SQL
{
    public partial class database_generated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(764)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CurrentQty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 10, 3, 0, 21, 33, 747, DateTimeKind.Local).AddTicks(9423)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 1, "Category 1", new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(1135), null, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 2, "Category 2", new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(1138), null, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 3, "Category 2", new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(1139), null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "CurrentQty", "DeletedDate", "Description", "Name", "Price", "StockStatus", "UpdatedDate" },
                values: new object[] { 1, 2, new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(91), 800, null, "Example Product Description 1", "Product 1", 1200m, true, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "CurrentQty", "DeletedDate", "Description", "Name", "Price", "StockStatus", "UpdatedDate" },
                values: new object[] { 2, 2, new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(94), 400, null, "Example Product Description 2", "Product 2", 1300m, true, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "CurrentQty", "DeletedDate", "Description", "Name", "Price", "StockStatus", "UpdatedDate" },
                values: new object[] { 3, 2, new DateTime(2022, 10, 3, 0, 21, 33, 748, DateTimeKind.Local).AddTicks(96), 300, null, "Example Product Description 3", "Product 3", 1400m, true, null });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
