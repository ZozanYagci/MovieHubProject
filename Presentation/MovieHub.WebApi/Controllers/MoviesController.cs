using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieHub.Application.Features.CQRS.Commands.MovieCommands;
using MovieHub.Application.Features.CQRS.Queries.MovieQueries;

namespace MovieHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
                _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> MovieList()
        {
            var query = new GetAllMoviesQuery();
            var movies = await _mediator.Send(query);
            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] CreateMovieCommand command)
        {
            await _mediator.Send(command);
            return Ok("Film ekleme işlemi başarılı.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMovie([FromBody] UpdateMovieCommand command)
        {
            await _mediator.Send(command);
            return Ok("Film güncelleme işlemi başarılı.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _mediator.Send(new DeleteMovieCommand(id));
            return Ok("Film silme işlemi başarılı.");
        }

        [HttpGet("GetMovie")]

        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _mediator.Send(new GetMovieByIdQuery(id));
            if (movie == null)

                return NotFound("Film bulunamadı");

            return Ok(movie);

        }

    }
}
