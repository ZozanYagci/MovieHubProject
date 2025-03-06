using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Commands.CategoryCommands
{
    public class DeleteCategoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }


        // zorunlu alanlar burada set edilebilir.
        public DeleteCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
