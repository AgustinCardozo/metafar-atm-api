using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ATM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreDeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    NumeroDeCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin = table.Column<int>(type: "int", nullable: false),
                    CantidadDeIntentos = table.Column<int>(type: "int", nullable: false),
                    Bloqueado = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.NumeroDeCuenta);
                    table.ForeignKey(
                        name: "FK_Cuentas_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaldoActual = table.Column<double>(type: "float", nullable: false),
                    UltimaExtraccion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumeroDeCuenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operaciones_Cuentas_NumeroDeCuenta",
                        column: x => x.NumeroDeCuenta,
                        principalTable: "Cuentas",
                        principalColumn: "NumeroDeCuenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "NombreDeUsuario" },
                values: new object[,]
                {
                    { new Guid("4c7c5b69-d92e-44c4-8524-abe0a229779a"), "Marcelo Gallardo" },
                    { new Guid("774b7fa6-50fd-4abc-80f7-b2000b349c23"), "Dardo Fuseneco" },
                    { new Guid("b3b6f399-4993-42de-8772-9ae8a732504d"), "Pepe Argento" }
                });

            migrationBuilder.InsertData(
                table: "Cuentas",
                columns: new[] { "NumeroDeCuenta", "Bloqueado", "CantidadDeIntentos", "NumeroDeTarjeta", "Pin", "UsuarioId" },
                values: new object[,]
                {
                    { 9122018, false, 0, "4444222200009999", 5678, new Guid("774b7fa6-50fd-4abc-80f7-b2000b349c23") },
                    { 18122022, false, 0, "4444333300009999", 9012, new Guid("4c7c5b69-d92e-44c4-8524-abe0a229779a") },
                    { 23042010, false, 0, "4444222200008888", 1234, new Guid("b3b6f399-4993-42de-8772-9ae8a732504d") }
                });

            migrationBuilder.InsertData(
                table: "Operaciones",
                columns: new[] { "Id", "NumeroDeCuenta", "SaldoActual", "UltimaExtraccion" },
                values: new object[,]
                {
                    { new Guid("1897f83c-dba7-4a35-86ef-64ddaaecd4b3"), 9122018, 400.0, new DateTime(2024, 9, 16, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9820) },
                    { new Guid("2a60cdcb-26ec-4ae4-867c-b249bed91a7a"), 9122018, 120003.0, new DateTime(2024, 9, 23, 1, 44, 38, 659, DateTimeKind.Local).AddTicks(9826) },
                    { new Guid("2c25a244-58e1-4af5-8549-218d933d4747"), 9122018, 570000.0, new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9812) },
                    { new Guid("44940e3b-8bc8-4aae-b88a-3032a596075d"), 9122018, 50329.0, new DateTime(2024, 9, 23, 0, 44, 38, 659, DateTimeKind.Local).AddTicks(9827) },
                    { new Guid("77788191-ceba-4e8f-960a-62ad79d264fc"), 18122022, 0.0, null },
                    { new Guid("7930faee-3412-44a1-9813-2e14f404af51"), 9122018, 156500.0, new DateTime(2024, 9, 22, 21, 44, 38, 659, DateTimeKind.Local).AddTicks(9818) },
                    { new Guid("79a3d8ae-a47b-45e0-aeab-f8fbcfd8247a"), 9122018, 320000.0, new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9809) },
                    { new Guid("7a7c7eee-9bab-4e6c-a664-f040cc357cee"), 9122018, 800023.0, new DateTime(2024, 9, 23, 4, 39, 38, 659, DateTimeKind.Local).AddTicks(9813) },
                    { new Guid("7c12d056-424b-44b1-95fb-945b78654c0a"), 9122018, 234500.0, new DateTime(2024, 9, 23, 0, 44, 38, 659, DateTimeKind.Local).AddTicks(9811) },
                    { new Guid("7cdc0e9c-2f31-4088-93fd-b99559116728"), 9122018, 267500.0, new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9822) },
                    { new Guid("81733dac-cca8-4e9b-9737-121d45c65ac1"), 9122018, 23000.0, new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9819) },
                    { new Guid("867d78a3-dd1f-4170-a71b-945d54665411"), 9122018, 102003.0, new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9828) },
                    { new Guid("8aeb0237-5fbc-4e39-88e6-b1cd02d07bc7"), 9122018, 600230.0, new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9816) },
                    { new Guid("914ef540-7128-40a0-9ce4-e5f4389247c1"), 23042010, 500000.0, new DateTime(2024, 9, 22, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9800) },
                    { new Guid("92812bff-0dcc-4396-9294-0bc91850946f"), 9122018, 676540.0, new DateTime(2024, 9, 21, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9824) },
                    { new Guid("aa604404-dfc5-4158-91ae-598efe4d6323"), 9122018, 1234300.0, new DateTime(2024, 9, 24, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9823) },
                    { new Guid("cc130800-5f61-46c1-a031-49aaf5397089"), 18122022, 5000000.0, new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9831) },
                    { new Guid("d34b4d33-4b1b-49b5-872a-1205024e3301"), 23042010, 700000.0, new DateTime(2024, 9, 23, 3, 44, 38, 659, DateTimeKind.Local).AddTicks(9806) },
                    { new Guid("d769e439-432b-4f36-ab37-5801c0205128"), 23042010, 800000.0, new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9784) },
                    { new Guid("ebfbd1ba-eb2e-4b75-9e1e-9fd758d3101b"), 23042010, 400000.0, new DateTime(2024, 9, 23, 3, 44, 38, 659, DateTimeKind.Local).AddTicks(9808) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_UsuarioId",
                table: "Cuentas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Operaciones_NumeroDeCuenta",
                table: "Operaciones",
                column: "NumeroDeCuenta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operaciones");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
