using Microsoft.EntityFrameworkCore.Migrations;

namespace Stores.Migrations
{
    public partial class ExtendRolANDSeedindData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "AspNetRoles");
        }
    }
}
