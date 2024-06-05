using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class Menu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ingridients",
                table: "MenuItems",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.Id);
                });

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


            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Beverages" },
                    { 2, "Pastries" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "CategoryId", "ImageUrl", "Ingridients", "Name", "Price" },
                values: new object[] { 1, 1, "https://gcdnb.pbrd.co/images/8aUyf2fuAaV5.png?o=1", "MILK, BREWED ESPRESSO", "Cappuccino", 4.99m });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "CategoryId", "ImageUrl", "Ingridients", "Name", "Price" },
                values: new object[] { 2, 1, "https://www.starbucksathome.com/ca/sites/default/files/styles/rdp_banner_image/public/2021-05/10032021_CafeMocha_CS-min.png?itok=eUNrd5Z2", "MILK, BREWED ESPRESSO, MOCHA SAUCE [WATER, SUGAR, COCOA PROCESSED WITH ALKALI, NATURAL FLAVOR], WHIPPED CREAM [CREAM (CREAM, MONO AND DIGLYCERIDES, CARAGEENAN), VANILLA SYRUP (SUGAR, WATER, NATURAL FLAVORS, POTASSIUM SORBATE, CITRIC ACID)]", "Caffè Mocha", 6.99m });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "CategoryId", "ImageUrl", "Ingridients", "Name", "Price" },
                values: new object[] { 3, 2, "https://gcdnb.pbrd.co/images/jOdPGzRw5PFS.png?o=1", "Sugar, Enriched Wheat Flour [Wheat Flour, Niacin, Reduced Iron, Thiamine Mononitrate, Riboflavin, Folic Acid], Blueberries, Plain Yogurt [Milk, Skim Milk, Skim Milk Powder, Whey, Bacterial Culture], Soybean And / Or Canola Oil, Eggs, Honey, Baking Powder [Sodium Acid Pyrophosphate, Cornstarch, Sodium Bicarbonate, Monocalcium Phosphate], Lemon Zest [Lemon Peel, Sugar, Lemon Oil], Natural Flavor, Sea Salt, Whey [Milk], Soy Lecithin", "Blueberry Muffin", 6.99m });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_CategoryId",
                table: "MenuItems",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_MenuCategories_CategoryId",
                table: "MenuItems",
                column: "CategoryId",
                principalTable: "MenuCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_MenuCategories_CategoryId",
                table: "MenuItems");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_CategoryId",
                table: "MenuItems");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "MenuItems");

            migrationBuilder.AlterColumn<string>(
                name: "Ingridients",
                table: "MenuItems",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

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
    }
}
