using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
