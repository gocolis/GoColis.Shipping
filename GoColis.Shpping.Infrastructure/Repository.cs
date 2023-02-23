namespace GoColis.Shpping.Infrastructure;

// TODO: Review
public abstract class Repository<TEntity> where TEntity : Entity
{

    private readonly DatabaseContext _dbContext;

    public Repository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public void Add(TEntity entity) {
        _dbContext.Add<TEntity>(entity);
        _dbContext.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }

    public List<TEntity> GetAll()
    {
        return _dbContext.Set<TEntity>().ToList();
    }

    public TEntity Get(int id)
    {
        return _dbContext.Set<TEntity>().Find(id);
         
    }

    public void Remove(int id)
    {
        _dbContext.Set<TEntity>().Remove(id);
        _dbContext.SaveChanges();
    }
}