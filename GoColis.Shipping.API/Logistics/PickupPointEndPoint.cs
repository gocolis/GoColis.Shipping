using AutoMapper;
using GoColis.Shipping.Api.Extensions;
using GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint;
using GoColis.Shipping.Application.Logistics.Dtos.PickupPoint.Responses;
using GoColis.Shipping.Application.Logistics.Queries.GetPickupPoint;
using MediatR;
using Owls.ErrorOr.Core;

namespace GoColis.Shipping.Api.Logistics;

public static class PickupPointEndPoint
{
    public static void MapPickupPointEndpoints(this WebApplication app)
    {

        app.MapPost("/api/pickuppoint",
            async (CreatePickupPointDto request, IMediator _mediator, ILogger<CreatePickupPointCommand> _logger, IMapper _mapper) =>
            {
                var result = _mediator.Send(_mapper.Map<CreatePickupPointCommand>(request));

                return await result.Match(
                    success => Results.Created($"/api/pickuppoint/{success}", success),
                    failed => failed.ToResult(_logger)
                    );

            });

        app.MapGet("/api/pickuppoint/{id}",
            async (Guid id, IMediator _mediator, ILogger<GetPickupPointQuery> _logger) =>
            {
                var result = _mediator.Send(new GetPickupPointQuery(id));

                return await result.Match(
                    success => Results.Ok(success),
                    failed => failed.ToResult(_logger)
                    );
            });
    }
}