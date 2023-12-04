using Microsoft.AspNetCore.Mvc;
using occurrensBackend.Entities;
using occurrensBackend.Models.GetDoctorInformationsModels;
using occurrensBackend.Services.ShowAllDoctorsService;

namespace occurrensBackend.Controllers.ShowAllDoctorsController
{
    [Route("doctors")]
    [ApiController]
    public class ShowAllDoctorsController : ControllerBase
    {
        private readonly IShowAllDoctorsService _showAllDoctors;

        public ShowAllDoctorsController(IShowAllDoctorsService showAllDoctors)
        {
            _showAllDoctors = showAllDoctors;
        }


        [HttpGet]
        public ActionResult<IEnumerable<GetDoctorInformationsModelsDto>> GetAllDoctors([FromQuery]DoctorQuery query)
        {
            var doctors = _showAllDoctors.GetAllDoctors(query);

            return Ok(doctors);
        }
    }
}
