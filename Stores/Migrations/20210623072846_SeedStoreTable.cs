using Microsoft.EntityFrameworkCore.Migrations;

namespace Stores.Migrations
{
    public partial class SeedStoreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Direccion", "Lat", "Long", "Nombre", "Telefono" },
                values: new object[] { 1, "San Miguel", 1.2222219999999999, 2.3332999999999999, "DefaultStore", "24578984" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
