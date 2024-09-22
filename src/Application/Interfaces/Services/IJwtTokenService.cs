using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IJwtTokenService
    {
        string Authenticate(string numeroDeTarjeta);
    }
}
