using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b49d7ca3-4994-4562-8d76-91a5f43fe2d4", "Guest", "Guestov", "AQAAAAEAACcQAAAAEJ682cMqE+yi9VM+zZOYX+vcWqpJZ/UPBNZnxVQukAeXhEao17HtdvwjcTcov/J0Iw==", "78ad09a4-9a6e-4eba-8004-e905eb8adec4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eda3289-1e40-4854-add6-4902276de5be", "Agent", "Agentov", "AQAAAAEAACcQAAAAEJp9WXnZhDREnFc5UlwZoUdjFsHMWpX2CA0j4uAjhkSeh904psDNZWFHANubmeEDoA==", "473bfb19-e65c-48d1-a56a-3067a34fa87c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e43ce836-997d-4927-ac59-74e8c41bbfd3", 0, "ee7ff7d0-2b9e-43e8-a531-4f5cafdddeb3", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", null, null, false, "b960911d-d669-4c3a-9e8b-6170b96baa9e", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 3, "+359888888887", "e43ce836-997d-4927-ac59-74e8c41bbfd3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3");

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
    }
}
