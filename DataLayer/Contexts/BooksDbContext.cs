using DataLayer.ContextExtension.Authors;
using DataLayer.ContextExtension.Books;
using DataLayer.ContextExtension.Genres;
using DataLayer.Models.Authors;
using DataLayer.Models.Books;
using DataLayer.Models.Genres;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contexts
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BooksConfiguration());
            modelBuilder.ApplyConfiguration(new GenresConfiguration());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
