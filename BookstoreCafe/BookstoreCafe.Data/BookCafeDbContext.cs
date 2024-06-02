﻿using BookstoreCafe.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BookstoreCafe.Data
{
    public class BookCafeDbContext : IdentityDbContext<User>
    {
        private User guestUser { get; set; } = null!;
        private User adminUser { get; set; } = null!;
        private Genre adventure { get; set; } = null!;
        private Genre romance { get; set; } = null!;
        private Genre youngAdult { get; set; } = null!;
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
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<ShoppingCart>()
                .HasMany(c => c.Items)
                .WithOne(i => i.ShoppingCart)
                .HasForeignKey(i => i.ShoppingCartId);

            builder.Entity<ShoppingCartItem>()
                .HasOne(i => i.Book)
                .WithMany()
                .HasForeignKey(i => i.BookId);

            SeedUsers();
            builder.Entity<User>()
                .HasData(this.guestUser,
                        this.adminUser);

            SeedGenres();
            builder.Entity<Genre>()
                .HasData(this.adventure, this.romance);

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
            this.adventure = new Genre()
            {
                Id = 1,
                Name = "Adventure"
            };

            this.romance = new Genre()
            {
                Id = 2,
                Name = "Romance"
            };

            this.youngAdult = new Genre()
            {
                Id = 3,
                Name = "Young Adult"
            };

        }

        private void SeedBooks()
        {
            firstBook = new Book()
            {
                Id = 1,
                Title = "Crimson Rivers Book 1",
                Author = "zeppazariel",
                Description = "There's never enough time. They had ten years, and still, that wasn't enough...\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.",
                Price = 18.99M,
                YearOfRelease = 2023,
                NumberOfPages = 743,
                TypeOfCover = "Hard",
                ImageUrl = "https://gcdnb.pbrd.co/images/UsjakXzwxKbS.png?o=1",
                GenreId = this.adventure.Id,

            };

            secondBook = new Book()
            {
                Id = 2,
                Title = "Crimson Rivers Book 2",
                Author = "zeppazariel",
                Description = "It's devastating that a tear shed in heartbreak is the only thing that they get to have for themselves. But this is what they are. A great, big tragedy...\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.",
                Price = 18.99M,
                YearOfRelease = 2023,
                NumberOfPages = 694,
                TypeOfCover = "Hard",
                ImageUrl = "https://gcdnb.pbrd.co/images/QKZPVkKBERJl.png?o=1",
                GenreId = this.adventure.Id,
            };

            thirdBook = new Book()
            {
                Id = 3,
                Title = "Crimson Rivers Book 3",
                Author = "zeppazariel",
                Description = "Hurting together. Mourning together. Terrified together. Never one without the other, evein in pain. One day at a time, together, all of them.\n \nRegulus Black was fifteen the first time his name was called at a reaping. He's twenty-five when it happens to him again. A lot has changed in that time, and one of them is that he's ready to do whatever it takes to make it home. Nothing or no one will stop him, not even James Potter.\r\n\r\nJames Potter has no plans to stop Regulus Black from making it home. In fact, his plans revolve around the opposite. He has his reasons, but he's made his choice to get Regulus out of the arena, even knowing it'll be the last thing he ever does.\r\n\r\nSirius Black was sixteen when he volunteered to take his little brother's place in the arena. At twenty-six, without the option to do it again, he has no choice but to be a mentor to his brother and best friend, knowing that only one of them can make it back out.\r\n\r\nTwo names called, a mentor on the verge of falling apart, and more secrets and grief between all of them than they know how to handle. None of them are prepared for what comes next, or how far they'll go to make it through.",
                Price = 18.99M,
                YearOfRelease = 2023,
                NumberOfPages = 757,
                TypeOfCover = "Hard",
                ImageUrl = "https://gcdnb.pbrd.co/images/YyL1yTBQMKNd.png?o=1",
                GenreId = this.adventure.Id,

            };
        }


    }

}