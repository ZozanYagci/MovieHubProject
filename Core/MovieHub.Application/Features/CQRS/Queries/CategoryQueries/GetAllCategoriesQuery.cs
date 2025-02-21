using MediatR;
using MovieHub.Application.Features.CQRS.Results.CategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetAllCategoriesQuery : IRequest<List<GetCategoryQueryResult>>
    {
    }
}
