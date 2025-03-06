using MediatR;
using MovieHub.Application.Features.CQRS.Results.MovieResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Queries.MovieQueries
{
    public class GetMovieByIdQuery : IRequest<GetMovieByIdQueryResult>
    {
        public int Id { get; set; }

        public GetMovieByIdQuery(int id)
        {
            Id = id;
        }
    }
}
