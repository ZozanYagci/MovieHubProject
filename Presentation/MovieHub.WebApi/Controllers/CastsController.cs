using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieHub.Application.Features.CQRS.Commands.CastCommands;
using MovieHub.Application.Features.CQRS.Queries.CastQueries;

namespace MovieHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator mediator;

        public CastsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CastList()
        {
            var casts = await mediator.Send(new GetCastQuery());
            return Ok(casts);
        }

        [HttpPost]

        public async Task<IActionResult> CreateCast(CreateCastCommand command)
        {
            await mediator.Send(command);
            return Ok("Ekleme işlemi başarılı");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteCast(int id)
        {
            await mediator.Send(new DeleteCastCommand(id));
            return Ok("Silme işlemi başarılı");
        }

        [HttpGet("GetCastById")]

        public async Task<IActionResult> GetCastById(int id)
        {
            var value = await mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
        {
            await mediator.Send(command);
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
