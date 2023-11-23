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
        public async Task<ActionResult> DoctorLogin([FromBody]LoginDoctorDto dto)
        {
            string token = _loginService.GenerateJwt(dto);

            return Ok(token);
        }
    }
}
