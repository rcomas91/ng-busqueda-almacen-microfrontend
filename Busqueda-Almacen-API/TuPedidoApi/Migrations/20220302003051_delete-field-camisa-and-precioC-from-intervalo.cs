using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class deletefieldcamisaandprecioCfromintervalo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Camisa",
                table: "Intervalos");

            migrationBuilder.DropColumn(
                name: "PrecioC",
                table: "Intervalos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Camisa",
                table: "Intervalos",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PrecioC",
                table: "Intervalos",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
