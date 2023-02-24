using GoColis.Shipping.Domain.Common.ValueObjects;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Repository;
using GoColis.Shipping.Domain.Logistics.UseCaseInputPort;
using GoColis.Shipping.Domain.Logistics.UseCases.CreatePickupPoint;

namespace GoColis.Shipping.Domain.Logistics.UseCases.UpdatePickupPoint;

internal class UpdatePickupPoint : IUpdatePickupPoint
{
    private readonly UseCaseOutputPort.ICreatePickupPoint _outputPort;
    private readonly IPickupPointRepository<PickupPoint> _pickupPointRepository;

    public UpdatePickupPoint(IPickupPointRepository<PickupPoint> pickupPointRepository,
        UseCaseOutputPort.ICreatePickupPoint outputPort)
    {
        _pickupPointRepository = pickupPointRepository;
        _outputPort = outputPort;
    }

    public void Handle(CreatePickupPointCommand command)
    {
        ArgumentNullException.ThrowIfNull(command);
        var contact = new Contact(command.FirstName,
            command.LastName,
            command.Email,
            command.Phone);

        var pickuppoint = PickupPoint.Create(command.IdSte,
            command.Address,
            contact,
            command.Latitude,
            command.Longitude);
        _pickupPointRepository.Add(pickuppoint);
        _outputPort.Success();
    }
}