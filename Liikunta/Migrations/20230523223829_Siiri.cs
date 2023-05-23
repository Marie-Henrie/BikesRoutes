using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Liikunta.Migrations
{
    /// <inheritdoc />
    public partial class Siiri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "y",
                table: "City",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "x",
                table: "City",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "xAkseli",
                table: "City",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "yAkseli",
                table: "City",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "xAkseli",
                table: "City");

            migrationBuilder.DropColumn(
                name: "yAkseli",
                table: "City");

            migrationBuilder.AlterColumn<double>(
                name: "y",
                table: "City",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "x",
                table: "City",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
