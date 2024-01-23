using Application.WorkAccount.Commands.RegisterUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("account")]
public class AccountController : ApiController
{
    private readonly IMediator _mediator;

    public AccountController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Create user 
    /// </summary>
    [HttpPost("user-register")]
    public async Task<IActionResult> CreateAccount([FromBody] CreateUserCommand command,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(command);

        return response.Match(
            accountResponse => Ok(accountResponse),
            errors => Problem(errors)
            );
    }
}