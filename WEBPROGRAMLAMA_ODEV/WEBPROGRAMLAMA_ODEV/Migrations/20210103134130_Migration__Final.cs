using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBPROGRAMLAMA_ODEV.Migrations
{
    public partial class Migration__Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminTablo",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTablo", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "DiziTablo",
                columns: table => new
                {
                    DiziID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiziAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiziBegeni = table.Column<int>(type: "int", nullable: false),
                    DiziStudyo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiziTarih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiziSezonSayi = table.Column<int>(type: "int", nullable: false),
                    DiziIMDB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiziBilgi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiziLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiziDosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiziTurler = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiziTablo", x => x.DiziID);
                });

            migrationBuilder.CreateTable(
                name: "UyelerTablo",
                columns: table => new
                {
                    UyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UyelerTablo", x => x.UyeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTablo");

            migrationBuilder.DropTable(
                name: "DiziTablo");

            migrationBuilder.DropTable(
                name: "UyelerTablo");
        }
    }
}
