using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class FixIngredientsColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ingridients",
                table: "MenuItems",
                newName: "Ingredients");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ingredients",
                table: "MenuItems",
                newName: "Ingridients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee43760b-30fb-4819-b925-c09a1f79b129", "AQAAAAEAACcQAAAAEIi4QiTZTN3bG3zsC31P+j3V2nKvpNAelfgbdlmF1kBecU9dfjp4T8rsZg+jV2o2Xw==", "b528c84c-5f06-4bbd-a901-062b2451a16f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b3930b8-163a-407c-9ece-2a9d3f76d839", "AQAAAAEAACcQAAAAEJn/gn+0cIi4+9W4aCdLmxaQjehgLwcCXa6RbMPWZu2DdATAVqPo+YwwMDxinWRa8Q==", "76224998-589b-44ca-9b80-b20829405d98" });
        }
    }
}
