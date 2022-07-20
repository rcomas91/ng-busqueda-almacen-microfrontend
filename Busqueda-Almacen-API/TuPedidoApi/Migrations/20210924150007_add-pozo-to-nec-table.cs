using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistia.Migrations
{
    public partial class addpozotonectable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PozoId",
                table: "Necesidades",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Necesidades_Pozos_PozoId",
                table: "Necesidades");

            migrationBuilder.DropIndex(
                name: "IX_Necesidades_PozoId",
                table: "Necesidades");

            migrationBuilder.DropColumn(
                name: "PozoId",
                table: "Necesidades");
        }
    }
}
