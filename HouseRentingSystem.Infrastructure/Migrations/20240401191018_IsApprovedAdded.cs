using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class IsApprovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is house approved by admin");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c575d45d-ab4e-4b65-832d-49ab94ed33c9", "AQAAAAEAACcQAAAAEGEkZ6pN3SvongPoZZiMVTKIs2CGU52z8TyZH9aRVHSvTZugO4m9q/9MoOk4GQ7UGQ==", "8482ec3b-65ee-41d5-af16-907e3f4dbd50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6a08b4a-f07f-4e10-83f8-d30b0845bf48", "AQAAAAEAACcQAAAAEMyq3kK9RLn9YRIypHOtK2A/XGA7ODj6+yhwz1RPtXbaC65NvwSr52fFCom/4rKTpA==", "8c056901-de00-4d56-8451-e8fa96315b3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1d4eec8-b4b9-41fa-a1f5-92d81483821f", "AQAAAAEAACcQAAAAEEWB794QJ7uSksYY6GSyEWt8NsckEngQF9zhHWjH7Pr1Fy5yWb1rElRlFqGOo0Vvgg==", "951a97a7-18cc-47b9-bb06-f33176f65bd7" });
        }
    }
}
