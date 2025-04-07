using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieHub.Application.Features.CQRS.Queries.GetQueries;
using MovieHub.Application.Features.CQRS.Results.TagResults;
using MovieHub.Persistence.Context;


namespace MovieHub.Application.Features.CQRS.Handlers.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly MovieContext context;

        public GetTagQueryHandler(MovieContext context)
        {
            this.context = context;
        }
        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Tags.ToListAsync();
            return values.Select(x => new GetTagQueryResult
            {
                Id = x.Id,
                Title = x.Title
            }).ToList();
        }
    }
}
