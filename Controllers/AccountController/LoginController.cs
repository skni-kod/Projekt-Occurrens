using Microsoft.AspNetCore.Mvc;
using occurrensBackend.Models.LoginModels;
using occurrensBackend.Services.AccountService;

namespace occurrensBackend.Controllers.AccountController
{
    [Route("login")]
    [ApiController]
    public class LoginController : ControllerBase      
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("doctor")]
        public async Task<ActionResult> DoctorLogin([FromBody]LoginDto dto)
        {
            string token = await _loginService.GenerateDoctorJwt(dto);

            return Ok(token);
        }


        [HttpPost("patient")]
        public async Task<ActionResult> PatientLogin([FromBody]LoginDto dto)
        {
            string token = await _loginService.GeneratePatientJwt(dto);

            return Ok(token);
        }
    }
}
