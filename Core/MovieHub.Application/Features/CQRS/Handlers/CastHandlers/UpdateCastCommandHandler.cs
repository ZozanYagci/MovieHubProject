using MediatR;
using MovieHub.Application.Features.CQRS.Commands.CastCommands;
using MovieHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Handlers.CastHandlers
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;

        public UpdateCastCommandHandler(MovieContext context)
        {
                _context = context;
        }
        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var cast = await _context.Casts.FindAsync(request.Id);
            cast.Name = request.Name;
            cast.Surname = request.Surname;
            cast.Overview = request.Overview;
            cast.Biography = request.Biography;
            cast.ImageUrl = request.ImageUrl;
            cast.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
