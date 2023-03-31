using AutoMapper;
using AutoMapper.QueryableExtensions;
using Interview.Api.Features.MediaFeature.Models;
using Interview.Api.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Interview.Api.Features.MediaFeature.Requests
{
    public class MediaList
    {
        public class Request : IRequest<IEnumerable<MediaDto>>
        {

        }

        public class RequestHandler : IRequestHandler<Request, IEnumerable<MediaDto>>
        {
            private readonly IApiContext db;
            private readonly IMapper mapper;

            public RequestHandler(IApiContext db, IMapper mapper)
            {
                this.db = db;
                this.mapper = mapper;
            }

            public async Task<IEnumerable<MediaDto>> Handle(Request request, CancellationToken cancellationToken)
            {
                //Todo: Update to only Show Active Movies
                //Todo: Allow Searching by Title and Genre Id               
                return await db.Media.AsNoTracking()
                    .ProjectTo<MediaDto>(mapper.ConfigurationProvider)
                    .ToListAsync();
            }
        }
    }
}
