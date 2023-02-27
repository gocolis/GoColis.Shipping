using GoColis.Shipping.Application.Common;

namespace GoColis.Shipping.Application.Logistics.Interfaces;

public interface IPickupPointRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
}