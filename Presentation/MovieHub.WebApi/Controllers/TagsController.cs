using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieHub.Application.Features.CQRS.Commands.TagCommands;
using MovieHub.Application.Features.CQRS.Queries.GetQueries;

namespace MovieHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator mediator;

        public TagsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var values = await mediator.Send(new GetTagQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await mediator.Send(command);
            return Ok("Ekleme işlemi başarılı");
        }

        [HttpGet("GetTag")]
        public async Task<IActionResult> GetTag(int id)
        {
            var value = await mediator.Send(new GetTagByIdQuery(id));
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTag(int id)
        {
            await mediator.Send(new DeleteTagCommand(id));
            return Ok("Silme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await mediator.Send(command);
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
