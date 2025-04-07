using MediatR;
using MovieHub.Application.Features.CQRS.Commands.TagCommands;
using MovieHub.Persistence.Context;


namespace MovieHub.Application.Features.CQRS.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly MovieContext context;

        public CreateTagCommandHandler(MovieContext context)
        {
            this.context = context;
        }
        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            context.Tags.Add(new Domain.Entities.Tag
            {
                Title = request.Title,
            });
            await context.SaveChangesAsync();
        }
    }
}
