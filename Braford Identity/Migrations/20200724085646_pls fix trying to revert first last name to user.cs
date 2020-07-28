using Microsoft.EntityFrameworkCore.Migrations;

namespace Braford_Identity.Migrations
{
    public partial class plsfixtryingtorevertfirstlastnametouser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);
        }
    }
}
