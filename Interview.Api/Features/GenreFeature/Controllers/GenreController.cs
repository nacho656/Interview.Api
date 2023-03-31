using Interview.Api.Features.GenreFeature.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Api.Features.GenreFeature.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IMediator mediator;

        public GenreController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            return Ok(await mediator.Send(new GenreList.Request(), cancellationToken));
        }
        
    }
}
