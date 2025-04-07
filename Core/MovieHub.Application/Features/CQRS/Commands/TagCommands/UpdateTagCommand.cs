using MediatR;


namespace MovieHub.Application.Features.CQRS.Commands.TagCommands
{
    public class UpdateTagCommand : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
