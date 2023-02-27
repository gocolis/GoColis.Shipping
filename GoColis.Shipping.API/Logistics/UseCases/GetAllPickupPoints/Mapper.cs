
using GoColis.Shipping.Api.Logistics.UseCases.GetPickupPoint;
using GoColis.Shipping.Domain.Logistics.UseCases.GetPickupPoint;

namespace GoColis.Shipping.Api.Logistics.UseCases.GetAllPickupPoints;
public static class Mapper
{
    public static GetAllPickupPointsCommand ToDomain(this GetAllPickupPointsRequestViewModel request)
    {
        return new GetAllPickupPointsCommand();

    }
}

