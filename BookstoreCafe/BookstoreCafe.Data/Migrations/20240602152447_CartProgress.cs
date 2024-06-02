using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class CartProgress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "177d22af-6f76-42b6-8216-84f3a2b25482", "AQAAAAEAACcQAAAAEATkOt41b9JGy0UjQ1/g7NnZdhPW700QD83KKdduRY4M2ILgLFOQEsH5O0ipMlY0fA==", "457e6829-9ca1-4472-9b23-6ef48b6b70b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9846e42a-df81-4df3-915d-a78a66e9c163", "AQAAAAEAACcQAAAAEF668nmvVPWNSCdpIIi3o9b7714Ir4XDfE0emMypEt/u8sXoJvLNbWayRAbad81Y0g==", "e1afcee4-f08c-491b-be31-dfd872687ea5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe1a5c9e-447c-471b-8b19-cd3023ab68eb", "AQAAAAEAACcQAAAAEL5bq9Obf7qJvo/ir631LzfBg5igO5Z8IKZAP6kB7K1o+SlUIQxDniaC2I8TQc4I9A==", "d40d556a-628a-4b0a-acac-dc9302c748d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fca69b9-a4f9-4c8f-b4a8-d7d3f2fe3082", "AQAAAAEAACcQAAAAELUl2RQ+x0gzbJmXLc+iPrlylxjJtAYbWEUnR4KSggBGmk+jCBLTC74G0xpeqi2Hlw==", "9ec75b5d-21e4-4d5f-af6d-fab1a9961a4d" });
        }
    }
}
