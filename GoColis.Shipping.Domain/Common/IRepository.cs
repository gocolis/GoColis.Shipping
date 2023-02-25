namespace GoColis.Shipping.Domain.Common;

public interface IRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity);
}