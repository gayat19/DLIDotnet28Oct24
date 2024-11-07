using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFUnderstanding.Migrations
{
    /// <inheritdoc />
    public partial class UserAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Username",
                table: "Customers",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_Username",
                table: "Customers",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_Username",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Username",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Customers");
        }
    }
}
