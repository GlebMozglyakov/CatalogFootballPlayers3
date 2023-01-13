using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogFootballPlayers3.Migrations
{
    public partial class updateFootballerToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderFootballer",
                table: "Footballer");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Footballer",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Footballer");

            migrationBuilder.AddColumn<int>(
                name: "GenderFootballer",
                table: "Footballer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
