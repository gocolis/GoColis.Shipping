namespace GoColis.Shipping.Domain.Common;


public interface IRepository<TEntity> where TEntity : Entity
{
    public void Add(TEntity entity);

}


