using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class CustomImages1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://gcdnb.pbrd.co/images/A6obyfAlzZbf.jpg?o=1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca10ecd7-afe0-48fa-9f2c-1ca6ab68836c", "AQAAAAEAACcQAAAAEGQ3M1JiM5Mvu0h+PJluizwlitpJzC+FAcILE15Kng28YidABepl468xEOCuHOmxyg==", "9c257411-5899-4a50-b884-c163dd85fb35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c49e8ec-9d72-4370-b985-5409c98d05c7", "AQAAAAEAACcQAAAAEA65/bWhoGaXylAV053h62TbA7/UjxZa5s5E5KHa7qPSVaJe0ppg4t5gcDG2sslXNA==", "c85a4b96-299d-4e4b-ad9d-11744e2f5671" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://gcdnb.pbrd.co/images/DV9TOMYWI4gF.jpg?o=1");
        }
    }
}
