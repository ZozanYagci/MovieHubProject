using MediatR;
using MovieHub.Application.Features.CQRS.Commands.CategoryCommands;
using MovieHub.Application.Features.CQRS.Commands.MovieCommands;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Unit>
    {

        private readonly MovieContext _context;

        public UpdateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Categories.FindAsync(request.Id);
            value.CategoryName = request.CategoryName;
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
