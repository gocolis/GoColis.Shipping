
using GoColis.Shipping.Infrastructure.Common;

namespace GoColis.Shipping.Infrastructure.Logistics.Repositories;

public interface IPickupPointRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
}