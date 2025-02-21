using MediatR;
using MovieHub.Application.Features.CQRS.Queries.CategoryQueries;
using MovieHub.Application.Features.CQRS.Results.CategoryResults;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {

        private readonly MovieContext _context;

        public GetCategoryByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            return new GetCategoryByIdQueryResult
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
        }
    }
}
