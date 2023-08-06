using Microsoft.EntityFrameworkCore.Migrations;

namespace DaireYonetim.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DaireID",
                table: "Kullanici",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sifre",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaireID",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "Sifre",
                table: "Kullanici");
        }
    }
}
