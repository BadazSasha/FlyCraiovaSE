using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlyCraiovaSE.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataPlane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "ImageUrl", "Manufactured", "Model", "Name", "NrNormalSeats", "NrPremiumSeats", "NrSeats" },
                values: new object[,]
                {
                    { 1, "https://images.aircharterservice.com/global/aircraft-guide/group-charter/airbus-a320-1.jpg", 1994, "A320", "Airbus", 123, 34, 157 },
                    { 2, "https://aircraft.airbus.com/sites/g/files/jlcbta126/files/styles/w640h512/public/2024-11/a321.png?h=3a37fd15&itok=WdLYVBok", 1995, "A321", "Airbus", 156, 31, 187 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
