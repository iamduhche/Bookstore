using BookstoreCafe.Data.Entities;
using BookstoreCafe.Models.Books;
using BookstoreCafe.Services.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookstoreCafe.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult All(string searchString, string sortOrder)
        {
            var books = _bookService.GetAllBooks();

            if (!string.IsNullOrEmpty(searchString))
            {
                books = _bookService.SearchBooks(searchString);
            }

            var sortedBooks = _bookService.SortBooks(books, sortOrder);

            return View(sortedBooks);
        }

        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookDetails(id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        public IActionResult Add()
        {
            var genres = _bookService.GetAllGenres();
            var model = new BookFormModel { Genres = genres };

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(BookFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = _bookService.GetAllGenres();
                return View(model);
            }

            _bookService.AddBook(model);

            return RedirectToAction(nameof(All));
        }

        public IActionResult Edit(int id)
        {
            var book = _bookService.GetBookById(id);

            if (book == null)
            {
                return BadRequest();
            }

            var model = _bookService.MapBookToFormModel(book);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, BookFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = _bookService.GetAllGenres();
                return View(model);
            }

            _bookService.UpdateBook(id, model);

            return RedirectToAction(nameof(Details), new { id });
        }

        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);

            if (book == null)
            {
                return BadRequest();
            }

            var model = _bookService.MapBookToViewModel(book);

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(BookViewModel model)
        {
            _bookService.DeleteBook(model.Id);

            return RedirectToAction(nameof(All));
        }
    }
}
