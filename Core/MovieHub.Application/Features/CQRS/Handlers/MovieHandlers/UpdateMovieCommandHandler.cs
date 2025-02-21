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
    public class UpdateMovieCommandHandler : IRequestHandler<UpdateMovieCommand, Unit>
    {

        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Movies.FindAsync(request.Id);

            value.Rating = request.Rating;
            value.Title = request.Title;
            value.Description = request.Description;
            value.Status = request.Status;
            value.Duration = request.Duration;
            value.CoverImageUrl = request.CoverImageUrl;
            value.ReleaseDate = request.ReleaseDate;
            value.CreatedYear = request.CreatedYear;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
