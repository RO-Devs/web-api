using DataLayer.Models.Authors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.ContextExtension.Authors
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(x => x.Names).IsRequired().HasMaxLength(100);
            builder.Property(x => x.LastNames).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Alias).HasMaxLength(100);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.HasMany(x => x.Books).WithOne(x => x.Author).HasForeignKey(x=> x.AuthorId);
        }
    }
}
