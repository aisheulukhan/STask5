using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
   public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int StokCount { get; set; }
        public double Price { get; set; }
        public int PublishingId { get; set; }
        public List<BookGenre> BooksGenres { get; set; }
        public List<AuthorBook> AuthorSBooks { get; set; }

    }
}
