using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class addnecesidadtoarticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                table: "Necesidades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Necesidades_ArticuloId",
                table: "Necesidades",
                column: "ArticuloId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Necesidades_Articulos_ArticuloId",
                table: "Necesidades",
                column: "ArticuloId",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Necesidades_Articulos_ArticuloId",
                table: "Necesidades");

            migrationBuilder.DropIndex(
                name: "IX_Necesidades_ArticuloId",
                table: "Necesidades");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                table: "Necesidades");
        }
    }
}
