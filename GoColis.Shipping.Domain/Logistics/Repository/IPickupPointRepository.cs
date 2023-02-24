using GoColis.Shipping.Domain.Common;

namespace GoColis.Shipping.Domain.Logistics.Repository;

public interface IPickupPointRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
}