using BookstoreCafe.Data.Entities;
using BookstoreCafe.Services.Books.Models;
using System.Collections.Generic;

namespace BookstoreCafe.Services.Books
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> SearchBooks(string searchString);
        IEnumerable<Book> SortBooks(IEnumerable<Book> books, string sortOrder);
        BookDetailsServiceModel GetBookDetails(int id);
        IEnumerable<BookGenreServiceModel> GetAllGenres();
        void AddBook(BookFormServiceModel model);
        Book GetBookById(int id);
        BookFormServiceModel MapBookToFormModel(Book book);
        void UpdateBook(int id, BookFormServiceModel model);
        void DeleteBook(int id);
        BookServiceModel MapBookToViewModel(Book book);
    }
}
