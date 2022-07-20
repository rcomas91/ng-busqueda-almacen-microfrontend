using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class Existencianullacceptnecesidadtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Existencia",
                table: "Necesidades",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Existencia",
                table: "Necesidades",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
