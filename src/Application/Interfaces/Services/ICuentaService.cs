using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface ICuentaService
    {
        void Add(Cuenta cuenta);
        Cuenta GetByTarjeta(string numeroDeTarjeta);
        bool IsActive(Cuenta cuenta);
        bool IsBlocked(string pin, Cuenta cuenta);
        void Update(Cuenta cuenta);
    }
}
