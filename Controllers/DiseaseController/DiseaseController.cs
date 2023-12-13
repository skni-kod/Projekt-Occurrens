using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using occurrensBackend.Models.DiseaseModels;
using occurrensBackend.Services.DiseaseDoctorService;

namespace occurrensBackend.Controllers.DiseaseController
{
    [Route("disease")]
    [ApiController]
    public class DiseaseController : ControllerBase
    {
        private readonly IDiseaseService _diseaseService;

        public DiseaseController(IDiseaseService diseaseService)
        {
            _diseaseService = diseaseService;
        }

        [HttpPost("add")]
        [Authorize(Roles = "Doctor")]
        public async Task<IActionResult> CreateDisease([FromBody] AddDiseaseModelDto dto)
        {
            var id =_diseaseService.CreateDisease(dto);

            return Created($"disease/add/{id}", null);
        }
    }
}