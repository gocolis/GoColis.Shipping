using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GoColis.Shipping.Api.Logistics.UseCases.UpdatePickupPoint;
using FluentResults;
public static class PickupPointEndPoint
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {
        app.MapPost("/api/pickuppoint/update",
            async (UpdatePickupPointRequestViewModel request, IMediator mediatr) =>
            {
                var validator = new UpdatePickupPointRequestViewModelValidator();
                var validation = await validator.ValidateAsync(request);
                if (!validation.IsValid)
                    return Results.BadRequest(validation.Errors);
                var command = request.ToDomain();
                var Result = await mediatr.Send(command);
                return Result.IsFailed
                    ? Results.BadRequest(Result.Errors)
                    : Results.Created($"/api/pickuppoint/update{Result.Value}", Result.Value);
            });
    }
}