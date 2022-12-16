using System.Linq.Expressions;

namespace CompteRendu2TP4.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetEntity(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);
        bool Add(TEntity entity);
        bool AddRange(IEnumerable<TEntity> entities);
        bool Remove(TEntity entity);
        bool RemoveRange(IEnumerable<TEntity> entities);
    }
}
