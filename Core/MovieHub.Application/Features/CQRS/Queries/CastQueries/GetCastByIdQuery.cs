using MediatR;
using MovieHub.Application.Features.CQRS.Results.CastResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Queries.CastQueries
{
    public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCastByIdQuery(int id)
        {
            Id = id;
        }
    }
}
