using Interview.Api.Features.MediaFeature.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Api.Features.MediaFeature.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediaRepository repo;

        public MediaController(IMediaRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            //TODO: 04 - Take in the Title & Genre from query string
            return Ok(await repo.List(cancellationToken));
        }

        /*
        public IActionResult Add(CancellationToken cancellationToken)
        {
            //Get data from HTTP request
            //Send Data to Repository
            return Ok();
        }
        */
    }
}
