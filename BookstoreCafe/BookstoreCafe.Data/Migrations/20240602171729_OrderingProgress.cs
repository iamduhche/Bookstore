using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class OrderingProgress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BookId",
                table: "OrderDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
