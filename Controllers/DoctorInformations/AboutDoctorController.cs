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
    [Route("doctor/{doctorId}/specialization")]
    [ApiController]
    [Authorize(Roles = "Doctor")]
    public class AboutDoctorController : ControllerBase
    {
        private readonly IAboutDoctorService _aboutDoctorService;

        public AboutDoctorController(IAboutDoctorService aboutDoctorService)
        {
            _aboutDoctorService = aboutDoctorService;
        }

        [HttpPost]
        public async Task<ActionResult> AddSpecialization([FromRoute]Guid doctorId, [FromBody]SpecializationDto dto)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null || !Guid.TryParse(userIdClaim.Value, out var userId) || userId != doctorId)
            {
                return BadRequest("Wystąpił nieoczekiwany błąd!");
            }

            var addSpecialization = _aboutDoctorService.AddSpecialization(doctorId, dto);

            return Created($"doctor/{doctorId}/specialization/{addSpecialization}",null);
        }
    }
}
