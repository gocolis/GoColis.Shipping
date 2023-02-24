namespace GoColis.Shipping.Domain.Domain.Logistics.Repository
{
    public abstract class Repository<TEntity> where TEntity : Entity
    {
        protected readonly DbContext DbContext;

        protected Repository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual void Add(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
            DbContext.SaveChanges();
        }
    }
}

