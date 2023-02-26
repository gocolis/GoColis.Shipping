using FluentResults;
using MediatR;

namespace GoColis.Shipping.Domain.Logistics.UseCases.UpdatePickupPoint;

public class UpdatePickupPointCommand : IRequest<Result<Guid>>
{
    public UpdatePickupPointCommand(string idSte, string address, decimal latitude, decimal longitude)
    {
        IdSte = idSte;
        Address = address;
        Latitude = latitude;
        Longitude = longitude;
    }
    public string IdSte { get; }

    public string Address { get; }
    public decimal Latitude { get; }
    public decimal Longitude { get; }

}