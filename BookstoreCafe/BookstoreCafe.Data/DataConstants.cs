using BookstoreCafe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Data
{
    public class DataConstants
    {
        public class Book
        {
            public const int TitleMaxLength = 200;
            public const int TitleMinLength = 3;

            public const int AuthorMaxLength = 100;
            public const int AuthorMinLength = 3;

            public const int DescriptionMaxLength = 2500;
            public const int DescriptionMinLength = 3;

            public const int YearOfReleaseMaxRange = 9999;
            public const int YearOfReleaseMinRange = 1000;

            public const int NumberOfPagesMaxRange = 2500;
            public const int NumberOfPagesMinRange = 50;

        }

        public class Genre
        {
            public const int NameMaxLength = 75;
            public const int NameMinLength = 5;
        }

        public class Category
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 3;
        }

        public class MenuItem
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;

            public const int IngredientsMaxLength = 1000;
            public const int IngredientsMinLength = 4;



        }


    }
}
