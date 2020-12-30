using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBPROGRAMLAMA_ODEV.Migrations
{
    public partial class Guncelleme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiziTurDB_DiziDB_DizilerDiziID",
                table: "DiziTurDB");

            migrationBuilder.DropIndex(
                name: "IX_DiziTurDB_DizilerDiziID",
                table: "DiziTurDB");

            migrationBuilder.DropColumn(
                name: "DizilerDiziID",
                table: "DiziTurDB");

            migrationBuilder.AddColumn<int>(
                name: "DiziTurTurID",
                table: "DiziDB",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiziDB_DiziTurTurID",
                table: "DiziDB",
                column: "DiziTurTurID");

            migrationBuilder.AddForeignKey(
                name: "FK_DiziDB_DiziTurDB_DiziTurTurID",
                table: "DiziDB",
                column: "DiziTurTurID",
                principalTable: "DiziTurDB",
                principalColumn: "TurID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiziDB_DiziTurDB_DiziTurTurID",
                table: "DiziDB");

            migrationBuilder.DropIndex(
                name: "IX_DiziDB_DiziTurTurID",
                table: "DiziDB");

            migrationBuilder.DropColumn(
                name: "DiziTurTurID",
                table: "DiziDB");

            migrationBuilder.AddColumn<int>(
                name: "DizilerDiziID",
                table: "DiziTurDB",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiziTurDB_DizilerDiziID",
                table: "DiziTurDB",
                column: "DizilerDiziID");

            migrationBuilder.AddForeignKey(
                name: "FK_DiziTurDB_DiziDB_DizilerDiziID",
                table: "DiziTurDB",
                column: "DizilerDiziID",
                principalTable: "DiziDB",
                principalColumn: "DiziID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
