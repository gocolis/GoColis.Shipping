using GoColis.Shipping.Api.EndPoints.Logistics.UseCases.CreatePickupPoint;
using GoColis.Shipping.Domain.Logistics.UseCaseInputPort;
using Microsoft.AspNetCore.Mvc;

namespace GoColis.Shipping.Api.Logistics.UseCases.UpdatePickupPoint;

public static class PickupPointEndPoint
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {
        app.MapPut("/api/pickuppoint",
            async (UpdatePickupPointRequestViewModel request,
                IUpdatePickupPoint updatePickupPoint) =>
            {
                // var command = request.ToDomain();
                //  createPickupPoint.Handle(command);
                return OkResult();
            });
    }
}