using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaDB.Migrations
{
    public partial class UpdatedTeamsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imgae",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imgae",
                table: "Teams");
        }
    }
}
