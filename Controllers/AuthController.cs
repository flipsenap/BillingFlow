using Microsoft.AspNetCore.Mvc;
using BillingFlowApi.Models;
using BillingFlowApi.Services;

namespace BillingFlowApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _service;

        public AuthController(AuthService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public IActionResult Login(Usuario usuario)
        {
            var token = _service.Login(usuario.Email, usuario.Senha);

            if (token == null)
                return Unauthorized("Credenciais inválidas");

            return Ok(new { token });
        }
    }
}