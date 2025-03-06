using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieHub.Application.Features.CQRS.Commands.CategoryCommands;
using MovieHub.Application.Features.CQRS.Queries.CategoryQueries;

namespace MovieHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var query = new GetAllCategoriesQuery();
            var categories= await _mediator.Send(query);
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kategori başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kategori başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _mediator.Send(new DeleteCategoryCommand(id));
            return Ok("Kategori başarıyla silindi.");
        }

        [HttpGet("GetCategory")]

        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _mediator.Send(new GetCategoryByIdQuery(id));
            if(category == null)
            
                return NotFound("Kategori bulunamadı");

            return Ok(category);
            
        }

    }
}
