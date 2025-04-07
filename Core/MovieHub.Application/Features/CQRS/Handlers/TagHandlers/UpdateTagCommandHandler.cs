using MediatR;
using MovieHub.Application.Features.CQRS.Commands.TagCommands;
using MovieHub.Persistence.Context;


namespace MovieHub.Application.Features.CQRS.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {

        private readonly MovieContext context;

        public UpdateTagCommandHandler(MovieContext context)
        {
            this.context = context;
        }
        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var values = await context.Tags.FindAsync(request.Id);
            values.Title = request.Title;
            await context.SaveChangesAsync();
        }
    }
}
