using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Visited = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "City", "Country", "Details", "Rating", "UserName", "Visited" },
                values: new object[,]
                {
                    { 1, "Seattle", "USA", "A City in the Pacific Northwest surrounded by hills and trees.", 4, "mmanchee", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 2, "Stockholm", "Sweden", "A City in northern Europe. Sweden's Capitol.", 5, "gbrown", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 3, "Toronto", "Canada", "Canada's most populated city, located just beyond the border near Detroit.", 4, "gbrown", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 4, "Shanghai", "China", "A city in China that neighbors Hong-Kong just on the other side of the river.", 4, "gbrown", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 5, "Honolulu", "USA", "Located in the middle of the Pacific near the equator. This coast city sits right on white sand beaches with Diamond Head Mt. at the far south", 5, "mmanchee", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 6, "Seattle", "USA", "A City in the Pacific Northwest surrounded by hills and trees.", 1, "mmanchee", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 7, "Stockholm", "Sweden", "A City in northern Europe. Sweden's Capitol.", 2, "gbrown", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 8, "Toronto", "Canada", "Canada's most populated city, located just beyond the border near Detroit.", 1, "gbrown", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 9, "Shanghai", "China", "A city in China that neighbors Hong-Kong just on the other side of the river.", 2, "gbrown", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) },
                    { 10, "Honolulu", "USA", "Located in the middle of the Pacific near the equator. This coast city sits right on white sand beaches with Diamond Head Mt. at the far south", 2, "mmanchee", new DateTime(2020, 10, 28, 11, 22, 3, 730, DateTimeKind.Local).AddTicks(8749) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
