using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ingridients = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    YearOfRelease = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeOfCover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1297764b-dd30-4c4a-be10-a188dde20808", 0, "f0ae2117-22d7-4679-b661-091863434b53", "guest@mail.com", false, "John", "Smith", false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAEOgrNQMJ1Q/s1vtFOXAzpFARR3dBzJ/Xj9I2b033/AwzkMDqmzl9tvIKJ2C+AUWtxA==", null, false, "0ebfe101-05f8-43d9-b969-912853735549", false, "guest@mail.com" },
                    { "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB", 0, "f3a6dfc6-7ea3-48c0-8ba3-50ec929941bd", "admin@mail.com", false, "Bate", "Shefa", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEGc+AlghIvTFD5/jAl2YmbHjBjgFCI5RtCEpb44BCPWwrQq13JjYzL/XoQ0RIx2a4A==", null, false, "32a57c4c-52f7-43e7-b493-28c42a61ab4b", false, "admin@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "GenreId", "ImageUrl", "Language", "NumberOfPages", "Price", "Title", "TypeOfCover", "YearOfRelease" },
                values: new object[] { 1, "zeppazaariel", "Regulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.", 1, "https://i.pinimg.com/originals/71/8c/56/718c5681a2d7f0af950b4fa2897cfad8.png", "English", 2951, 19.99m, "Crimson Rivers", "Hard", 2023 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "GenreId", "ImageUrl", "Language", "NumberOfPages", "Price", "Title", "TypeOfCover", "YearOfRelease" },
                values: new object[] { 2, "Solmussa", "Regulus Black is angry. He wants revenge. He wants to watch the world burn for all it's done to him. He also wants to make out with James Potter, but that's a secret he'll take to the grave. Vengeance is more important than... whatever it is that chokes him when he lays eyes on Potter.\r\n\r\nJames Potter is confused, because Regulus Black is, all of a sudden, hot. And it's unfair because Sirius is going to kill him if he doesn't get his impulse control in line.", 2, "https://i.etsystatic.com/49073640/r/il/880985/5677125327/il_1080xN.5677125327_bmyu.jpg", "English", 2205, 17.99m, "Only the Brave", "Soft", 2023 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "GenreId", "ImageUrl", "Language", "NumberOfPages", "Price", "Title", "TypeOfCover", "YearOfRelease" },
                values: new object[] { 3, "MsKingBean89", "The story starts in the early 1970s and follows Remus Lupin's years at Hogwarts and the love story between himself and Sirius Black. It ends in summer 1995, around the beginning of the events of Harry Potter and the Order of the Phoenix. The story has garnered positive response from critics and fans while also gaining popularity online for its internet memes, fancastings and LGBTQ+ representation.", 1, "https://i.pinimg.com/originals/cb/1c/f9/cb1cf917b12bae747d30079b6601d8bc.jpg", "English", 1800, 15.99m, "All the Young Dudes", "Soft", 2018 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
