using System.Linq.Expressions;

namespace CompteRendu2TP4.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly UniversityContext universityContext;
        public Repository(UniversityContext context)
        {
            this.universityContext = context;
        }
        public bool Add(TEntity entity)
        {
            try
            {
                universityContext.Set<TEntity>().Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddRange(IEnumerable<TEntity> entities)
        {
            try
            {
                universityContext.Set<TEntity>().AddRange(entities);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return universityContext.Set<TEntity>().Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return universityContext.Set<TEntity>().ToList() ;
        }

#pragma warning disable CS8603 // Existence possible d'un retour de référence null.
        public TEntity GetEntity(int id) => universityContext.Set<TEntity>().Find(id);
#pragma warning restore CS8603 // Existence possible d'un retour de référence null.

        public bool Remove(TEntity entity)
        {
            try
            {
                universityContext.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveRange(IEnumerable<TEntity> entities)
        {
            try
            {
                universityContext.Set<TEntity>().RemoveRange(entities);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }
    }
}
