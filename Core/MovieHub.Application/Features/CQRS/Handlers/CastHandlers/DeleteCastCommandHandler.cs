using MediatR;
using MovieHub.Application.Features.CQRS.Commands.CastCommands;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.CastHandlers
{
    public class DeleteCastCommandHandler : IRequestHandler<DeleteCastCommand>
    {
        private readonly MovieContext _context;

        public DeleteCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(DeleteCastCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.Id);
            _context.Casts.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
