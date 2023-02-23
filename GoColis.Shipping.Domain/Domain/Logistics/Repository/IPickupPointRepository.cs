using GoColis.Shipping.Domain.Domain.Logistics.Agregat;

namespace GoColis.Shipping.Domain.Domain.Logistics.Repository
{
    public interface IPickupPointRepository
    {
        void Add(PickupPoint pickuppoint);
    }
}