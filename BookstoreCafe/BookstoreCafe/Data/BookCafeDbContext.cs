using BookstoreCafe.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookstoreCafe.Data
{
    public class BookCafeDbContext : IdentityDbContext<User>
    {

        private User guestUser { get; set; } = null!;
        private User adminUser { get; set; } = null!;
        private Genre fiction { get; set; } = null!;
        private Genre romance { get; set; } = null!;
        private Book firstBook { get; set; } = null!;
        private Book secondBook { get; set; } = null!;
        private Book thirdBook { get; set; } = null!;

        public BookCafeDbContext(DbContextOptions<BookCafeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<MenuItem> MenuItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            SeedUsers();
            builder.Entity<User>()
                .HasData(this.guestUser,
                        this.adminUser);

            SeedGenres();
            builder.Entity<Genre>()
                .HasData(this.fiction, this.romance);

            SeedBooks();
            builder.Entity<Book>()
                .HasData(this.firstBook,
                        this.secondBook,
                        this.thirdBook);

            base.OnModelCreating(builder);
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<User>();

            this.guestUser = new User()
            {
                Id = "1297764b-dd30-4c4a-be10-a188dde20808",
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM",
                FirstName = "John",
                LastName = "Smith"
            };

            this.guestUser.PasswordHash =
                hasher.HashPassword(this.guestUser, "guest123");

            this.adminUser = new User()
            {
                Id = "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Bate",
                LastName = "Shefa"
            };

            this.adminUser.PasswordHash =
                hasher.HashPassword(this.adminUser, "admin123");
        }

        private void SeedGenres()
        {
            this.fiction = new Genre()
            {
                Id = 1,
                Name = "Fiction"
            };

            this.romance = new Genre()
            {
                Id = 2,
                Name = "Romance"
            };
        }

        private void SeedBooks()
        {
            firstBook = new Book()
            {
                Id = 1,
                Title = "Crimson Rivers",
                Author = "zeppazaariel",
                Description = "Regulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.",
                Price = 19.99M,
                YearOfRelease = 2023,
                NumberOfPages = 2951,
                TypeOfCover = "Hard",
                ImageUrl = "https://i.pinimg.com/originals/71/8c/56/718c5681a2d7f0af950b4fa2897cfad8.png",
                GenreId = this.fiction.Id,

            };

            secondBook = new Book()
            {
                Id = 2,
                Title = "Only the Brave",
                Author = "Solmussa",
                Description = "Regulus Black is angry. He wants revenge. He wants to watch the world burn for all it's done to him. He also wants to make out with James Potter, but that's a secret he'll take to the grave. Vengeance is more important than... whatever it is that chokes him when he lays eyes on Potter.\r\n\r\nJames Potter is confused, because Regulus Black is, all of a sudden, hot. And it's unfair because Sirius is going to kill him if he doesn't get his impulse control in line.",
                Price = 17.99M,
                YearOfRelease = 2023,
                NumberOfPages = 2205,
                TypeOfCover = "Soft",
                ImageUrl = "https://i.etsystatic.com/49073640/r/il/880985/5677125327/il_1080xN.5677125327_bmyu.jpg",
                GenreId = this.romance.Id,

            };

            thirdBook = new Book()
            {
                Id = 3,
                Title = "All the Young Dudes",
                Author = "MsKingBean89",
                Description = "The story starts in the early 1970s and follows Remus Lupin's years at Hogwarts and the love story between himself and Sirius Black. It ends in summer 1995, around the beginning of the events of Harry Potter and the Order of the Phoenix. The story has garnered positive response from critics and fans while also gaining popularity online for its internet memes, fancastings and LGBTQ+ representation.",
                Price = 15.99M,
                YearOfRelease = 2018,
                NumberOfPages = 1800,
                TypeOfCover = "Soft",
                ImageUrl = "https://i.pinimg.com/originals/cb/1c/f9/cb1cf917b12bae747d30079b6601d8bc.jpg",
                GenreId = this.fiction.Id,

            };
        }


    }

}