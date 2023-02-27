
using GoColis.Shipping.Api.Logistics.UseCases.GetPickupPoint;
using MediatR;


namespace GoColis.Shipping.Api.Logistics.UseCases.GetAllPickupPoints;

public static class PickupPointEndPoint
{
    public static void MapGetAllPickupPointsEndpoints(this WebApplication app)
    {
        app.MapGet("/api/pickuppoints",
            async (HttpContext context, IMediator mediatr) =>
            {
                var request = new GetAllPickupPointsRequestViewModel();
                var command = request.ToDomain();
                var result = await mediatr.Send(command);
                return result.IsFailed
                    ? Results.BadRequest(result.Errors)
                    : Results.Ok(result.Value);
            });
    }
}


