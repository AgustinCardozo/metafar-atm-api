using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class OperacionRepository(AtmContext _context) : GenericRepository<Operacion>(_context), IOperacionRepository
    {
    }
}
