using Application.Models.Responses;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IOperacionService
    {
        void Add(Operacion operacion);
        OperacionResponse GetTop10(string numeroDeTarjeta, int pagina = 1);
    }
}
