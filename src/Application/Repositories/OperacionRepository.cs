using Application.Interfaces.Repositories;
using Common.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Application.Repositories
{
    public class OperacionRepository(AtmContext _context) : GenericRepository<Operacion>(_context), IOperacionRepository
    {
    }
}
