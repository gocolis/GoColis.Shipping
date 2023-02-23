using GoColis.Shpping.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace GoColis.Shipping.Domain.Domain.Logistics.Repository;

// TODO: Create abstarct entity
// public abstract class Repository<TEntity> where TEntity : Entity
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
    public List<TEntity> Get()
    {
        return _dbContext.Set<TEntity>().ToList();
    }

    public TEntity GetById(int id)
    {
        return _dbContext.Set<TEntity>().FirstOrDefault(p => p.Id == id);
         
    }

    public void Remove(TEntity entity, int id)
    {
        _dbContext.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        _dbContext.SaveChanges();
    }
}