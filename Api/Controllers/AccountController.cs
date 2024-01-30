using Application.Contracts.AccountAnswer;
using Application.WorkAccount.Commands.RegisterUser;
using Application.WorkAccount.Commands.SingUpUser;
using Application.WorkAccount.Queries.ConfirmAccount;
using Core.Account.enums;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
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
    
    /// <summary>
    /// Create user account
    /// </summary>
    /// <param name="request"></param>
    /// <param name="who"></param>
    /// <returns></returns>
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

    [HttpGet("verificateAccount/{token}/{role}/{id}")]
    public async Task<IActionResult> ConfirmAccount([FromRoute] string token, [FromRoute] string role,
        [FromRoute] Guid id)
    {
        var query = new ConfirmAccountQuery(token,role,id);

        var response = await _mediator.Send(query);

        return response.Match(
            accountResponse => Ok(accountResponse),
            errors => Problem(errors)
            );
    }
}