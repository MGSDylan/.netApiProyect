using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirts_EF.Migrations
{
    /// <inheritdoc />
    public partial class peliculas50register : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "peliculas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 60, "resident evil1" },
                    { 61, "resident evil2" },
                    { 62, "resident evil3" },
                    { 63, "resident evil4" },
                    { 64, "resident evil5" },
                    { 65, "resident evil6" },
                    { 66, "resident evil7" },
                    { 67, "resident evil8" },
                    { 68, "resident evil9" },
                    { 69, "resident evil10" },
                    { 70, "resident evil11" },
                    { 71, "resident evil12" },
                    { 72, "resident evil13" },
                    { 73, "resident evil14" },
                    { 74, "resident evil15" },
                    { 75, "resident evil16" },
                    { 76, "resident evil17" },
                    { 77, "resident evil18" },
                    { 78, "resident evil19" },
                    { 79, "resident evil20" },
                    { 80, "resident evil21" },
                    { 81, "resident evil22" },
                    { 82, "resident evil23" },
                    { 83, "resident evil24" },
                    { 84, "resident evil25" },
                    { 85, "resident evil26" },
                    { 86, "resident evil27" },
                    { 87, "resident evil28" },
                    { 88, "resident evil29" },
                    { 89, "resident evil30" },
                    { 90, "resident evil31" },
                    { 91, "resident evil32" },
                    { 92, "resident evil33" },
                    { 93, "resident evil34" },
                    { 94, "resident evil35" },
                    { 95, "resident evil36" },
                    { 96, "resident evil37" },
                    { 97, "resident evil38" },
                    { 98, "resident evil39" },
                    { 99, "resident evil40" },
                    { 100, "resident evil41" },
                    { 101, "resident evil42" },
                    { 102, "resident evil43" },
                    { 103, "resident evil44" },
                    { 104, "resident evil45" },
                    { 105, "resident evil46" },
                    { 106, "resident evil47" },
                    { 107, "resident evil48" },
                    { 108, "resident evil49" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "peliculas",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.InsertData(
                table: "peliculas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "resident evil" },
                    { 4, "Amanecer de los muertos" }
                });
        }
    }
}
