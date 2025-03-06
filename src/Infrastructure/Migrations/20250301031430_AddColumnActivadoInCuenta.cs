using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnActivadoInCuenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activado",
                table: "Cuentas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cuentas",
                keyColumn: "NumeroDeCuenta",
                keyValue: 9122018,
                column: "Activado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cuentas",
                keyColumn: "NumeroDeCuenta",
                keyValue: 18122022,
                column: "Activado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cuentas",
                keyColumn: "NumeroDeCuenta",
                keyValue: 23042010,
                column: "Activado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("1897f83c-dba7-4a35-86ef-64ddaaecd4b3"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 22, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("2a60cdcb-26ec-4ae4-867c-b249bed91a7a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 21, 14, 30, 445, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("2c25a244-58e1-4af5-8549-218d933d4747"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("44940e3b-8bc8-4aae-b88a-3032a596075d"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 20, 14, 30, 445, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7930faee-3412-44a1-9813-2e14f404af51"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 17, 14, 30, 445, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("79a3d8ae-a47b-45e0-aeab-f8fbcfd8247a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7a7c7eee-9bab-4e6c-a664-f040cc357cee"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 9, 30, 445, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7c12d056-424b-44b1-95fb-945b78654c0a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 20, 14, 30, 445, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7cdc0e9c-2f31-4088-93fd-b99559116728"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("81733dac-cca8-4e9b-9737-121d45c65ac1"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("867d78a3-dd1f-4170-a71b-945d54665411"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("8aeb0237-5fbc-4e39-88e6-b1cd02d07bc7"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("914ef540-7128-40a0-9ce4-e5f4389247c1"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("92812bff-0dcc-4396-9294-0bc91850946f"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("aa604404-dfc5-4158-91ae-598efe4d6323"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 2, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("cc130800-5f61-46c1-a031-49aaf5397089"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("d34b4d33-4b1b-49b5-872a-1205024e3301"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 23, 14, 30, 445, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("d769e439-432b-4f36-ab37-5801c0205128"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 0, 14, 30, 445, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("ebfbd1ba-eb2e-4b75-9e1e-9fd758d3101b"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 23, 14, 30, 445, DateTimeKind.Local).AddTicks(3161));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activado",
                table: "Cuentas");

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("1897f83c-dba7-4a35-86ef-64ddaaecd4b3"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 21, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("2a60cdcb-26ec-4ae4-867c-b249bed91a7a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 8, 58, 24, 482, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("2c25a244-58e1-4af5-8549-218d933d4747"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("44940e3b-8bc8-4aae-b88a-3032a596075d"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 7, 58, 24, 482, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7930faee-3412-44a1-9813-2e14f404af51"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 4, 58, 24, 482, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("79a3d8ae-a47b-45e0-aeab-f8fbcfd8247a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7a7c7eee-9bab-4e6c-a664-f040cc357cee"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 53, 24, 482, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7c12d056-424b-44b1-95fb-945b78654c0a"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 7, 58, 24, 482, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("7cdc0e9c-2f31-4088-93fd-b99559116728"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("81733dac-cca8-4e9b-9737-121d45c65ac1"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("867d78a3-dd1f-4170-a71b-945d54665411"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("8aeb0237-5fbc-4e39-88e6-b1cd02d07bc7"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("914ef540-7128-40a0-9ce4-e5f4389247c1"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 27, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("92812bff-0dcc-4396-9294-0bc91850946f"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 26, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("aa604404-dfc5-4158-91ae-598efe4d6323"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 3, 1, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("cc130800-5f61-46c1-a031-49aaf5397089"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("d34b4d33-4b1b-49b5-872a-1205024e3301"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 10, 58, 24, 482, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("d769e439-432b-4f36-ab37-5801c0205128"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 11, 58, 24, 482, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Operaciones",
                keyColumn: "Id",
                keyValue: new Guid("ebfbd1ba-eb2e-4b75-9e1e-9fd758d3101b"),
                column: "UltimaExtraccion",
                value: new DateTime(2025, 2, 28, 10, 58, 24, 482, DateTimeKind.Local).AddTicks(7324));
        }
    }
}
