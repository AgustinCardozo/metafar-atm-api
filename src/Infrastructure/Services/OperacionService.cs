using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Models.Responses;
using Domain.Entities;

namespace Infrastructure.Services
{
    public class OperacionService(IOperacionRepository operacionRepo, ICuentaService cuentaService) : IOperacionService
    {
        const int CANTIDAD_REGISTROS_POR_PAGINA = 10;

        public void Add(Operacion operacion)
        {
            operacionRepo.Add(operacion);
        }

        public OperacionResponse GetTop10(string numeroDeTarjeta, int pagina = 1)
        {
            Cuenta cuenta = cuentaService.GetByTarjeta(numeroDeTarjeta);

            if(cuenta is null)
            {
                return null;
            }

            List<Operacion> operaciones = cuenta.Operaciones
                .Skip((pagina - 1) * CANTIDAD_REGISTROS_POR_PAGINA)
                .Take(CANTIDAD_REGISTROS_POR_PAGINA)
                .ToList();

            OperacionResponse response = Convert(operaciones);
            response.NumeroDeTarjeta = numeroDeTarjeta;
            response.NumeroDeCuenta = cuenta.NumeroDeCuenta;
            response.NombreDeUsuario = cuenta.Usuario.NombreDeUsuario;

            return response;
        }

        private static OperacionResponse Convert(List<Operacion> operaciones)
        {
            OperacionResponse response = new();
            operaciones.ForEach(operacion =>
            {
                response.Operaciones.Add(new OperacionResponse.Operacion
                {
                    SaldoActual = operacion.SaldoActual,
                    UltimaExtraccion = operacion.UltimaExtraccion
                });
            });
            return response;
        }
    }
}
