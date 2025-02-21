using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieHub.Application.Features.CQRS.Queries.CategoryQueries;
using MovieHub.Application.Features.CQRS.Results.CategoryResults;
using MovieHub.Domain.Entities;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MovieHub.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<GetCategoryQueryResult>>
    {

        private readonly MovieContext _context;

        public GetCategoryQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetCategoryQueryResult>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {

            // TODO: Automapper
            return await _context.Categories
                 .Select(c => new GetCategoryQueryResult
                 {
                     Id = c.Id,
                     CategoryName = c.CategoryName,
                 }).ToListAsync(cancellationToken);

        }
    }
}
