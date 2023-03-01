using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace netCore7api.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amentiy", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ne güzel villa bunlar ilgi çekici güzel villa", "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg", "Royal Villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ne güzel villa bunlar ilgi çekici güzel villa DAHA GÜZel", "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg", "Boyal Villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ne güzel villa bunlar ilgi çekici güzel villa Daha Daha güzel", "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg", "Doyal Villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ne güzel villa bunlar ilgi çekici güzel villa Daha Daha güzel", "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg", "Doyal Villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ne güzel villa bunlar ilgi çekici güzel villa Daha Daha güzel", "https://www.neyiilemeshur.com/wp-content/uploads/2014/01/bing%C3%B6l-da%C4%9Flar%C4%B1.jpg", "Doyal Villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
