
using GoColis.Shipping.Api.Logistics.UseCases.GetPickupPoint;
using MediatR;
namespace GoColis.Shipping.Api.Logistics.UseCases.GetAllPickupPoints;

public static class PickupPointEndPoint
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {
        app.MapGet("/api/pickuppoints",
            async (GetAllPickupPointsRequestViewModel request, IMediator mediatr) =>
            {
                var command = request.ToDomain();
                var result = await mediatr.Send(command);
                return result.IsFailed
                    ? Results.BadRequest(result.Errors)
                    : Results.Ok(result.Value);
            });
    }
}


