using Interview.Api.Features.MediaFeature.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Api.Features.MediaFeature.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediator mediator;

        public MediaController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            /*Todo: 04 - Take in the Title & Genre from query string. */
            return Ok(await mediator.Send(new MediaList.Request(), cancellationToken));
        }

        /*
        public IActionResult Add(CancellationToken cancellationToken)
        {
            //Get data from HTTP request
            mediator.Send(new MediaAdd.Request(), cancellationToken);
            return Ok();
        }
        */
    }
}
