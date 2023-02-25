using GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint;
using GoColis.Shipping.Application.Logistics.Queries.GetPickupPoint;
using GoColis.Shipping.Domain.Logistics.Dtos.Requests.PickupPoint;
using MediatR;

namespace GoColis.Shipping.Api.Logistics;

public static class PickupPointEndPoint
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {
        app.MapPost("/api/pickuppoint",
            async (CreatePickupPointDto request, IMediator _mediator) =>
            {
                var id = await _mediator.Send(new CreatePickupPointCommand(
                     request.IdSte,
                     request.Address,
                     request.Latitude,
                     request.Longitude,
                     request.FirstName,
                     request.LastName,
                     request.Email,
                     request.Phone,
                     request.Role
                     ));

                return id;

            });

        app.MapGet("/api/pickuppoint/{id}",
            async (Guid id, IMediator _mediator) =>
            {
                return await _mediator.Send(new GetPickupPointQuery(id));
            });
    }
}