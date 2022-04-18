using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
   public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AuthorBook> AuthorSBooks { get; set; }

    }
}
