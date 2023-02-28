using MediatR;
namespace GoColis.Shipping.Api.Logistics.UseCases.RemovePickupPoint;

public static class PickupPointEndPoint
{
    public static void MapRemovePickupPointEndpoints(this WebApplication app)
    {
        app.MapDelete("/api/pickuppoint/{pickuppointId}",
              async (string pickuppointId, HttpRequest req, IMediator mediatr) =>
              {
                  var request = new RemovePickupPointRequestViewModel(pickuppointId);
                  var command = request.ToDomain();
                  var Result = await mediatr.Send(command);
                  return Result.IsFailed
                      ? Results.BadRequest(Result.Errors)
                      : Results.NoContent();
              });
    }
}

