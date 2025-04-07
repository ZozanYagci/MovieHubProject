using MediatR;


namespace MovieHub.Application.Features.CQRS.Commands.TagCommands
{
    public class DeleteTagCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteTagCommand(int id)
        {
            Id = id;
        }
    }
}
