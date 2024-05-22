using BookstoreCafe.Data;
using BookstoreCafe.Data.Entities;
using BookstoreCafe.Models;
using BookstoreCafe.Models.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace BookstoreCafe.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookCafeDbContext data;

        public BooksController(BookCafeDbContext data)
        {
            this.data = data;
        }

        public IActionResult All()
        {
            var books = new AllBooksViewModel
            {
                Books = this.data.Books
                    .Select(b => new BookDetailsViewModel
                    {
                        Title = b.Title,
                        ImageUrl = b.ImageUrl,
                        Author = b.Author,
                        Price = b.Price
                    })

            };

            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = this.data.Books.Find(id);
            
            if (book is null)
            {
                return BadRequest();
            }

            var bookModel = new BookDetailsViewModel()
            {
                Title = book.Title,
                Author = book.Author,
                Price = book.Price,
                ImageUrl = book.ImageUrl
            };

            return View(bookModel);
        }


        public IActionResult Add()
        {
            return View(new BookFormModel
            {
                Genres = this.GetBookGenres()
            });


        }
        private IEnumerable<BookGenreViewModel> GetBookGenres() =>
            this.data
            .Genres
            .Select(g => new BookGenreViewModel
            {
                Id = g.Id,
                Name = g.Name
            })
            .ToList();

        [HttpPost]
        public IActionResult Add(BookFormModel model)
        {
            // Check if the GenreId exists in the Genres table
            if (!this.data.Genres.Any(g => g.Id == model.GenreId))
            {
                ModelState.AddModelError("GenreId", "Selected genre does not exist.");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

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

            this.data.Books.Add(book);
            this.data.SaveChanges();

            return RedirectToAction(nameof(Details), new { id = book.Id });
        }
    }
}