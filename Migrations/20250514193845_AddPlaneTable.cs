using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlyCraiovaSE.Migrations
{
    /// <inheritdoc />
    public partial class AddPlaneTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrSeats = table.Column<int>(type: "int", nullable: false),
                    NrPremiumSeats = table.Column<int>(type: "int", nullable: false),
                    NrNormalSeats = table.Column<int>(type: "int", nullable: false),
                    Manufactured = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
