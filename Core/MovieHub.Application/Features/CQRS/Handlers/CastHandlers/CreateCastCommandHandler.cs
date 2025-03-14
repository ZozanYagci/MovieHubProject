using MediatR;
using MovieHub.Application.Features.CQRS.Commands.CastCommands;
using MovieHub.Domain.Entities;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.CastHandlers
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _context;

        public CreateCastCommandHandler(MovieContext context)
        {
                _context = context;
        }
        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            _context.Casts.Add(new Cast
            {
                Biography = request.Biography,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Surname = request.Surname,
                Overview = request.Overview,
                Title = request.Title,
            });
            await _context.SaveChangesAsync();
        }
    }
}
