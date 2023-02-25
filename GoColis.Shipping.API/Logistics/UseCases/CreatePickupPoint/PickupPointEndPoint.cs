using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GoColis.Shipping.Api.Logistics.UseCases.CreatePickupPoint;
using FluentResults;
public static class PickupPointEndPoint
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {
        app.MapPost("/api/pickuppoint",
            async (CreatePickupPointRequestViewModel request, IMediator mediatr) =>
            {
                var validator = new CreatePickupPointRequestViewModelValidator();
                var validation = await validator.ValidateAsync(request);
                if (!validation.IsValid)
                    return Results.BadRequest(validation.Errors);
                var command = request.ToDomain();
                var Result = await mediatr.Send(command);
                return Result.IsFailed 
                    ? Results.BadRequest(Result.Errors) 
                    :Results.Created($"/api/pickuppoint/{Result.Value}",Result.Value);
            });
    }
}