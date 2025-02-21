using MediatR;
using MovieHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
