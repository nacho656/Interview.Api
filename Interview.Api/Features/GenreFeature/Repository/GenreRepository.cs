using Interview.Api.Features.GenreFeature.Interfaces;
using Interview.Api.Features.GenreFeature.Models;
using Interview.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Interview.Api.Features.GenreFeature.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IApiContext db;

        public GenreRepository(IApiContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<GenreDto>> List(CancellationToken cancellationToken)
        {
            //TODO: 01 - Alphabetize return Genres
            return await db.Genres.AsNoTracking()
                .Select(x => x.ToDto())
                .ToListAsync(cancellationToken);
        }
    }
}
