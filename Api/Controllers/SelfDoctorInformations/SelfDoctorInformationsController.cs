using Application.DoctorInformations.Commands.SetSpecialization;
using Core.Account.enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.SelfDoctorInformations;

[ApiController]
[Authorize(Roles = nameof(UserRoles.Doctor))]
[Route("DoctorHimselfInformations")]
public class SelfDoctorInformationsController : ApiController
{
    private readonly IMediator _mediator;

    public SelfDoctorInformationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Set specialization
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    [HttpPost("SetSpecialization")]
    public async Task<IActionResult> SetSpecialization([FromBody] SetSpecializationCommand command)
    {
        var response = await _mediator.Send(command);

        return response.Match(
            infoResponse => Ok(infoResponse),
            errors => Problem(errors) 
            );
    }
}