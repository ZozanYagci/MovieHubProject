using MediatR;
using MovieHub.Application.Features.CQRS.Results.TagResults;


namespace MovieHub.Application.Features.CQRS.Queries.GetQueries
{
    public class GetTagQuery : IRequest<List<GetTagQueryResult>>
    {
    }
}
