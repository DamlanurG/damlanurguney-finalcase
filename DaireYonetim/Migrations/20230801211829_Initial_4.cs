using Microsoft.EntityFrameworkCore.Migrations;

namespace DaireYonetim.Migrations
{
    public partial class Initial_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ay",
                table: "Fatura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ay",
                table: "Aidat",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ay",
                table: "Fatura");

            migrationBuilder.DropColumn(
                name: "Ay",
                table: "Aidat");
        }
    }
}
