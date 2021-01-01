using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBPROGRAMLAMA_ODEV.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiziIMDB",
                table: "DiziTablo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiziSezonSayi",
                table: "DiziTablo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DiziStudyo",
                table: "DiziTablo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiziTarih",
                table: "DiziTablo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiziIMDB",
                table: "DiziTablo");

            migrationBuilder.DropColumn(
                name: "DiziSezonSayi",
                table: "DiziTablo");

            migrationBuilder.DropColumn(
                name: "DiziStudyo",
                table: "DiziTablo");

            migrationBuilder.DropColumn(
                name: "DiziTarih",
                table: "DiziTablo");
        }
    }
}
