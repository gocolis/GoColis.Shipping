namespace GoColis.Shipping.Infrastructure.Common;

// TODO: Review
public abstract class Repository<TEntity> where TEntity : Entity
{
    private readonly DatabaseContext _dbContext;

    public Repository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(TEntity entity)
    {
        _dbContext.Add(entity);
        await _dbContext.SaveChangesAsync();
    }
}