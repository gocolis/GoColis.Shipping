using GoColis.Shipping.Api.Logistics.UseCases.CreatePickupPoint;
using GoColis.Shipping.Domain.Logistics.UseCases.CreatePickupPoint;

namespace GoColis.Shipping.Api.Logistics.UseCases.UpdatePickupPoint;

public static class Mapper
{
    public static CreatePickupPointCommand ToDomain(this CreatePickupPointRequestViewModel request)
    {
        return new CreatePickupPointCommand(
            request.IdSte,
            request.Address,
            request.Latitude,
            request.Longitude,
            request.FirstName,
            request.LastName,
            request.Email,
            request.Phone,
            request.Role);
    }
}