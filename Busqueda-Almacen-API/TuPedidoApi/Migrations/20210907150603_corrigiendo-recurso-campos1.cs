using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class corrigiendorecursocampos1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recursos_Intervalos_IntervaloId",
                table: "Recursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recursos",
                table: "Recursos");

            migrationBuilder.RenameTable(
                name: "Recursos",
                newName: "Articulos");

            migrationBuilder.RenameIndex(
                name: "IX_Recursos_IntervaloId",
                table: "Articulos",
                newName: "IX_Articulos_IntervaloId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articulos",
                table: "Articulos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Intervalos_IntervaloId",
                table: "Articulos",
                column: "IntervaloId",
                principalTable: "Intervalos",
                principalColumn: "IntervaloId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Intervalos_IntervaloId",
                table: "Articulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articulos",
                table: "Articulos");

            migrationBuilder.RenameTable(
                name: "Articulos",
                newName: "Recursos");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_IntervaloId",
                table: "Recursos",
                newName: "IX_Recursos_IntervaloId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recursos",
                table: "Recursos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recursos_Intervalos_IntervaloId",
                table: "Recursos",
                column: "IntervaloId",
                principalTable: "Intervalos",
                principalColumn: "IntervaloId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
