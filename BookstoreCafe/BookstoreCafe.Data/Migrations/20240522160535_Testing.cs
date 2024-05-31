using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class Testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Books");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0ae2117-22d7-4679-b661-091863434b53", "AQAAAAEAACcQAAAAEOgrNQMJ1Q/s1vtFOXAzpFARR3dBzJ/Xj9I2b033/AwzkMDqmzl9tvIKJ2C+AUWtxA==", "0ebfe101-05f8-43d9-b969-912853735549" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3a6dfc6-7ea3-48c0-8ba3-50ec929941bd", "AQAAAAEAACcQAAAAEGc+AlghIvTFD5/jAl2YmbHjBjgFCI5RtCEpb44BCPWwrQq13JjYzL/XoQ0RIx2a4A==", "32a57c4c-52f7-43e7-b493-28c42a61ab4b" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Language",
                value: "English");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Language",
                value: "English");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Language",
                value: "English");
        }
    }
}
