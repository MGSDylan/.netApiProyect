using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirts_EF.Migrations
{
    /// <inheritdoc />
    public partial class cascadaGuardado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Generos_peliculas_PeliculaId",
                table: "Generos");

            migrationBuilder.AddForeignKey(
                name: "FK_Generos_peliculas_PeliculaId",
                table: "Generos",
                column: "PeliculaId",
                principalTable: "peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Generos_peliculas_PeliculaId",
                table: "Generos");

            migrationBuilder.AddForeignKey(
                name: "FK_Generos_peliculas_PeliculaId",
                table: "Generos",
                column: "PeliculaId",
                principalTable: "peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
