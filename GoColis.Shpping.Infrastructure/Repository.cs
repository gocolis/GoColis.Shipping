namespace GoColis.Shpping.Infrastructure;

// TODO: Review
public abstract class Repository<TEntity> where TEntity : Entity
{

    private readonly DatabaseContext _dbContext;

    public Repository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(TEntity entity)
    {
        _dbContext.Add<TEntity>(entity);
        _dbContext.SaveChanges();
    }
}

    