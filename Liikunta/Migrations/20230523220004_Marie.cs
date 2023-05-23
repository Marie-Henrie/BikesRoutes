using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Liikunta.Migrations
{
    /// <inheritdoc />
    public partial class Marie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FID = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Osoite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kaupunki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Operaattor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kapasiteet = table.Column<int>(type: "int", nullable: true),
                    x = table.Column<float>(type: "real", nullable: true),
                    y = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Route_FID",
                        column: x => x.FID,
                        principalTable: "Route",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_FID",
                table: "City",
                column: "FID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
