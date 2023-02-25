using GoColis.Shipping.Domain.Common;
using GoColis.Shipping.Domain.Logistics.Agregat;

namespace GoColis.Shipping.Domain.Logistics.Repository;

public interface IPickupPointRepository
{
    Task AddAsync(PickupPoint entity);
}