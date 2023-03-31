using AutoMapper;
using AutoMapper.QueryableExtensions;
using Interview.Api.Features.GenreFeature.Models;
using Interview.Api.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Interview.Api.Features.GenreFeature.Requests
{
    public class GenreList
    {
        public class Request : IRequest<IEnumerable<GenreDto>>
        {

        }

        public class RequestHandler : IRequestHandler<Request, IEnumerable<GenreDto>>
        {
            private readonly IApiContext db;
            private readonly IMapper mapper;

            public RequestHandler(IApiContext db, IMapper mapper) 
            { 
                this.db = db;
                this.mapper = mapper;
            }

            public async Task<IEnumerable<GenreDto>> Handle(Request request, CancellationToken cancellationToken)
            {
                //Todo: Alphabetize return Genres
                return await db.Genres.AsNoTracking()
                    .ProjectTo<GenreDto>(mapper.ConfigurationProvider)
                    .ToListAsync();
            }
        }
    }
}
