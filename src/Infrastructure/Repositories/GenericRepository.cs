using Application.Interfaces.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class GenericRepository<TEntity>(AtmContext _context) : IGenericRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _entity => _context.Set<TEntity>();

        public void Add(TEntity entity)
        {
            _entity.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _entity.Remove(entity);
            _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _entity.ToList();
        }

        public TEntity GetById<T>(T id)
        {
            return _entity.Find(id);
        }

        public void Update(TEntity entity)
        {
            _entity.Update(entity);
            _context.SaveChanges();
        }
    }
}
