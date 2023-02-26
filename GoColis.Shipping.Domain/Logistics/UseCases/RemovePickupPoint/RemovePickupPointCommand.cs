using FluentResults;
using GoColis.Shipping.Domain.Logistics.Agregat;
using MediatR;
namespace GoColis.Shipping.Domain.Logistics.UseCases.RemovePickupPoint;
public class RemovePickupPointCommand : IRequest<Result>
{
    public RemovePickupPointCommand(string idPickuppoint)
    {
        IdPickuppoint = idPickuppoint;
    }

    public string IdPickuppoint { get; }

}

