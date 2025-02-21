using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieHub.Application.Features.CQRS.Queries.CategoryQueries;
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
    public class GetMovieQueryHandler : IRequestHandler<GetAllMoviesQuery, List<GetMovieQueryResult>>
    {

        private readonly MovieContext _context;

        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResult>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Movies
                .Select(m => new GetMovieQueryResult
                {
                    Id = m.Id,
                    CoverImageUrl = m.CoverImageUrl,
                    CreatedYear = m.CreatedYear,
                    Description = m.Description,
                    Duration = m.Duration,
                    Rating = m.Rating,
                    ReleaseDate = m.ReleaseDate,
                    Status = m.Status,
                    Title = m.Title,

                }).ToListAsync(cancellationToken);
        }
    }
}
