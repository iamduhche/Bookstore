using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class SeedRolesnzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ebc0aba-c9e8-4dd9-8556-4a1665a28334", "AQAAAAEAACcQAAAAEFZUN4Ki7hkobl++975edqs+9NkhDCp9tOaKf3gDB3YQ2bf9twxg5RfDnCWZ3elxDg==", "5c320371-24df-46a4-bd67-75aa9a045084" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06a6c5e8-31b3-4274-b29b-2b33d2afb363", "AQAAAAEAACcQAAAAENWw2Cqb+5VysvRvM7mAr791D0eER/aALD8dvh2qYDHWsf3opiGrEC12oSN5pA+qWw==", "1dc2d43f-10f3-4fb7-8078-d3bdb2a49017" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "NumberOfPages", "Price", "Title" },
                values: new object[] { "There's never enough time. They had ten years, and still, that wasn't enough...\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.", "https://gcdnb.pbrd.co/images/UsjakXzwxKbS.png?o=1", 743, 18.99m, "Crimson Rivers Book 1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ImageUrl", "NumberOfPages", "Price", "Title", "TypeOfCover" },
                values: new object[] { "zeppazariel", "It's devastating that a tear shed in heartbreak is the only thing that they get to have for themselves. But this is what they are. A great, big tragedy...\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.", 1, "https://gcdnb.pbrd.co/images/QKZPVkKBERJl.png?o=1", 694, 18.99m, "Crimson Rivers Book 2", "Hard" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ImageUrl", "NumberOfPages", "Price", "Title", "TypeOfCover", "YearOfRelease" },
                values: new object[] { "zeppazariel", "Hurting together. Mourning together. Terrified together. Never one without the other, evein in pain. One day at a time, together, all of them.\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.", "https://gcdnb.pbrd.co/images/YyL1yTBQMKNd.png?o=1", 757, 18.99m, "Crimson Rivers Book 3", "Hard", 2023 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54e7bfb-3bf4-4dd0-9adb-6a86ff07e6cc", "AQAAAAEAACcQAAAAEBEdfYn+tEc7NfkazTjrHw5sTCuTFtSZJ3MOUErcRi1dnqh2qGz3GdwO6xTYtbribA==", "cbffc685-8b8b-4e49-8975-e3fcb1b0120c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "189963f3-e685-460e-a27b-61c61d76dc68", "AQAAAAEAACcQAAAAEB+Lxzhw0mvf0XR+9a3pk38tK6gDNkh+Qrh3sY39nq4p3Ti3c+tbPiZQu+LFLo+RrA==", "f057df3c-09cc-4ca7-bbc5-13239420819a" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "NumberOfPages", "Price", "Title" },
                values: new object[] { "Regulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.", "https://i.pinimg.com/originals/71/8c/56/718c5681a2d7f0af950b4fa2897cfad8.png", 2951, 19.99m, "Crimson Rivers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ImageUrl", "NumberOfPages", "Price", "Title", "TypeOfCover" },
                values: new object[] { "Solmussa", "Regulus Black is angry. He wants revenge. He wants to watch the world burn for all it's done to him. He also wants to make out with James Potter, but that's a secret he'll take to the grave. Vengeance is more important than... whatever it is that chokes him when he lays eyes on Potter.\r\n\r\nJames Potter is confused, because Regulus Black is, all of a sudden, hot. And it's unfair because Sirius is going to kill him if he doesn't get his impulse control in line.", 2, "https://i.etsystatic.com/49073640/r/il/880985/5677125327/il_1080xN.5677125327_bmyu.jpg", 2205, 17.99m, "Only the Brave", "Soft" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ImageUrl", "NumberOfPages", "Price", "Title", "TypeOfCover", "YearOfRelease" },
                values: new object[] { "MsKingBean89", "The story starts in the early 1970s and follows Remus Lupin's years at Hogwarts and the love story between himself and Sirius Black. It ends in summer 1995, around the beginning of the events of Harry Potter and the Order of the Phoenix. The story has garnered positive response from critics and fans while also gaining popularity online for its internet memes, fancastings and LGBTQ+ representation.", "https://i.pinimg.com/originals/cb/1c/f9/cb1cf917b12bae747d30079b6601d8bc.jpg", 1800, 15.99m, "All the Young Dudes", "Soft", 2018 });
        }
    }
}
