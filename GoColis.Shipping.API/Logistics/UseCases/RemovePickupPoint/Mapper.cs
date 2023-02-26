using GoColis.Shipping.Domain.Logistics.UseCases.RemovePickupPoint;
namespace GoColis.Shipping.Api.Logistics.UseCases.RemovePickupPoint;

public static class Mapper
{
    public static RemovePickupPointCommand ToDomain(this RemovePickupPointRequestViewModel request)
    {
        return new RemovePickupPointCommand(request.pickuppointId);

    }
}


