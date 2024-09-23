using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository(AtmContext _context) : GenericRepository<Usuario>(_context), IUsuarioRepository
    {
    }
}
