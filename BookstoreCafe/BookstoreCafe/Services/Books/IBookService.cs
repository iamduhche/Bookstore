using BookstoreCafe.Data.Entities;
using BookstoreCafe.Models.Books;
using System.Collections.Generic;

namespace BookstoreCafe.Services.Books
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> SearchBooks(string searchString);
        IEnumerable<Book> SortBooks(IEnumerable<Book> books, string sortOrder);
        BookDetailsViewModel GetBookDetails(int id);
        IEnumerable<BookGenreViewModel> GetAllGenres();
        void AddBook(BookFormModel model);
        Book GetBookById(int id);
        BookFormModel MapBookToFormModel(Book book);
        void UpdateBook(int id, BookFormModel model);
        void DeleteBook(int id);
        BookViewModel MapBookToViewModel(Book book);
    }
}
