using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFUnderstanding.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BasicImgae = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductNumber", x => x.ProductNumber);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[,]
                {
                    { "ramu", "1234" },
                    { "somu", "4321" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DateOfBirth", "Email", "Name", "Phone", "Username" },
                values: new object[] { 101, new DateTime(2000, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ramu@gmail.com", "Ramu", 9876543210m, "ramu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "somu");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "ramu");
        }
    }
}
