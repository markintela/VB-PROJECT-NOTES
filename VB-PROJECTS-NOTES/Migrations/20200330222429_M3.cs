using Microsoft.EntityFrameworkCore.Migrations;

namespace VB_PROJECTS_NOTES.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Project",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "Active",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
