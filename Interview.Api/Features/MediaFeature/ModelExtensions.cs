using Interview.Api.Features.MediaFeature.Models;

namespace Interview.Api.Features.MediaFeature
{
    public static class ModelExtensions
    {
        public static MediaDto ToDto(this Domain.Media media)
        {
            return new MediaDto
            {
                Id = media.Id,
                Genre = media.Genre.Name,
                GenreId = media.Genre.Id,
                ReleaseDate = media.ReleaseDate,
                Title = media.Title,
                IsActive = media.IsActive,
            };
        }
    }
}
