using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class AdminRole1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "AE8EED0F-B227-4EA2-AB30-EAEC435631A9", "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AE8EED0F-B227-4EA2-AB30-EAEC435631A9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54e7bfb-3bf4-4dd0-9adb-6a86ff07e6cc", "AQAAAAEAACcQAAAAEBEdfYn+tEc7NfkazTjrHw5sTCuTFtSZJ3MOUErcRi1dnqh2qGz3GdwO6xTYtbribA==", "cbffc685-8b8b-4e49-8975-e3fcb1b0120c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "189963f3-e685-460e-a27b-61c61d76dc68", "AQAAAAEAACcQAAAAEB+Lxzhw0mvf0XR+9a3pk38tK6gDNkh+Qrh3sY39nq4p3Ti3c+tbPiZQu+LFLo+RrA==", "f057df3c-09cc-4ca7-bbc5-13239420819a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "AE8EED0F-B227-4EA2-AB30-EAEC435631A9", "aee5e544-df4c-434e-8824-4d9893d0a141", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cfa3c90-6a13-4373-a1a3-e599f856b45c", "AQAAAAEAACcQAAAAEJ0rnKjppDfVSg4BhJEkzmTyPL57o3h3mypaNHp+Llo+EL1Hu3mj5iJ1y77OaNezjg==", "2534be05-8257-4fa9-9090-cab8860d479e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c9203dc-72cc-48a2-9a32-62dde0190417", "AQAAAAEAACcQAAAAEM3kfbcZZSIfx+xQRmX9iZELdD4mSyEbYye1P3Os0zi7CTH1TAMtR2ncC3K0DBE0kA==", "1b01b016-0ce0-4dd3-8644-992423c1ba20" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "AE8EED0F-B227-4EA2-AB30-EAEC435631A9", "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB" });
        }
    }
}
