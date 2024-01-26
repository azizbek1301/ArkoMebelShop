using Authorisation.API.Interfaces;
using Authorisation.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> LoginAsync(Login login)
        {
            string token = await _authService.GenerateToken(login);

            return Ok(token);
        }
    }
}
