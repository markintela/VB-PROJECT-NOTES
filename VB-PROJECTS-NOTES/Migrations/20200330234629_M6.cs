using Microsoft.EntityFrameworkCore.Migrations;

namespace VB_PROJECTS_NOTES.Migrations
{
    public partial class M6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "Active",
                table: "Project",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
