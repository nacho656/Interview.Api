using Interview.Api.Features.GenreFeature.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Api.Features.GenreFeature.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository repo;

        public GenreController(IGenreRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            return Ok(await repo.List(cancellationToken));
        }        
    }
}
