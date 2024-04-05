using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a2d895a-e80d-400f-8923-2ebab20dcc47", "", "", "AQAAAAEAACcQAAAAEBJ9tE/g4+Nk2blqmUMhYkTyNpbqd3GfOCfmVuZY4+s8ergcEA+U+t5oMzpqBH+nVg==", "22b7569b-5592-4562-90f0-1bab076c5574" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bb0ee7f-1a5b-4c13-bf28-fbd9ea79cf70", "", "", "AQAAAAEAACcQAAAAEK76szP5hIP/Clu/ovyKWAcuxs9CO92II5rnuyciidX6P7PhkjcKwuHURw5LooRb8Q==", "bd7bc0df-2973-4fb8-a284-e2ad1f053272" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
        }
    }
}
