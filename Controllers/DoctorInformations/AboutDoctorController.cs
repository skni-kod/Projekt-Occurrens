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
    [Route("doctor")]
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
        public async Task<ActionResult> AddSpecialization([FromBody]SpecializationDto dto)
        {
            var addSpecialization = _aboutDoctorService.AddSpecialization(dto);

            return Created($"doctor/specialization/{addSpecialization}",null);
        }


        [HttpPost("address")]
        public async Task<IActionResult> AddAddress([FromBody]AddressDto dto)
        {
            var addAddress = _aboutDoctorService.AddAddress(dto);

            return Created($"doctor/address/{addAddress}", null);
        }

        [HttpPost("is_opened")]
        public async Task<IActionResult> AddIsOpened([FromBody]Is_openedDto dto)
        {
            var addOpened = _aboutDoctorService.AddIsOpened(dto);

            return Created($"doctor/is_opened/{addOpened}", null);
        }
       
    }
}
