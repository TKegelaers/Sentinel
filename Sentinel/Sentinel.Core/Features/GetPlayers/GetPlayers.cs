using MediatR;
using Sentinel.Core.Domain;

namespace Sentinel.Core.Features.GetPlayers;

public class GetPlayers
{
    public class Request : IRequest<Response>
    {

    }

    public class Response
    {
        public IEnumerable<Player> Players { get; }

        public Response(IEnumerable<Player> players)
        {
            Players = players;
        }
    }

    public class Handler : IRequestHandler<Request, Response>
    {
        public  Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            var players = new List<Player>()
            {
                new Player("Thomas", "M"),
                new Player("Kim", "V"),
            };

            return Task.FromResult(new Response(players));
        }
    }
}