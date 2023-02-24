using GoColis.Shipping.Domain.Common.ValueObjects;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Repository;
using GoColis.Shipping.Domain.Logistics.UseCaseInputPort;

namespace GoColis.Shipping.Domain.Logistics.UseCases.CreatePickupPoint;

internal class CreatePickupPoint : ICreatePickupPoint
{
    private readonly UseCaseOutputPort.ICreatePickupPoint _outputPort;
    private readonly IPickupPointRepository<PickupPoint> _pickupPointRepository;

    public CreatePickupPoint(IPickupPointRepository<PickupPoint> pickupPointRepository,
        UseCaseOutputPort.ICreatePickupPoint outputPort)
    {
        _pickupPointRepository = pickupPointRepository;
        _outputPort = outputPort;
    }

    public async Task<Guid> HandleAsync(CreatePickupPointCommand command)
    {
        ArgumentNullException.ThrowIfNull(command);
        var contact = new Contact(command.FirstName,
            command.LastName,
            command.Email,
            command.Phone);

        var pickupPoint = PickupPoint.Create(command.IdSte,
            command.Address,
            contact,
            command.Latitude,
            command.Longitude);
        await _pickupPointRepository.AddAsync(pickupPoint);
        return pickupPoint.Id;
    }
}