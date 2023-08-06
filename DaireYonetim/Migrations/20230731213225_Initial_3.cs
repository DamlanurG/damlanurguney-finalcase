using Microsoft.EntityFrameworkCore.Migrations;

namespace DaireYonetim.Migrations
{
    public partial class Initial_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aidat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaireID = table.Column<int>(type: "int", nullable: false),
                    Tutar = table.Column<int>(type: "int", nullable: false),
                    Odendimi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aidat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fatura",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaireID = table.Column<int>(type: "int", nullable: false),
                    Tutar = table.Column<int>(type: "int", nullable: false),
                    Odendimi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatura", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aidat");

            migrationBuilder.DropTable(
                name: "Fatura");
        }
    }
}
