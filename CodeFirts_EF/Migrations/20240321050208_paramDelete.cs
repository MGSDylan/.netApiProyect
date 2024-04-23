using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirts_EF.Migrations
{
    /// <inheritdoc />
    public partial class paramDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "peliculas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 60,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 61,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 62,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 63,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 64,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 65,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 66,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 67,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 68,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 69,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 70,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 71,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 72,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 73,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 74,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 75,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 76,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 77,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 78,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 79,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 80,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 81,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 82,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 83,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 84,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 85,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 86,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 87,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 88,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 89,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 90,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 91,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 92,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 93,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 94,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 95,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 96,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 97,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 98,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 99,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 100,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 101,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 102,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 103,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 104,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 105,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 106,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 107,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 108,
                column: "IsDeleted",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "peliculas");
        }
    }
}
