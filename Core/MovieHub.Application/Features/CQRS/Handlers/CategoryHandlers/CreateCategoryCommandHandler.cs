using MediatR;
using MovieHub.Application.Features.CQRS.Commands.CategoryCommands;
using MovieHub.Domain.Entities;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Unit>
    {

        // TODO: daha sonra repository yazılacak.
        private readonly MovieContext _context;
        public CreateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category
            {
                CategoryName = request.CategoryName
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
