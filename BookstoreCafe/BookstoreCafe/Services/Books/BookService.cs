﻿using BookstoreCafe.Data;
using BookstoreCafe.Data.Entities;
using BookstoreCafe.Models.Books;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookstoreCafe.Services.Books
{
    public class BookService : IBookService
    {
        private readonly BookCafeDbContext _context;

        public BookService(BookCafeDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.Include(b => b.Genre);
        }

        public IEnumerable<Book> SearchBooks(string searchString)
        {
            return _context.Books
                .Include(b => b.Genre)
                .Where(b => b.Title.Contains(searchString) || b.Author.Contains(searchString));
        }

        public IEnumerable<Book> SortBooks(IEnumerable<Book> books, string sortOrder)
        {
            switch (sortOrder)
            {
                case "title_desc":
                    return books.OrderByDescending(b => b.Title);
                case "Author":
                    return books.OrderBy(b => b.Author);
                case "author_desc":
                    return books.OrderByDescending(b => b.Author);
                case "Price":
                    return books.OrderBy(b => b.Price);
                case "price_desc":
                    return books.OrderByDescending(b => b.Price);
                default:
                    return books.OrderBy(b => b.Title);
            }
        }

        public BookDetailsViewModel GetBookDetails(int id)
        {
            var book = _context.Books
                .Include(b => b.Genre)
                .FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return null;
            }

            return new BookDetailsViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                YearOfRelease = book.YearOfRelease,
                NumberOfPages = book.NumberOfPages,
                TypeOfCover = book.TypeOfCover,
                ImageUrl = book.ImageUrl,
                Price = book.Price,
                Genre = book.Genre.Name
            };
        }

        public IEnumerable<BookGenreViewModel> GetAllGenres()
        {
            return _context.Genres
                .Select(g => new BookGenreViewModel
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToList();
        }

        public void AddBook(BookFormModel model)
        {
            var book = new Book
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                Price = model.Price,
                YearOfRelease = model.YearOfRelease,
                NumberOfPages = model.NumberOfPages,
                TypeOfCover = model.TypeOfCover,
                ImageUrl = model.ImageUrl,
                GenreId = model.GenreId
            };

            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public BookFormModel MapBookToFormModel(Book book)
        {
            return new BookFormModel
            {
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                Price = book.Price,
                YearOfRelease = book.YearOfRelease,
                NumberOfPages = book.NumberOfPages,
                TypeOfCover = book.TypeOfCover,
                ImageUrl = book.ImageUrl,
                GenreId = book.GenreId,
                Genres = GetAllGenres()
            };
        }

        public void UpdateBook(int id, BookFormModel model)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return;
            }

            book.Title = model.Title;
            book.Author = model.Author;
            book.Description = model.Description;
            book.YearOfRelease = model.YearOfRelease;
            book.NumberOfPages = model.NumberOfPages;
            book.TypeOfCover = model.TypeOfCover;
            book.ImageUrl = model.ImageUrl;
            book.Price = model.Price;
            book.GenreId = model.GenreId;

            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return;
            }

            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public BookViewModel MapBookToViewModel(Book book)
        {
            return new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                ImageUrl = book.ImageUrl
            };
        }
    }
}