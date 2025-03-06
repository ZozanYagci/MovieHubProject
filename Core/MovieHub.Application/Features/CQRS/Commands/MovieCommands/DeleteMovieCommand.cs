using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Commands.MovieCommands
{
    public class DeleteMovieCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteMovieCommand(int id)
        {
                Id = id;
        }
    }
}
