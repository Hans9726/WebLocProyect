using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLocalSIS2420.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alquileres",
                columns: table => new
                {
                    IdAlquiler = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreAmbAqluilar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAlquilar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adelanto = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquileres", x => x.IdAlquiler);
                });

            migrationBuilder.CreateTable(
                name: "Ambientes",
                columns: table => new
                {
                    IdAmbiente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fotos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreAmbiente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    Tarima = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambientes", x => x.IdAmbiente);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquileres");

            migrationBuilder.DropTable(
                name: "Ambientes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
