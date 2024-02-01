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

    [HttpPost("SetSpecialization")]
    public async Task<IActionResult> SetSpecialization()
    {
        
    }
}