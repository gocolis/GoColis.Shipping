using GoColis.Shipping.Domain.Logistics.Repository;
using GoColis.Shipping.Infrastructure.Common;
using GoColis.Shipping.Infrastructure.Logistics.Entities;

namespace GoColis.Shipping.Infrastructure.Logistics.Repository;

public class PickupPointRepository : Repository<PickupPointEntity>, IPickupPointRepository<PickupPointEntity>
{
    public PickupPointRepository(DatabaseContext dbContext) : base(dbContext)
    {
    }
}