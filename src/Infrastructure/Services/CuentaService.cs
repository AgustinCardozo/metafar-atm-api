using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;

namespace Infrastructure.Services
{
    public class CuentaService(ICuentaRepository cuentaRepo, IOperacionRepository operacionRepo, IUsuarioRepository usuarioRepo) : ICuentaService
    {
        public void Add(Cuenta cuenta)
        {
            cuentaRepo.Add(cuenta);
        }

        public Cuenta GetByTarjeta(string numeroDeTarjeta)
        {
            Cuenta cuenta = cuentaRepo.GetByTarjeta(numeroDeTarjeta);

            if(cuenta is null)
            {
                return cuenta;
            }

            cuenta.Operaciones = operacionRepo
                .GetAll()
                .Where(o => o.NumeroDeCuenta == cuenta.NumeroDeCuenta)
                .OrderByDescending(operacion => operacion.UltimaExtraccion)
                .ToList();

            cuenta.Usuario = usuarioRepo.GetById(cuenta.UsuarioId);

            return cuenta;
        }

        public bool Validate(int pin, Cuenta cuenta)
        {
            if(cuenta.Pin != pin)
            {
                cuenta.CantidadDeIntentos++;
            }
            if(cuenta.CantidadDeIntentos >= 4)
            {
                cuenta.Bloqueado = true;
            }
            return cuenta.Bloqueado;
        }
    }
}
