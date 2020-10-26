using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "City", "Country", "Details", "Rating", "UserName", "Visited" },
                values: new object[,]
                {
                    { 1, "Seattle", "USA", "A City in the Pacific Northwest surrounded by hills and trees.", 4, "mmanchee", new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437) },
                    { 2, "Stockholm", "Sweden", "A City in northern Europe. Sweden's Capitol.", 5, "gbrown", new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437) },
                    { 3, "Toronto", "Canada", "Canada's most populated city, located just beyond the border near Detroit.", 4, "gbrown", new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437) },
                    { 4, "Shanghai", "China", "A city in China that neighbors Hong-Kong just on the other side of the river.", 4, "gbrown", new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437) },
                    { 5, "Honolulu", "USA", "Located in the middle of the Pacific near the equator. This coast city sits right on white sand beaches with Diamond Head Mt. at the far south", 5, "mmanchee", new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);
        }
    }
}
