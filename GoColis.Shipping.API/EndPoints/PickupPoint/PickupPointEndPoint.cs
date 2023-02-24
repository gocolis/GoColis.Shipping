using GoColis.Shipping.Domain;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;

namespace GoColis.Shipping.Api.EndPoints.PickupPoint;

public static class PickupPointEndPoint 
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {
        app.MapPost("/api/pickuppoint", async (CreatePickupPointRequest request, Domain.Domain.Logistics.UseCaseInputPort.ICreatePickupPoint useCase, HttpRequest httpRequest) =>
        {
            var command = new CreatePickupPointCommand(request.Id, request.IdSte, request.Address, request.Latitude, request.Longitude, request.Contacts);
            useCase.Handle(command);
            return Results.Ok();
      
        });

        /*
        app.MapGet("/api/pickuppoints", async (Domain.Domain.Logistics.UseCaseInputPort.ICreatePickupPoint useCase) =>
        {
            var pickupPoints = await useCase.Handle();
            return Results.Ok(pickupPoints);

        });
        app.MapGet("/api/pickuppoint/{id}", async () =>
        {
            var pickupPoint = await useCase.Handle(id);
            if (pickupPoint == null)
            {
                return Results.NotFount();
            }
            return Results.Ok(pickupPoint);

        });
        app.MapPut("/api/pickuppoint", async (UpdatePickupPointRequest request, Domain.Domain.Logistics.UseCaseInputPort.IUpdatePickupPoint useCase) =>
        {
            var command = new UpdatePickupPointRequest(request.Id, request.Name, request.Address, request.ContactPhone, request.ContactName, request.GpsCoordionates);
            useCase.Handle(command);
            if (result.IsSuccess)
            {
                return Results.Ok();
            }
            else
            {
                return Results.BadRequest(result.ErrorMessage);
            }
        });
        app.MapDelete("/api/pickuppoint/{id}", async (Domain.Domain.Logistics.UseCaseInputPort.ICreatePickupPoint useCase, int id) =>
        {
            var result = await useCase.Handle(id);
            if (result.IsSuccess)
            {
                return Results.Ok();
            }
            else
            {
                return Results.NotFound();
            }
        });
        */

    }
}
