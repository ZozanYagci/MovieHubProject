using MediatR;


namespace MovieHub.Application.Features.CQRS.Commands.TagCommands
{
    public class CreateTagCommand : IRequest
    {
        public string Title { get; set; }
    }
}
