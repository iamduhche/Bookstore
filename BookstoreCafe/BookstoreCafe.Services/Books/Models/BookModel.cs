using BookstoreCafe.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.Books.Models
{
    public class BookModel
    {
        public int Id { get; init; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int? YearOfRelease { get; set; }
        public int? NumberOfPages { get; set; }
        public string TypeOfCover { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int GenreId { get; set; }
        public string GenreName { get; init; } = null!;

    }
}
