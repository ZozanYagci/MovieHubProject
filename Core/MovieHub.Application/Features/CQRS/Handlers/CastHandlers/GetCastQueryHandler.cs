using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieHub.Application.Features.CQRS.Queries.CastQueries;
using MovieHub.Application.Features.CQRS.Results.CastResults;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.CastHandlers
{
    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieContext _context;

        public GetCastQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                ImageUrl = x.ImageUrl,
                Overview = x.Overview,
                Biography = x.Biography,
                Title = x.Title,
            }).ToList();
        }
    }
}
