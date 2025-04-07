using MediatR;
using MovieHub.Application.Features.CQRS.Queries.GetQueries;
using MovieHub.Application.Features.CQRS.Results.TagResults;
using MovieHub.Persistence.Context;


namespace MovieHub.Application.Features.CQRS.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly MovieContext context;

        public GetTagByIdQueryHandler(MovieContext context)
        {
            this.context = context;
        }
        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await context.Tags.FindAsync(request.Id);
            return new GetTagByIdQueryResult
            {
                Title = values.Title
            };
        }
    }
}
