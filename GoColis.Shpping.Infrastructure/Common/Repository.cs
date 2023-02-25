namespace GoColis.Shipping.Infrastructure.Common;

// TODO: Review
public abstract class Repository
{
    internal readonly DatabaseContext _dbContext;

    public Repository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
}