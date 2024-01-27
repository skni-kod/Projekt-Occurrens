using Application.Contracts.AccountAnswer;
using Application.WorkAccount.Commands.RegisterUser;
using Application.WorkAccount.Commands.SingUpUser;
using Core.Account.enums;
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

    [HttpPost("sing-up/{who}")]
    public async Task<IActionResult> SingUp([FromBody] SingUpUserRequest request, [FromRoute]UserRoles who)
    {
        var command = new SingUpUserCommand(
            request.Login,
            request.Password,
            who);

        var response = await _mediator.Send(command);

        return response.Match(
            accountResponse => Ok(accountResponse),
            errors => Problem(errors)
            );
    }
}