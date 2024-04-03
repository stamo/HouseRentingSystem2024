using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Agent Agentov", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "user:fullname", "Guest Guestov", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "user:fullname", "Great Admin", "e43ce836-997d-4927-ac59-74e8c41bbfd3" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff68398e-3588-4c9a-bc24-3f10fb2ea57a", "AQAAAAEAACcQAAAAEAHO+tV+0+IYy+8o+RcFI1IwIXLCmk+9m6+Ih2z3u8JPae+A8luLot0DFQRMHUnkvA==", "063d0d0a-c2b1-4952-b296-74daea3403a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11fb932a-e03f-41a6-bc58-9325812a1f75", "AQAAAAEAACcQAAAAEMh3I7u67DymyRRLYAizqX1kxWa4FrLQ/q0+Ctxcm+qb9H9ZshK+C69yw0O8WUf0EQ==", "e302db9f-0147-4937-ad19-d9c552683c5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b61b9063-e032-4255-8505-5f2d4fd21692", "AQAAAAEAACcQAAAAENbKI7o4Wm5fSAm1IJ3wqKC+6JwHUXInyXoZjBUdjw0Brp033NMD7U7DvVrB9u3zQw==", "ece7c381-48e9-46d8-bce0-3ae85a122666" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2620fe5e-0f25-478c-a660-6c2b5515f01d", "AQAAAAEAACcQAAAAEAyGYnK5mJsHVUwUqxnB7vEG4p1aZh/70imdbyD5ASvqOPjqWE1qMv/p1FGYY91luw==", "e960806d-ff08-43f9-9410-71a11b7c0663" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dae577c-c89a-413c-99fd-21afcb2e0c2a", "AQAAAAEAACcQAAAAEEVBNxea0S7ZEDpP1LJiBmpNa+cF7AHNJql9jl6tonEVJKWi7FuZWZGoVhH3shW0HQ==", "4c0ca107-8a2e-4861-8a56-4a36c064e356" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "696573df-a491-46be-93c3-40aa68e4d082", "AQAAAAEAACcQAAAAEHJzLMp2AUzJ3kju9BUs4ydTodPZVnmV9NHwO8RxA5LpjV3gGKTZmw8NAdrRHmG8Xw==", "3da594e3-42a7-41d6-b618-5b4e55bb49ca" });
        }
    }
}
