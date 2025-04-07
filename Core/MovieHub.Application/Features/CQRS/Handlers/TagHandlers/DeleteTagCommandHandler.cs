using MediatR;
using MovieHub.Application.Features.CQRS.Commands.TagCommands;
using MovieHub.Persistence.Context;


namespace MovieHub.Application.Features.CQRS.Handlers.TagHandlers
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommand>
    {
        private readonly MovieContext context;
        public DeleteTagCommandHandler(MovieContext context)
        {
            this.context = context;
        }
        public async Task Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            var values = await context.Tags.FindAsync(request.Id);
            context.Tags.Remove(values);
            await context.SaveChangesAsync();
        }
    }
}
