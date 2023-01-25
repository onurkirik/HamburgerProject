using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamburgerProject.DATA.Migrations
{
    /// <inheritdoc />
    public partial class ExtraMaterialsDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExtraMaterials",
                columns: new[] { "Id", "MaterialName", "Price" },
                values: new object[,]
                {
                    { 1, "Ketçap", 5.0 },
                    { 2, "Mayonez", 5.0 },
                    { 3, "BBQ", 3.5 },
                    { 5, "Ranch", 4.0 },
                    { 6, "Buffalo", 5.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
