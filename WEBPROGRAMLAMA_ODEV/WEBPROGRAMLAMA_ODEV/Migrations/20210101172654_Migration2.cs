using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBPROGRAMLAMA_ODEV.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminTablo",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Sifre = table.Column<string>(type: "Varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTablo", x => x.AdminID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTablo");
        }
    }
}
