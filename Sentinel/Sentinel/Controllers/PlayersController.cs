using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sentinel.Core.Domain;
using Sentinel.Core.Features.GetPlayers;

namespace Sentinel.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayersController : ControllerBase
{
    private readonly IMediator mediator;


    public PlayersController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IEnumerable<Player>> GetPlayers(CancellationToken cancellation)
    {
        var response = await mediator.Send(new GetPlayers.Request(),cancellation);
        return response.Players;
    }
}