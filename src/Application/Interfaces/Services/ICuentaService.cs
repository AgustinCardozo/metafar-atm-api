using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface ICuentaService
    {
        void Add(Cuenta cuenta);
        Cuenta GetByTarjeta(string numeroDeTarjeta);
        bool Validate(int pin, Cuenta cuenta);
    }
}
