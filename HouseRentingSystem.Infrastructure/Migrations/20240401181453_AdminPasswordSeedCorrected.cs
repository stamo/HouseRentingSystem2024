using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminPasswordSeedCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b49d7ca3-4994-4562-8d76-91a5f43fe2d4", "AQAAAAEAACcQAAAAEJ682cMqE+yi9VM+zZOYX+vcWqpJZ/UPBNZnxVQukAeXhEao17HtdvwjcTcov/J0Iw==", "78ad09a4-9a6e-4eba-8004-e905eb8adec4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eda3289-1e40-4854-add6-4902276de5be", "AQAAAAEAACcQAAAAEJp9WXnZhDREnFc5UlwZoUdjFsHMWpX2CA0j4uAjhkSeh904psDNZWFHANubmeEDoA==", "473bfb19-e65c-48d1-a56a-3067a34fa87c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee7ff7d0-2b9e-43e8-a531-4f5cafdddeb3", null, "b960911d-d669-4c3a-9e8b-6170b96baa9e" });
        }
    }
}
