using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8245a1e-930f-4a91-9929-d98c8c86d464", "AQAAAAEAACcQAAAAEJpIXVeamzxqRNTLACajrWurXt5CEKNOWc9FwyKOM7Doi3ggSFdanmclELv7cvHjxQ==", "b8b28c20-9a9c-48a1-8f54-189a40fe6381" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33e2a3c0-07f0-4fe0-ab1b-ec673a858115", "AQAAAAEAACcQAAAAEEYz87XYPk9BouCnQxOelJEBpXpxaS7+xcSmomBQ3j9rzt/WmSNafeAS/BJ8ok0KwQ==", "bd24f769-b7b4-42ff-9e03-0553a85b2814" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "143846a5-f592-4217-b46a-28ac5a0a27b6", "AQAAAAEAACcQAAAAELEFDExqWRUNBnAvwXwa3JpFNQNClPx5nFAus7d95M+4T6/PisTaAdvR3+by5X2bpQ==", "2bd52b81-bfb3-4196-be53-fad43dcce2c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1204fb67-5362-4fd4-9243-e68b86086c7d", "AQAAAAEAACcQAAAAEEjG8dNDADN4I6WW+fn6YoFh2+Q6RuM7d/gsaWJqMVmbbv6a+UBqacDDclI8z/+3uw==", "6aeb1fb3-affa-4611-a81e-ee261f3435f7" });
        }
    }
}
