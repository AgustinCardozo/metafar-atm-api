using Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/operaciones")]
    public class OperacionController(IOperacionService operacionService) : ControllerBase
    {
        [HttpGet]
        [Route("{numeroDeTarjeta}")]
        public IActionResult GetOperaciones(string numeroDeTarjeta)
        {
            var operaciones = operacionService.GetTop10(numeroDeTarjeta);
            if (operaciones is null)
            {
                return NotFound($"No se encontro la tarjeta {numeroDeTarjeta}.");
            }
            return Ok(operaciones);
        }
    }
}
