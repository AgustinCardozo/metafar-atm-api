using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface ICuentaRepository : IGenericRepository<Cuenta>
    {
        Cuenta GetByTarjeta(string numeroDeTarjeta);
    }
}
