using MediatR;
using MovieHub.Application.Features.CQRS.Commands.MovieCommands;
using MovieHub.Domain.Entities;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, Unit>
    {

        private readonly MovieContext _context;

        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            _context.Movies.Add(new Movie
            {
                Title = request.Title,
                CoverImageUrl = request.CoverImageUrl,
                Rating = request.Rating,
                Description = request.Description,
                Duration = request.Duration,
                ReleaseDate = request.ReleaseDate,
                CreatedYear = request.CreatedYear,
                Status = request.Status
            });

            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
