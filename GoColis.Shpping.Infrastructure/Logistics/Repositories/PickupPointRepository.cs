using AutoMapper;
using GoColis.Shipping.Application.Logistics.Interfaces;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Entities;
using GoColis.Shipping.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace GoColis.Shipping.Infrastructure.Logistics.Repositories;

public class PickupPointRepository : Repository, IPickupPointRepository<PickupPoint>
{
    public PickupPointRepository(DatabaseContext dbContext, IMapper mapper) : base(dbContext,mapper)
    {
    }

    public async Task AddAsync(PickupPoint entity)
    {
        //TODO: Add Mapper
        var creatDate = DateTime.UtcNow;
        var pickupPoint = Mapper.Map<PickupPointEntity>(entity);
        pickupPoint.CreatedAt= creatDate;

        await DbContext.PickupPoints.AddAsync(pickupPoint);
        DbContext.SaveChanges();
    }

    public async Task<PickupPoint> GetAsync(Guid id)
    {
        var entity = await DbContext.PickupPoints.Include(x => x.Contacts).FirstOrDefaultAsync(x => x.Id == id);

        if (entity == null)
            return default;

        return Mapper.Map<PickupPoint>(entity);
    }
}