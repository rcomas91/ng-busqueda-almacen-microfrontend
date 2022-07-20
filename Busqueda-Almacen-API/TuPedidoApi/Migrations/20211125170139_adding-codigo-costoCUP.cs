using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class addingcodigocostoCUP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Servicios",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CostoCUP",
                table: "Servicios",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "CostoCUP",
                table: "Servicios");
        }
    }
}
