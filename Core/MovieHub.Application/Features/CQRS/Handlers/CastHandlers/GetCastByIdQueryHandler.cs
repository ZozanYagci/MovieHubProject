using MediatR;
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
    public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {

        private readonly MovieContext _context;

        public GetCastByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
            var cast = await _context.Casts.FindAsync(request.Id);
            return new GetCastByIdQueryResult
            {
                Id = cast.Id,
                Name = cast.Name,
                Surname = cast.Surname,
                ImageUrl = cast.ImageUrl,
                Overview = cast.Overview,
                Biography = cast.Biography,
                Title = cast.Title
            };
        }
    }
}
