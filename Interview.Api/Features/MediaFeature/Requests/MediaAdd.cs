using MediatR;

namespace Interview.Api.Features.MediaFeature.Requests
{
    public class MediaAdd
    {
        public class Request : IRequest<Unit>
        {
            /*Todo: Add properties here for adding Media*/
        }

        public class RequestHandler : IRequestHandler<Request, Unit>
        {
            //Todo: Dependency Inject DB via IApiContext

            public Task<Unit> Handle(Request request, CancellationToken cancellationToken)
            {
                //Todo: Add Media to Db
                return Task.FromResult(Unit.Value);
            }
        }
    }
}
