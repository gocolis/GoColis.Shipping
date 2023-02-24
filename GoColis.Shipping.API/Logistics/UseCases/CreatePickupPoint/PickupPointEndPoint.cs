using GoColis.Shipping.Domain.Logistics.UseCaseInputPort;

namespace GoColis.Shipping.Api.Logistics.UseCases.CreatePickupPoint;

public static class PickupPointEndPoint
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {
        app.MapPost("/api/pickuppoint",
            async (CreatePickupPointRequestViewModel request, ICreatePickupOutputApiPresenter outputPort,
                ICreatePickupPoint createPickupPoint) =>
            {
                var command = request.ToDomain();
                var Result = createPickupPoint.Handle(command);
                if (Result.Success)
                    return OkResult();
            });
    }
}