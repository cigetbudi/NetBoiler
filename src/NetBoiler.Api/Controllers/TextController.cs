using MediatR;
using Microsoft.AspNetCore.Mvc;
using NetBoiler.Application.Commands.FetchAndSaveText;

namespace MyApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TextController : ControllerBase
{
    private readonly IMediator _mediator;

    public TextController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("fetch")]
    public async Task<IActionResult> FetchAndSaveText()
    {
        await _mediator.Send(new FetchAndSaveTextCommand());
        return Ok(new { message = "Text fetched and saved." });
    }
}
