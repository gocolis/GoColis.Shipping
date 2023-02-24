using GoColis.Shipping.Domain.Logistics.UseCases.CreatePickupPoint;

namespace GoColis.Shipping.Domain.Logistics.UseCaseInputPort;

public interface ICreatePickupPoint
{
    Task<Guid> HandleAsync(CreatePickupPointCommand command);
}