namespace GoColis.Shipping.Infrastructure.Common;

public interface IRepository<TEntity> where TEntity : class
{
    public Task AddAsync(TEntity entity);

    public Task<TEntity> GetAsync(Guid id);
}