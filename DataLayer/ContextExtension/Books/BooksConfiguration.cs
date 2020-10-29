using DataLayer.Models.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.ContextExtension.Books
{
    public class BooksConfiguration: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Editorial).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.PublishDate).IsRequired();
            builder.HasOne(x => x.Author).WithMany(x => x.Books).HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Genre).WithMany(x => x.Book).HasForeignKey(x => x.GenreId);
        }
    }
}
