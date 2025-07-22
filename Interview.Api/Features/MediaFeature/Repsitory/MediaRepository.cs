using Interview.Api.Features.MediaFeature.Interfaces;
using Interview.Api.Features.MediaFeature.Models;
using Interview.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Interview.Api.Features.MediaFeature.Repsitory
{
    public class MediaRepository : IMediaRepository
    {
        private readonly IApiContext db;

        //TODO: 02 - Dependency Inject the Db as IApiContext       
        public Task<IEnumerable<MediaDto>> List(CancellationToken cancellationToken)
        {
            //TODO: 03 - Create query to only return active media
            return Task.FromResult(Enumerable.Empty<MediaDto>());
        }
        //TODO: 05 - Modify List to use optional filters for Title and Genre Id


        //TODO: 06 - Create function to Add Media to the DB
    }
}