using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
   public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookGenre> BooksGenres { get; set; }

    }
}
