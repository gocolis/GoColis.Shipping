using FluentResults;
using GoColis.Shipping.Domain.Logistics.Agregat;
using MediatR;

namespace GoColis.Shipping.Domain.Logistics.UseCases.GetPickupPoint;

public class GetAllPickupPointsCommand : IRequest<Result<List<PickupPoint>>>
{
    public GetAllPickupPointsCommand()
    {
    }

}

