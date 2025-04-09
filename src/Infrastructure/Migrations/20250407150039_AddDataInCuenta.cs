using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInCuenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cuentas",
                columns: new[] { "NumeroDeCuenta", "Bloqueado", "CantidadDeIntentos", "NumeroDeTarjeta", "Pin", "UsuarioId" },
                values: new object[,]
                {
                    { 11235813, false, 0, "4444333311117777", "0628", new Guid("774b7fa6-50fd-4abc-80f7-b2000b349c23") },
                    { 20250404, false, 0, "4444333300007777", "2025", new Guid("b3b6f399-4993-42de-8772-9ae8a732504d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cuentas",
                keyColumn: "NumeroDeCuenta",
                keyValue: 11235813);

            migrationBuilder.DeleteData(
                table: "Cuentas",
                keyColumn: "NumeroDeCuenta",
                keyValue: 20250404);
        }
    }
}
