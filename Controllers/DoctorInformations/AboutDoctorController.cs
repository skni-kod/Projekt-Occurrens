using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Exceptions;
using occurrensBackend.Models.AboutDoctorModels;
using occurrensBackend.Services.DoctorInformationsService;
using System.Security.Claims;

namespace occurrensBackend.Controllers.DoctorInformations
{
    [Route("doctor/{doctorId}")]
    [ApiController]
    [Authorize(Roles = "Doctor")]
    public class AboutDoctorController : ControllerBase
    {
        private readonly IAboutDoctorService _aboutDoctorService;

        public AboutDoctorController(IAboutDoctorService aboutDoctorService)
        {
            _aboutDoctorService = aboutDoctorService;
        }

        [HttpPost("specialization")]
        public async Task<ActionResult> AddSpecialization([FromRoute]Guid doctorId, [FromBody]SpecializationDto dto)
        {
            var userIdClaim = CheckTrue(doctorId);
            if (!userIdClaim)
            {
                return BadRequest("Wystąpił nieoczekiwany błąd!");
            }

            var addSpecialization = _aboutDoctorService.AddSpecialization(doctorId, dto);

            return Created($"doctor/{doctorId}/specialization/{addSpecialization}",null);
        }


        [HttpPost("address")]
        public async Task<IActionResult> AddAddress([FromRoute]Guid doctorId, [FromBody]AddressDto dto)
        {
            var userIdClaim = CheckTrue(doctorId);
            if(!userIdClaim)
            {
                return BadRequest("Wystąpił nieoczekiwany błąd");
            }

            var addAddress = _aboutDoctorService.AddAddress(doctorId, dto);

            return Created($"doctor/{doctorId}/address/{addAddress}", null);
        }

        [HttpPost("is_opened/{addressId}")]
        public async Task<IActionResult> AddIsOpened([FromRoute]Guid doctorId, [FromBody]Is_openedDto dto, [FromRoute]Guid addressId)
        {
            var userIdClaim = CheckTrue(doctorId);
            if (!userIdClaim)
            {
                return BadRequest("Wystąpił nieoczekiwany błąd");
            }

            var addOpened = _aboutDoctorService.AddIsOpened(doctorId, dto, addressId);

            return Created($"doctor/{doctorId}/is_opened/{addOpened}", null);
        }
       

        private bool CheckTrue(Guid doctorId)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null || !Guid.TryParse(userIdClaim.Value, out var userId) || userId != doctorId)
            {
                return false;
            }
            return true;
        }
    }
}
