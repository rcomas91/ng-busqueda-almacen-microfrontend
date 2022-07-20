using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class addingintervaloIdpozoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IntervaloId",
                table: "Servicios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PozoId",
                table: "Servicios",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PozoId",
                table: "Servicios");

            migrationBuilder.AlterColumn<int>(
                name: "IntervaloId",
                table: "Servicios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
