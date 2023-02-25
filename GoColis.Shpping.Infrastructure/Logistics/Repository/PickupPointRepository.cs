using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Repository;
using GoColis.Shipping.Infrastructure.Common;
using GoColis.Shipping.Infrastructure.Logistics.Entities;

namespace GoColis.Shipping.Infrastructure.Logistics.Repository;

public class PickupPointRepository :  IPickupPointRepository
{
    public PickupPointRepository(DatabaseContext dbContext) 
    {
    }

    public async Task AddAsync(PickupPoint entity)
    {
        //throw new NotImplementedException();
        await Task.Delay(200);
    }
}