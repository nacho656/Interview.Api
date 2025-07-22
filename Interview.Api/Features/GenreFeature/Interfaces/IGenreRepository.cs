using Interview.Api.Features.GenreFeature.Models;

namespace Interview.Api.Features.GenreFeature.Interfaces
{
    public interface IGenreRepository
    {
        Task<IEnumerable<GenreDto>> List(CancellationToken cancellationToken);
    }
}
