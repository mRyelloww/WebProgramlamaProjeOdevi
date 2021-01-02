using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBPROGRAMLAMA_ODEV.Migrations
{
    public partial class eren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UyelerTablo",
                columns: table => new
                {
                    UyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parola = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UyelerTablo", x => x.UyeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UyelerTablo");
        }
    }
}
