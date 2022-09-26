using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDonationManagmentSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donars",
                columns: table => new
                {
                    DonarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonarName = table.Column<string>(nullable: true),
                    DonarCity = table.Column<string>(nullable: true),
                    PhNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donars", x => x.DonarId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donars");
        }
    }
}
