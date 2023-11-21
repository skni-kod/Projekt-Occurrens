using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using occurrensBackend.Models.RegisterModels;
using occurrensBackend.Services.AccountService;

namespace occurrensBackend.Controllers.AccountController
{
    [Route("register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        public RegisterController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost("doctor")]
        public async Task<ActionResult> RegisterDoctor([FromBody]RegisterDoctorDto dto)
        {
            await _registerService.RegisterDoctor(dto);
            return Ok();
        }
    }
}
