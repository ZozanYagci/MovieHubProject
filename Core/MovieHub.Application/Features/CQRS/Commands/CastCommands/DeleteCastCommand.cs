using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Commands.CastCommands
{
    public class DeleteCastCommand: IRequest
    {
        public int Id { get; set; }

        public DeleteCastCommand(int id)
        {
                Id = id;
        }

    }
}
