using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class addprecioscamisabarrenainttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PrecioB",
                table: "Intervalos",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PrecioC",
                table: "Intervalos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioB",
                table: "Intervalos");

            migrationBuilder.DropColumn(
                name: "PrecioC",
                table: "Intervalos");
        }
    }
}
