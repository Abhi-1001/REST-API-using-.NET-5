using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Migrations
{
    public partial class tripMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Car_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Driver_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Dest = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
