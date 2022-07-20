using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class deletebarrenafromintervalo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioB",
                table: "Intervalos");

            migrationBuilder.RenameColumn(
                name: "Barrena",
                table: "Intervalos",
                newName: "NombreIntervalo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreIntervalo",
                table: "Intervalos",
                newName: "Barrena");

            migrationBuilder.AddColumn<double>(
                name: "PrecioB",
                table: "Intervalos",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
