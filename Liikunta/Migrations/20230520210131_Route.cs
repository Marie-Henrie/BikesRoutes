using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Liikunta.Migrations
{
    /// <inheritdoc />
    public partial class Route : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Return = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureStationId = table.Column<int>(type: "int", nullable: true),
                    DepartureStationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnStationId = table.Column<int>(type: "int", nullable: true),
                    ReturnStationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoveredDistanceM = table.Column<int>(type: "int", nullable: true),
                    DurationSec = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Route");
        }
    }
}
