using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnSizeToNumeroDeCuentaInCuenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroDeTarjeta",
                table: "Cuentas",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("1897f83c-dba7-4a35-86ef-64ddaaecd4b3"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 20, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("2a60cdcb-26ec-4ae4-867c-b249bed91a7a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 7, 29, 29, 713, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("2c25a244-58e1-4af5-8549-218d933d4747"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("44940e3b-8bc8-4aae-b88a-3032a596075d"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 6, 29, 29, 713, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7930faee-3412-44a1-9813-2e14f404af51"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 3, 29, 29, 713, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("79a3d8ae-a47b-45e0-aeab-f8fbcfd8247a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7a7c7eee-9bab-4e6c-a664-f040cc357cee"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 24, 29, 713, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7c12d056-424b-44b1-95fb-945b78654c0a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 6, 29, 29, 713, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7cdc0e9c-2f31-4088-93fd-b99559116728"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("81733dac-cca8-4e9b-9737-121d45c65ac1"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("867d78a3-dd1f-4170-a71b-945d54665411"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("8aeb0237-5fbc-4e39-88e6-b1cd02d07bc7"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("914ef540-7128-40a0-9ce4-e5f4389247c1"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 26, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("92812bff-0dcc-4396-9294-0bc91850946f"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 25, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("aa604404-dfc5-4158-91ae-598efe4d6323"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("cc130800-5f61-46c1-a031-49aaf5397089"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("d34b4d33-4b1b-49b5-872a-1205024e3301"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 9, 29, 29, 713, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("d769e439-432b-4f36-ab37-5801c0205128"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 10, 29, 29, 713, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("ebfbd1ba-eb2e-4b75-9e1e-9fd758d3101b"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 9, 29, 29, 713, DateTimeKind.Local).AddTicks(7908));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroDeTarjeta",
                table: "Cuentas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("1897f83c-dba7-4a35-86ef-64ddaaecd4b3"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 16, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("2a60cdcb-26ec-4ae4-867c-b249bed91a7a"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 1, 44, 38, 659, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("2c25a244-58e1-4af5-8549-218d933d4747"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("44940e3b-8bc8-4aae-b88a-3032a596075d"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 0, 44, 38, 659, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7930faee-3412-44a1-9813-2e14f404af51"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 22, 21, 44, 38, 659, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("79a3d8ae-a47b-45e0-aeab-f8fbcfd8247a"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7a7c7eee-9bab-4e6c-a664-f040cc357cee"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 39, 38, 659, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7c12d056-424b-44b1-95fb-945b78654c0a"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 0, 44, 38, 659, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7cdc0e9c-2f31-4088-93fd-b99559116728"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("81733dac-cca8-4e9b-9737-121d45c65ac1"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("867d78a3-dd1f-4170-a71b-945d54665411"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("8aeb0237-5fbc-4e39-88e6-b1cd02d07bc7"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("914ef540-7128-40a0-9ce4-e5f4389247c1"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 22, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("92812bff-0dcc-4396-9294-0bc91850946f"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 21, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("aa604404-dfc5-4158-91ae-598efe4d6323"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 24, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("cc130800-5f61-46c1-a031-49aaf5397089"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("d34b4d33-4b1b-49b5-872a-1205024e3301"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 3, 44, 38, 659, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("d769e439-432b-4f36-ab37-5801c0205128"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 4, 44, 38, 659, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("ebfbd1ba-eb2e-4b75-9e1e-9fd758d3101b"),
                column: "UltimaExtraccion",
                value: new DateTime(2024, 9, 23, 3, 44, 38, 659, DateTimeKind.Local).AddTicks(9808));
        }
    }
}
