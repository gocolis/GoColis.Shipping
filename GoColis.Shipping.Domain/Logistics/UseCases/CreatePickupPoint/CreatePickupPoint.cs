using FluentResults;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Repository;
using MediatR;

namespace GoColis.Shipping.Domain.Logistics.UseCases.CreatePickupPoint;

public class CreatePickupPoint : IRequestHandler<CreatePickupPointCommand, Result<Guid>>
{
    private readonly IPickupPointRepository _pickupPointRepository;

    public CreatePickupPoint(IPickupPointRepository pickupPointRepository)
    {
        _pickupPointRepository = pickupPointRepository;
    }

    public async Task<Result<Guid>> Handle(CreatePickupPointCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);


        var pickupPoint = PickupPoint.Create(command.IdSte,
            command.Address,
            command.Latitude,
            command.Longitude,
            command.FirstName,
            command.LastName,
            command.Phone,
            command.Email,
            command.Role);

        await _pickupPointRepository.AddAsync(pickupPoint);
        return Result.Ok(pickupPoint.Id);
    }
}