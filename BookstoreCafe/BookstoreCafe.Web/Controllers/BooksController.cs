using BookstoreCafe.Services.Books;
using Microsoft.AspNetCore.Mvc;
using BookstoreCafe.Services.Books.Models;
using Microsoft.AspNetCore.Authorization;

namespace BookstoreCafe.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [Authorize(Roles = "Administrator")]
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

        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookDetails(id);
            if (book == null)
            {
                return NotFound();
            }

            string slug = UrlHelper.GenerateSlug(book.Title, book.Author);
            return RedirectToActionPermanent(nameof(Details), new { slug = slug, id = id });
        }

        [HttpGet("Books/Details/{slug}-{id}")]
        public IActionResult Details(string slug, int id)
        {
            var book = _bookService.GetBookDetails(id);
            if (book == null)
            {
                return NotFound();
            }

            string expectedSlug = UrlHelper.GenerateSlug(book.Title, book.Author);
            if (slug != expectedSlug)
            {
                return RedirectToActionPermanent(nameof(Details), new { slug = expectedSlug, id = id });
            }

            return View(book);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Add()
        {
            var genres = _bookService.GetAllGenres();
            var model = new BookFormModel { Genres = genres };

            return View(model);
        }

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _bookService.DeleteBook(id);

            return RedirectToAction(nameof(All));
        }
    }
}
