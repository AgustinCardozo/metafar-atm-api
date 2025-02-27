using Application.Interfaces.Repositories;
using Common.Repositories;
using Domain.Entities;
using Infrastructure;

namespace Application.Repositories
{
    public class CuentaRepository(AtmContext context) : GenericRepository<Cuenta>(context), ICuentaRepository
    {
        private readonly AtmContext _context = context;

        public Cuenta GetByTarjeta(string numeroDeTarjeta)
        {
            return _context.Cuentas.FirstOrDefault(c => c.NumeroDeTarjeta == numeroDeTarjeta);
        }
    }
}
