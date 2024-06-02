using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class GenreFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Adventure");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_BookId",
                table: "ShoppingCartItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20561e21-6c83-4d0c-bfbd-0d4f00712fd2", "AQAAAAEAACcQAAAAEFfbpB7DPqkkqzeHs5pFHXVQ98XNK1tNgvINSLppTfk7ay7qWZ/azpWe142c0uOTjg==", "8bdf5e8f-1496-4fab-855c-d35818763b24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4bc382c-69a1-4547-a30a-0ca320d951b9", "AQAAAAEAACcQAAAAEIe2oDTKHwNhjBrsvJnB8qC+/fFnZ8R00/zik6t+52iWiRcWElPJId+jvDbNXwo5uQ==", "e724a8a0-6f5a-413e-b22e-ef9954f54f42" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Fiction");
        }
    }
}
