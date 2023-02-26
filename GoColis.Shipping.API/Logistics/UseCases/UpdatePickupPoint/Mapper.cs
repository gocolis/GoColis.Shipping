using GoColis.Shipping.Domain.Logistics.UseCases.UpdatePickupPoint;
namespace GoColis.Shipping.Api.Logistics.UseCases.UpdatePickupPoint;

public static class Mapper
{
    public static UpdatePickupPointCommand ToDomain(this UpdatePickupPointRequestViewModel request)
    {
        return new UpdatePickupPointCommand(
            request.IdSte,
            request.Address,
            request.Latitude,
            request.Longitude
            );
    }

}

