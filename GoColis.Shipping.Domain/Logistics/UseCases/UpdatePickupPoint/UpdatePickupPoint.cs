using FluentResults;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Repository;
using MediatR;
namespace GoColis.Shipping.Domain.Logistics.UseCases.UpdatePickupPoint;

public class UpdatePickupPoint : IRequestHandler<UpdatePickupPointCommand, Result<Guid>>
{
    private readonly IPickupPointRepository _pickupPointRepository;

    public UpdatePickupPoint(IPickupPointRepository pickupPointRepository)
    {
        _pickupPointRepository = pickupPointRepository;
    }

    public async Task<Result<Guid>> Handle(UpdatePickupPointCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        //correct this
        var pickupPoint = PickupPoint.Update(command.IdSte,
                 command.Address,
                 command.Latitude,
                 command.Longitude);

        await _pickupPointRepository.UpdateAsync(pickupPoint);
        return Result.Ok(pickupPoint.Id);
    }
}