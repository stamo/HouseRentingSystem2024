using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class RenterUserFKAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(450)",
                nullable: true,
                comment: "User id of the renterer",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "User id of the renterer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19eaeaa2-0107-49ae-8b59-5e2f7a926d52", "AQAAAAEAACcQAAAAEEQO5q0J73qKgG9g3JSI0ijX3OjppteN+q94G24+wTwOFBOJ0kITxG560BFtk0n0VA==", "c8e4ca3c-2171-497c-b4c6-f47c762ac668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a34659-2e28-4932-99c4-d366f0ae81d0", "AQAAAAEAACcQAAAAECA2bJgucEgBVfbhO9qN0Kb/vMNGPupyGthNiWfMVhodgPCNpboZanCOHvZN1Y6qBw==", "ce39b7ee-8c5c-4a1c-be9c-ee2766d54fae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24005c0f-5f61-4b26-8ec3-68365979f58e", "AQAAAAEAACcQAAAAEMZClwI4zRJcYQhyJ2rPF5xlrqKKo9OWAYFCN4tBapA85aqaq1t4JyMfXjVg+AsBkA==", "1029060d-bcf7-4d7d-9551-f0bb6b9e416f" });

            migrationBuilder.CreateIndex(
                name: "IX_Houses_RenterId",
                table: "Houses",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses",
                column: "RenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Houses_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User id of the renterer",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldComment: "User id of the renterer");

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

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId");
        }
    }
}
