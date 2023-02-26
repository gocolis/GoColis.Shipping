
using MediatR;
namespace GoColis.Shipping.Api.Logistics.UseCases.RemovePickupPoint;

public static class PickupPointEndPoint
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {
        app.MapDelete("/api/pickuppoint/{pickuppointId}",
             async (RemovePickupPointRequestViewModel request, IMediator mediatr) =>
             {
                 var validator = new RemovePickupPointRequestViewModelValidator();
                 var validation = await validator.ValidateAsync(request);
                 if (!validation.IsValid)
                     return Results.BadRequest(validation.Errors);
                 var command = request.ToDomain();
                 var Result = await mediatr.Send(command);
                 return Result.IsFailed
                     ? Results.BadRequest(Result.Errors)
                     : Results.NoContent();
             });
    }
}

