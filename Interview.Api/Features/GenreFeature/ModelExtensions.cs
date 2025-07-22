using Interview.Api.Features.GenreFeature.Models;

namespace Interview.Api.Features.GenreFeature
{
    public static class ModelExtensions
    {
        public static GenreDto ToDto(this Domain.Genre genre)
        {
            return new GenreDto
            {
                Id = genre.Id,
                Name = genre.Name,
            };
        }
    }
}
