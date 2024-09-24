using Application.Interfaces.Services;
using Application.Models.Errors;
using Application.Models.Request;
using Application.Models.Responses;
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
            if (cuentaService.Validate(request.Pin, cuenta))
            {
                return NotFound(ErrorMessage.GetErrorMessage($"No se encontro la tarjeta {request.NumeroDeTarjeta}."));
            }
            if(cuenta.CantidadDeIntentos != 0)
            {
                return BadRequest(ErrorMessage.PIN_INVALIDO);
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
