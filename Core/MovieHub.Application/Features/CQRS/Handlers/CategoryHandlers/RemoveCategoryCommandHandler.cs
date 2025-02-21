using MediatR;
using MovieHub.Application.Features.CQRS.Commands.CategoryCommands;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand, Unit>
    {

        private readonly MovieContext _context;

        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Categories.FindAsync(request.Id);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
