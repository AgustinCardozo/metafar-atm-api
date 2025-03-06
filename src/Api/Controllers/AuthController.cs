using Application.Interfaces.Services;
using Application.ViewModels.Errors;
using Application.ViewModels.Request;
using Application.ViewModels.Responses;
using Common.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController(ICuentaService cuentaService, IJwtTokenService tokenService) : ControllerBase
    {
        [HttpPost("")]
        public IActionResult Login(CuentaRequest request)
        {
            Cuenta cuenta = cuentaService.GetByTarjeta(request.NumeroDeTarjeta);
            if (cuentaService.IsBlocked(request.Pin, cuenta))
            {
                return NotFound(ErrorMessage.Validations.CUENTA_BLOQUEADA);
            }
            if (!cuentaService.IsActive(cuenta))
            {
                return Problem(ErrorMessage.Validations.CUENTA_INACTIVA);
            }
            if(cuenta.CantidadDeIntentos != 0)
            {
                return BadRequest(ErrorMessage.Validations.PIN_INVALIDO);
            }
            var response = new CuentaResponse()
            {
                NombreDeUsuario = cuenta.Usuario.NombreDeUsuario,
                Token = tokenService.Authenticate(request.NumeroDeTarjeta)
            };
            return Ok(response);
        }
    }
}
