using Application.Contracts.DoctorInformationsAnswers.Office;
using Application.Contracts.DoctorInformationsAnswers.Specialization;
using Application.DoctorInformations.Commands.EditOfficeInfo;
using Application.DoctorInformations.Commands.EditSpecialization;
using Application.DoctorInformations.Commands.SetAddress;
using Application.DoctorInformations.Commands.SetOpenedData;
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

    /// <summary>
    /// Set doctor's office address
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    [HttpPost("SetAddress")]
    public async Task<IActionResult> SetAddress([FromBody] SetAddressCommand command)
    {
        var response = await _mediator.Send(command);

        return response.Match(
            infoResponse => Ok(infoResponse),
            errors => Problem(errors)
            );
    }

    /// <summary>
    /// Set date-opened office
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    [HttpPost("Set-opened-info")]
    public async Task<IActionResult> SetOpenedInfo([FromBody] SetOpenedDataCommand command)
    {
        var response = await _mediator.Send(command);

        return response.Match(
            infoResponse => Ok(infoResponse),
            errors => Problem(errors)
            );
    }

    /// <summary>
    /// Update doctor specialization
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut("Edit-specialization/{id}")]
    public async Task<IActionResult> EditSpecialization([FromRoute] Guid id, [FromBody] UpdateSpecializationRequest request)
    {
        var command = new EditSpecializationCommand(id, request.specialization);

        var response = await _mediator.Send(command);

        return response.Match(
            infoResponse => Ok(infoResponse),
            errors => Problem(errors)
            );
    }

    /// <summary>
    /// Update doctor office info
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut("Edit-doctor-office-info/{id}")]
    public async Task<IActionResult> EditDoctorOfficeInfo([FromRoute] Guid id, [FromBody] UpdateOfficeInfoRequest request)
    {
        var command = new EditOfficeInfoCommand(
            request.Street,
            request.BuildingNumber,
            request.ApartamentNumber,
            request.PostalCode,
            request.City,
            request.Monday,
            request.Tuesday,
            request.Wednesday,
            request.Thursday,
            request.Fridady,
            request.Saturday,
            request.Sunday,
            id);

        var response = await _mediator.Send(command);
        
        return response.Match(
            infoResponse => Ok(infoResponse),
            errors => Problem(errors)
            );
    }
}