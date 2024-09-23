using Application.Interfaces.Services;
using Application.Models.Requests;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/cuenta")]
    public class CuentaController(ICuentaService cuentaService, IOperacionService operacionService) : ControllerBase
    {
        [HttpGet]
        [Route("{numeroDeTarjeta}/saldo")]
        public IActionResult GetSaldo(string numeroDeTarjeta)
        {
            Cuenta cuenta = cuentaService.GetByTarjeta(numeroDeTarjeta);

            if (cuenta is null)
            {
                return NotFound($"No se encontro la tarjeta {numeroDeTarjeta}.");
            }

            Operacion operacion = cuenta.Operaciones.First();

            var response = new
            {
                cuenta.Usuario.NombreDeUsuario,
                cuenta.NumeroDeCuenta,
                operacion.SaldoActual,
                operacion.UltimaExtraccion
            };

            return Ok(response);
        }

        [HttpPost]
        [Route("extraccion")]
        public IActionResult Extraccion(RetiroRequest request)
        {
            Cuenta cuenta = cuentaService.GetByTarjeta(request.NumeroDeTarjeta);
            if (cuenta is null)
            {
                return NotFound($"No se encontro la tarjeta {request.NumeroDeTarjeta}.");
            }

            Operacion operacion = cuenta.Operaciones.First();
            if (operacion.SaldoActual < request.Monto)
            {
                return BadRequest("Saldo insuficiente");
            }
            var saldoAnterior = operacion.SaldoActual;
            operacion.SaldoActual -= request.Monto;

            operacion.Id = Guid.NewGuid();
            operacion.UltimaExtraccion = DateTime.Now;
            operacionService.Add(operacion);

            var response = new
            {
                cuenta.Usuario.NombreDeUsuario,
                cuenta.NumeroDeCuenta,
                SaldoAnterior = saldoAnterior,
                operacion.SaldoActual
            };

            return Ok(response);
        }
    }
}
