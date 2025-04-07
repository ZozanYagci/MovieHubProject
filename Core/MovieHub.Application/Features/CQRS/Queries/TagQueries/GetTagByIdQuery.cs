using MediatR;
using MovieHub.Application.Features.CQRS.Results.TagResults;


namespace MovieHub.Application.Features.CQRS.Queries.GetQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int Id { get; set; }
        public GetTagByIdQuery(int id)
        {
            Id = id;
        }
    }
}
