using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class MenuCustomImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                column: "ImageUrl",
                value: "https://gcdnb.pbrd.co/images/3EpytMWSVnJJ.jpg?o=1");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://gcdnb.pbrd.co/images/DV9TOMYWI4gF.jpg?o=1");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://gcdnb.pbrd.co/images/PkcXbeAeqOxS.jpg?o=1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26ca6ef4-fe74-4d17-a94f-28d7c8414354", "AQAAAAEAACcQAAAAED7vji4fhr80+AtIXBuA6DjogF+0xCdAbrDhmr4TugZakp3TOpn1pMWYM43zFOggpw==", "e5be95a6-cc79-45e7-aed4-a9006d88a4e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ff560a-7133-4398-82aa-4dde4b17c3dc", "AQAAAAEAACcQAAAAEN9cIDyYdqWYuYf6m62WPPfuTO1BQrcf0GX6KZnne8/4Cx31HTWq7/wlsu+l5x9adw==", "dc16f25c-91dd-4385-90e9-08e3d25b610c" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://gcdnb.pbrd.co/images/8aUyf2fuAaV5.png?o=1");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.starbucksathome.com/ca/sites/default/files/styles/rdp_banner_image/public/2021-05/10032021_CafeMocha_CS-min.png?itok=eUNrd5Z2");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://gcdnb.pbrd.co/images/jOdPGzRw5PFS.png?o=1");
        }
    }
}
