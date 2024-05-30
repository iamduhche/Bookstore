using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class AdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Author",
                value: "zeppazariel");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "AE8EED0F-B227-4EA2-AB30-EAEC435631A9", "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "acbd665a-fd54-4e46-8f45-0f8a099e8e9c", "AQAAAAEAACcQAAAAEOO+f35Me/m4fYQFIwMaAXbxTi9iyLyX4BPODmuiNTFYlP9A64h6t/8cHu9gfLMX3w==", "f9522f3a-6bbd-45d1-aa2b-a83b005a1186" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e12d2e7c-58ec-4932-893c-25fbb283a024", "AQAAAAEAACcQAAAAEFR4NZ4I4sXgntN+fkLvu+QqrVWCtLSF6i5a9Qmp9yKlfZCzigNowKGO+1Zp+cNAug==", "d23f4c58-c9a6-4cc5-804e-cd0b152f00b0" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Author",
                value: "zeppazaariel");
        }
    }
}
