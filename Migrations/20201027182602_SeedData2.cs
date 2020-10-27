using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Visited",
                value: new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Visited",
                value: new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Visited",
                value: new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Visited",
                value: new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Visited",
                value: new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "City", "Country", "Details", "Rating", "UserName", "Visited" },
                values: new object[,]
                {
                    { 6, "Seattle", "USA", "A City in the Pacific Northwest surrounded by hills and trees.", 1, "mmanchee", new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741) },
                    { 7, "Stockholm", "Sweden", "A City in northern Europe. Sweden's Capitol.", 2, "gbrown", new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741) },
                    { 8, "Toronto", "Canada", "Canada's most populated city, located just beyond the border near Detroit.", 1, "gbrown", new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741) },
                    { 9, "Shanghai", "China", "A city in China that neighbors Hong-Kong just on the other side of the river.", 2, "gbrown", new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741) },
                    { 10, "Honolulu", "USA", "Located in the middle of the Pacific near the equator. This coast city sits right on white sand beaches with Diamond Head Mt. at the far south", 2, "mmanchee", new DateTime(2020, 10, 27, 11, 26, 1, 975, DateTimeKind.Local).AddTicks(3741) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Visited",
                value: new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Visited",
                value: new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Visited",
                value: new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Visited",
                value: new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Visited",
                value: new DateTime(2020, 10, 26, 13, 13, 0, 229, DateTimeKind.Local).AddTicks(3437));
        }
    }
}
