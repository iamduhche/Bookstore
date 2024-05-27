using BookstoreCafe.Data;
using BookstoreCafe.Data.Entities;
using BookstoreCafe.Models;
using BookstoreCafe.Models.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public IActionResult All(string searchString, string sortOrder)
        {
            var books = from b in data.Books
                        select b;

            if (!string.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Title.Contains(searchString) || s.Author.Contains(searchString));
            }

            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewData["AuthorSortParm"] = sortOrder == "Author" ? "author_desc" : "Author";
            ViewData["PriceSortParm"] = sortOrder == "Price" ? "price_desc" : "Price";

            switch (sortOrder)
            {
                case "title_desc":
                    books = books.OrderByDescending(b => b.Title);
                    break;
                case "Author":
                    books = books.OrderBy(b => b.Author);
                    break;
                case "author_desc":
                    books = books.OrderByDescending(b => b.Author);
                    break;
                case "Price":
                    books = books.OrderBy(b => b.Price);
                    break;
                case "price_desc":
                    books = books.OrderByDescending(b => b.Price);
                    break;
                default:
                    books = books.OrderBy(b => b.Title);
                    break;
            }

            return View(books.ToList());
        }

        public IActionResult Details(int id)
        {
            var book = data.Books
                .Include(b => b.Genre) // Assuming you have a navigation property Genre in your Book entity
                .FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            var model = new BookDetailsViewModel
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

            return View(model);
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

        public IActionResult Edit(int id)
        {
            var book = this.data.Books.Find(id);

            if (book is null)
            {
                return BadRequest();
            }

            var bookModel = new BookFormModel()
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
                Genres = this.GetBookGenres()
            };

            return View(bookModel);

        }

        [HttpPost]
        public IActionResult Edit(int id, BookFormModel model)
        {
            var book = this.data.Books.Find(id);
            if (book is null)
            {
                return this.View();
            }

            if (!this.data.Genres.Any(g => g.Id == model.GenreId))
            {
                ModelState.AddModelError("GenreId", "Selected genre does not exist.");
            }


            if (!ModelState.IsValid)
            {
                model.Genres = this.GetBookGenres();
                return View(model);
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

            this.data.SaveChanges();

            return RedirectToAction(nameof(Details), new { id = book.Id });
        }

        public IActionResult Delete(int id)
        {
            var book = this.data.Books.Find(id);

            if (book is null)
            {
                return BadRequest();
            }

            var model = new BookViewModel()
            {
                Title = book.Title,
                Author = book.Author,
                ImageUrl = book.ImageUrl
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(BookViewModel model)
        {
            var book = this.data.Books.Find(model.Id);

            if (book is null)
            {
                return BadRequest();
            }

            this.data.Books.Remove(book);
            this.data.SaveChanges();

            return RedirectToAction(nameof(All));
        }
    }
}