using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StorageApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, "Verktyg", 20, "Standardhammare 500g", "Hammare", 149, "A1" },
                    { 2, "Verktyg", 35, "Platt skruvmejsel 6mm", "Skruvmejsel", 59, "A2" },
                    { 3, "Verktyg", 15, "Justerbar skiftnyckel 250mm", "Skiftnyckel", 199, "A3" },
                    { 4, "Bygg", 50, "Spackelspade i rostfritt stål", "Spackelputs", 89, "B1" },
                    { 5, "Bygg", 100, "Pensel 50mm för inomhusmålning", "Målarpensel", 39, "B2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
