using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
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
