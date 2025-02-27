using Application.Interfaces.Repositories;
using Common.Repositories;
using Domain.Entities;
using Infrastructure;

namespace Application.Repositories
{
    public class UsuarioRepository(AtmContext _context) : GenericRepository<Usuario>(_context), IUsuarioRepository
    {
    }
}
