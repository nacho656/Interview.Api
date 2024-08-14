using MediatR;

namespace Interview.Api.Features.MediaFeature.Requests
{
    public class MediaAdd
    {
        public class Request : IRequest<Unit>
        {            
        }

        public class RequestHandler : IRequestHandler<Request, Unit>
        {
            //Todo: 05 - Dependency Inject DB via IApiContext

            public Task<Unit> Handle(Request request, CancellationToken cancellationToken)
            {
                //Todo: 06 - Add Media to Db
                return Task.FromResult(Unit.Value);
            }
        }
    }
}
