using Application.Diseases.Commands.AddDisease;
using Core.Account.enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Disease;

[Route("diseases")]
[Authorize(Roles = nameof(UserRoles.Doctor))]
public class DiseasesController : ApiController
{
    private readonly IMediator _mediator;

    public DiseasesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Set new disease
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> SetDisease([FromBody] AddDiseaseCommand command)
    {
        var response = await _mediator.Send(command);

        return response.Match(
            diseaseResponse => Ok(diseaseResponse),
            errors => Problem(errors)
            );
    }
}