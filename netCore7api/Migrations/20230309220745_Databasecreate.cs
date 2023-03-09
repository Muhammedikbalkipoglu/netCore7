using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace netCore7api.Migrations
{
    /// <inheritdoc />
    public partial class Databasecreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 1, 7, 45, 621, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 1, 7, 45, 621, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 1, 7, 45, 621, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 1, 7, 45, 621, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 1, 7, 45, 621, DateTimeKind.Local).AddTicks(6414));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 0, 4, 17, 346, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 0, 4, 17, 346, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 0, 4, 17, 346, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 0, 4, 17, 346, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 0, 4, 17, 346, DateTimeKind.Local).AddTicks(4131));
        }
    }
}
