using BookstoreCafe.Data.Entities;
using BookstoreCafe.Services.Books.Models;
using System.Collections.Generic;

namespace BookstoreCafe.Services.Books
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> SearchBooks(string searchString);
        IEnumerable<BookModel> SortBooks(IEnumerable<BookModel> books, string sortOrder);
        IEnumerable<Book> SortBooks(IEnumerable<Book> books, string sortOrder);
        BookDetailsModel GetBookDetails(int id);
        IEnumerable<BookGenreModel> GetAllGenres();
        void AddBook(BookFormModel model);
        Book GetBookById(int id);
        BookFormModel MapBookToFormModel(Book book);
        void UpdateBook(int id, BookFormModel model);
        void DeleteBook(int id);
        BookModel MapBookToViewModel(Book book);
        IEnumerable<BookModel> GetFilteredAndSortedBooks(string searchString, string sortOrder);
    }
}