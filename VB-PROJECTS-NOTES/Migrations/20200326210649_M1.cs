using Microsoft.EntityFrameworkCore.Migrations;

namespace VB_PROJECTS_NOTES.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Active",
                table: "Region",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Active",
                table: "Project",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Active",
                table: "Country",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Region");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Country");
        }
    }
}
