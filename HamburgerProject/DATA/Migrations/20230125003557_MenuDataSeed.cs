using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamburgerProject.DATA.Migrations
{
    /// <inheritdoc />
    public partial class MenuDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "MenuName", "Price" },
                values: new object[,]
                {
                    { 1, "Burger King Menüsü", 80.719999999999999 },
                    { 2, "Double King Chicken Menu", 100.72 },
                    { 3, "Steak House Menu", 98.719999999999999 },
                    { 4, "Whooper Menu", 78.719999999999999 },
                    { 5, "Whooper Jr. Menu", 128.72 },
                    { 6, "Chicken Royal Menu", 138.72 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
