using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Braford_Identity.Migrations.TicketDb
{
    public partial class AddTicketToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user = table.Column<string>(nullable: true),
                    time = table.Column<DateTime>(nullable: false),
                    issue = table.Column<string>(nullable: true),
                    area_of_issue = table.Column<string>(nullable: true),
                    resolution = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
