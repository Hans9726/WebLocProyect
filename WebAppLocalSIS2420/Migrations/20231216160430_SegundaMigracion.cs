using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLocalSIS2420.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmbientesId",
                table: "Alquileres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Alquileres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_AmbientesId",
                table: "Alquileres",
                column: "AmbientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_UsuarioId",
                table: "Alquileres",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_Ambientes_AmbientesId",
                table: "Alquileres",
                column: "AmbientesId",
                principalTable: "Ambientes",
                principalColumn: "IdAmbiente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_Usuarios_UsuarioId",
                table: "Alquileres",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_Ambientes_AmbientesId",
                table: "Alquileres");

            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_Usuarios_UsuarioId",
                table: "Alquileres");

            migrationBuilder.DropIndex(
                name: "IX_Alquileres_AmbientesId",
                table: "Alquileres");

            migrationBuilder.DropIndex(
                name: "IX_Alquileres_UsuarioId",
                table: "Alquileres");

            migrationBuilder.DropColumn(
                name: "AmbientesId",
                table: "Alquileres");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Alquileres");
        }
    }
}
