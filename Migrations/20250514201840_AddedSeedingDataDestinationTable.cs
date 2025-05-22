using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlyCraiovaSE.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDestinationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A tax heaven for companies and a heaven for alcoholics", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/15/33/f7/0e/dublin.jpg?w=1400&h=1400&s=1", 200, "Dublin, Ireland" },
                    { 2, "Literally why come here?", "https://blog.hotelguru.ro/wp-content/uploads/2018/12/shutterstock_493178746.jpg", 500, "Bucuresti, Romania" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
