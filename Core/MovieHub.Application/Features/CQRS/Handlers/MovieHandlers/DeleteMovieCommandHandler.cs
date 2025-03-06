using MediatR;
using MovieHub.Application.Features.CQRS.Commands.MovieCommands;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class DeleteMovieCommandHandler : IRequestHandler<DeleteMovieCommand, Unit>
    {

        private readonly MovieContext _context;

        public DeleteMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Movies.FindAsync(request.Id);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
