using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBPROGRAMLAMA_ODEV.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DiziDosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiziTablo", x => x.DiziID);
                });

            migrationBuilder.CreateTable(
                name: "DiziTurTablo",
                columns: table => new
                {
                    TurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tur = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiziTurTablo", x => x.TurID);
                });

            migrationBuilder.CreateTable(
                name: "DiziTurDizilerTablo",
                columns: table => new
                {
                    DiziID = table.Column<int>(type: "int", nullable: false),
                    TurID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiziTurDizilerTablo", x => new { x.DiziID, x.TurID });
                    table.ForeignKey(
                        name: "FK_DiziTurDizilerTablo_DiziTablo_DiziID",
                        column: x => x.DiziID,
                        principalTable: "DiziTablo",
                        principalColumn: "DiziID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiziTurDizilerTablo_DiziTurTablo_TurID",
                        column: x => x.TurID,
                        principalTable: "DiziTurTablo",
                        principalColumn: "TurID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiziTurDizilerTablo_TurID",
                table: "DiziTurDizilerTablo",
                column: "TurID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiziTurDizilerTablo");

            migrationBuilder.DropTable(
                name: "DiziTablo");

            migrationBuilder.DropTable(
                name: "DiziTurTablo");
        }
    }
}
