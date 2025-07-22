using Interview.Api.Features.MediaFeature.Models;

namespace Interview.Api.Features.MediaFeature.Interfaces
{
    public interface IMediaRepository
    {
        Task<IEnumerable<MediaDto>> List(CancellationToken cancellationToken);
    }
}
