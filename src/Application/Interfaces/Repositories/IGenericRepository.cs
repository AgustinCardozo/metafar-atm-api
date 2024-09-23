namespace Application.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);
        public void Delete(TEntity entity);
        public void Update(TEntity entity);
        public List<TEntity> GetAll();
        public TEntity GetById<T>(T id);
    }
}
