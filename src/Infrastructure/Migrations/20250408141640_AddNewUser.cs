using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "NombreDeUsuario" },
                values: new object[] { new Guid("2ccef8f6-fe86-4e8d-a24b-6bd14f278e99"), "Benito Camela" });

            migrationBuilder.InsertData(
                table: "Cuentas",
                columns: new[] { "NumeroDeCuenta", "Bloqueado", "CantidadDeIntentos", "NumeroDeTarjeta", "Pin", "UsuarioId" },
                values: new object[] { 48342025, false, 0, "4454272409039986", "1051", new Guid("2ccef8f6-fe86-4e8d-a24b-6bd14f278e99") });

            migrationBuilder.InsertData(
                table: "Operaciones",
                columns: new[] { "Id", "NumeroDeCuenta", "SaldoActual", "UltimaExtraccion" },
                values: new object[,]
                {
                    { new Guid("1355a80b-21da-45cb-89bf-aa7f5861ecad"), 48342025, 1000000.0, new DateTime(2025, 4, 8, 11, 13, 23, 0, DateTimeKind.Unspecified) },
                    { new Guid("78b1f9b5-293f-40f9-9810-dfa2b876a98b"), 48342025, 700000.0, new DateTime(2025, 4, 8, 11, 13, 23, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("1355a80b-21da-45cb-89bf-aa7f5861ecad"));

            migrationBuilder.DeleteData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("78b1f9b5-293f-40f9-9810-dfa2b876a98b"));

            migrationBuilder.DeleteData(
                table: "Cuentas",
                keyColumn: "NumeroDeCuenta",
                keyValue: 48342025);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("2ccef8f6-fe86-4e8d-a24b-6bd14f278e99"));
        }
    }
}
