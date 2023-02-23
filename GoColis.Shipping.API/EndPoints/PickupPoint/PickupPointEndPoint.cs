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
            var command = new CreatePickupPointCommand(request.Name, request.Address, request.ContactPhone, request.ContactName, request.GpsCoordionates);
            useCase.Handle(command);
            return Results.Ok();
      
        });


        app.MapGet("", async () =>
        {

        });
        app.MapGet("", async () =>
        {

        });
        app.MapPut("", async () =>
        {

        });
        app.MapDelete("", async () =>
        {

        });
 
    }
}
