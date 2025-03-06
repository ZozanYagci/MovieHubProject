using MediatR;
using MovieHub.Application.Features.CQRS.Queries.MovieQueries;
using MovieHub.Application.Features.CQRS.Results.MovieResults;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler : IRequestHandler<GetMovieByIdQuery, GetMovieByIdQueryResult>
    {

        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var movie = await _context.Movies.FindAsync(request.Id);

            return new GetMovieByIdQueryResult
            {
                Id=movie.Id,
                CoverImageUrl = movie.CoverImageUrl,
                CreatedYear = movie.CreatedYear,
                Description = movie.Description,
                Duration = movie.Duration,
                Rating = movie.Rating,
                ReleaseDate = movie.ReleaseDate,
                Status = movie.Status,
                Title = movie.Title
            };
        }
    }
}
