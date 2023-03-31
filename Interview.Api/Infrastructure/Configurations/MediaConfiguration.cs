using Interview.Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Interview.Api.Infrastructure.Configurations
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.ReleaseDate)
                .HasColumnType("Date")
                .IsRequired();
                

            builder.HasData(
                new Media { Id = 1, Title = "Inception", ReleaseDate = DateTime.Parse("07/13/2010"), GenreId = 4, IsActive = true },
                new Media { Id = 2, Title = "2012", ReleaseDate = DateTime.Parse("11/13/2009"), GenreId = 4, IsActive = true },
                new Media { Id = 3, Title = "The Martian", ReleaseDate = DateTime.Parse("10/2/2015"), GenreId = 1, IsActive = true },
                new Media { Id = 4, Title = "Star Wars - A New Hope", ReleaseDate = DateTime.Parse("07/21/1978"), GenreId = 1, IsActive = true },
                new Media { Id = 5, Title = "Your Name", ReleaseDate = DateTime.Parse("04/7/2017"), GenreId = 2, IsActive = true },
                new Media { Id = 6, Title = "Weathering with You", ReleaseDate = DateTime.Parse("01/17/2020"), GenreId = 2, IsActive = true },
                new Media { Id = 7, Title = "Kung Fu Hustle", ReleaseDate = DateTime.Parse("04/22/2005"), GenreId = 3, IsActive = true },
                new Media { Id = 8, Title = "The Hangover", ReleaseDate = DateTime.Parse("6/2/2009"), GenreId = 3, IsActive = true },
                new Media { Id = 9, Title = "Scream", ReleaseDate = DateTime.Parse("12/20/1996"), GenreId = 5, IsActive = true },
                new Media { Id = 10, Title = "Saw", ReleaseDate = DateTime.Parse("10/29/2004"), GenreId = 5, IsActive = true },
                new Media { Id = 11, Title = "Titanic", ReleaseDate = DateTime.Parse("12/19/1997"), GenreId = 6, IsActive = true },
                new Media { Id = 12, Title = "The Notebook", ReleaseDate = DateTime.Parse("7/25/2004"), GenreId = 6, IsActive = true },
                new Media { Id = 13, Title = "The Shawshank Redemption", ReleaseDate = DateTime.Parse("10/14/1994"), GenreId = 7, IsActive = true },
                new Media { Id = 14, Title = "The Godfather", ReleaseDate = DateTime.Parse("03/24/1972"), GenreId = 7, IsActive = true },
                new Media { Id = 15, Title = "Gambit", ReleaseDate = DateTime.Parse("1/1/1970"), GenreId = 4, IsActive = false }

            );
        }
    }
}
