using BookTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.DAL
{
    class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=213-17;Database=BookSales;Trusted_Connection=True;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publishing> Publishings { get; set; }
        public DbSet <Author> Authors { get; set; }
        public DbSet <Genre> Genres { get; set; }
        public DbSet <BookGenre> BooksGenres { get; set; }
        public DbSet <AuthorBook> AuthorsBooks { get; set; }
    }
}
