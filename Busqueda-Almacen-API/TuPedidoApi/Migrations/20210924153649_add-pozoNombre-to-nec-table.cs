using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class addpozoNombretonectable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Necesidades_Pozos_PozoId",
                table: "Necesidades");

            migrationBuilder.DropIndex(
                name: "IX_Necesidades_PozoId",
                table: "Necesidades");

            migrationBuilder.AddColumn<string>(
                name: "NombrePozo",
                table: "Necesidades",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombrePozo",
                table: "Necesidades");

            migrationBuilder.CreateIndex(
                name: "IX_Necesidades_PozoId",
                table: "Necesidades",
                column: "PozoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Necesidades_Pozos_PozoId",
                table: "Necesidades",
                column: "PozoId",
                principalTable: "Pozos",
                principalColumn: "PozoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
