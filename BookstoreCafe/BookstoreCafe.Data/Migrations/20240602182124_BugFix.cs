using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class BugFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b35d2f08-48dc-4e34-adb8-6b812c2e8b7a", "AQAAAAEAACcQAAAAENfnlcq5kzdoZvnp0l/0Ly3xRAL7Qv1wjc9eXj4s8rmqASLNZcjnIAn9D+kDkpJoWA==", "321b84a4-ea48-4514-ac90-a0144d2a7b06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a553b90-27c2-4a2d-8606-dfe947a7c1d0", "AQAAAAEAACcQAAAAEGkpDhxMBRFKCmtW3G5KFVcLrql1htsbCLNQokcfKVxzmpuNeUPRwdGIRrpcLlic5A==", "8483a054-bbe6-49dd-8459-0bff6dffa76b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfcdbb2c-3901-46ba-b5a7-90f1a0e56d54", "AQAAAAEAACcQAAAAEGhArYd6v/9tgFP0MUltCVKGN5V397g+EIcqdp3fthSfqYeY3j4dHEmt6Wxur/avKw==", "634044b9-40f0-4d0f-a099-fde97d3bb32a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59b57588-9c88-4fe7-a418-5e590c4d5cda", "AQAAAAEAACcQAAAAEIQ8sTl3rhDNv290MDeO8uw6RsBPPxMmJrW3XPjjijT8BvPejX3v4B8X94+96UZv+A==", "b3ff42a9-4d4d-492e-bdd7-30b0ec2438e9" });
        }
    }
}
