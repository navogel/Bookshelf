using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf35.Migrations
{
    public partial class dbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecfb8eb7-ae4b-4561-8201-8c14480ef99b", "AQAAAAEAACcQAAAAEM0kYK6rVcltBKdAaUWgLlyridNk26YU0MNl5CuRrxsLSGFVRDeWCG3MFQ0kyi2ZhA==" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[] { 2, "00000000-ffff-ffff-ffff-ffffffffffff", "Jersey Mike" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", "Jimmy John" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[] { 1, null, 1, "Sammys", 10, "Free Smells", 1990 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[] { 2, null, 2, "Sammys", 1, "HeHaw the complete History", 1999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f565585-f717-4ba4-a8aa-8e23cd5a64e4", "AQAAAAEAACcQAAAAELL5HIvy+kXcDdf9sqyZgK6KxLiT74o6Bj3do3fDhyNegFpCHlrCVCzQFv+GvvNVyQ==" });
        }
    }
}
