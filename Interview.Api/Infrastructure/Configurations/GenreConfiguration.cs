using Interview.Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Interview.Api.Infrastructure.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasData(                
                new Genre { Id = 1, Name = "Science Fiction" },
                new Genre { Id = 2, Name = "Animation" },
                new Genre { Id = 3, Name = "Comedy" },
                new Genre { Id = 4, Name = "Action" },
                new Genre { Id = 5, Name = "Horror" },
                new Genre { Id = 6, Name = "Romance" },                
                new Genre { Id = 7, Name = "Drama" }
            );
        }
    }
}
