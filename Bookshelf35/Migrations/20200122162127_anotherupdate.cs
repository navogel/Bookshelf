using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf35.Migrations
{
    public partial class anotherupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d9234a3-589f-4e75-aa79-c53e75b2f191", "AQAAAAEAACcQAAAAEPpMz9lYHAFLzfHt4oJiRcUd7gBbDLx3peHVyRR+W0/KoXfAfyUoMTCIgwM18qxihA==" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApplicationUserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApplicationUserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecfb8eb7-ae4b-4561-8201-8c14480ef99b", "AQAAAAEAACcQAAAAEM0kYK6rVcltBKdAaUWgLlyridNk26YU0MNl5CuRrxsLSGFVRDeWCG3MFQ0kyi2ZhA==" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApplicationUserId",
                value: null);
        }
    }
}
