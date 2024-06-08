using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class DataConstants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MenuCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75e4a3f8-12b9-422b-8dfc-6c4789a8f66d", "AQAAAAEAACcQAAAAEG1kGKmLL2bj+g38sfGG/MGgKJgozhs4nBxc4oIF7hcOyq00+/V7XiImqSQXl6uyDg==", "040126c3-f9b4-4012-836f-9190fff6bd66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c322827-dec0-464d-8266-2f19a130eca4", "AQAAAAEAACcQAAAAEJ3U73Mw/kT+IpK0Ecm7P5YUjfwlOBOPlQnd9wXYS99l5ZQih3vRoWtSApvfVChtJw==", "94d5dcb2-64f1-4cfa-bff5-55976d68c1ad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MenuCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cbe184e-32a4-48f7-9b78-3ce9b780f09e", "AQAAAAEAACcQAAAAED7pAIswAPV0PtOxm1MdN65xPFZW1Fqrc4NSuGBfnLtnYftqrijzT4xdnOvl0sZl5A==", "fb7f2446-aaaf-46f7-8003-da6df113dacf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60a6b29c-a295-491d-9cad-7d38caeb4629", "AQAAAAEAACcQAAAAEMPvUbCsEmLmYJhzPLGgrfQdkjwso5/Lx/KhMtrMYx1yhVIubkFxWVL7lmkvJJP0UA==", "dd5d0bc8-784a-4903-83ec-7a5c043716ba" });
        }
    }
}
