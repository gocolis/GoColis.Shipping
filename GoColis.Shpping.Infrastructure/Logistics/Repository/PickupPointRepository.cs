using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Repository;
using GoColis.Shipping.Infrastructure.Common;
using GoColis.Shipping.Infrastructure.Logistics.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoColis.Shipping.Infrastructure.Logistics.Repository;

public class PickupPointRepository : IPickupPointRepository
{
    private readonly DatabaseContext _dbContext;
    public PickupPointRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(PickupPoint entity)
    {
        await _dbContext.PickupPoints.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
    public async Task RemoveAsync(string id)
    {
        var entity = await _dbContext.PickupPoints.FindAsync(id);
        _dbContext.PickupPoints.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
    public async Task<List<PickupPoint>> GetAllAsync()
    {
        return await _dbContext.PickupPoints.ToListAsync();
    }
}