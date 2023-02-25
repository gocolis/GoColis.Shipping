using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Infrastructure.Logistics.Repositories;
using MediatR;

namespace GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint
{
    public class CreatePickupPointHandler : IRequestHandler<CreatePickupPointCommand, Guid>
    {
        private readonly IPickupPointRepository<PickupPoint> _pickupPointRepository;
        public CreatePickupPointHandler(IPickupPointRepository<PickupPoint> pickupPointRepository)
        {
            _pickupPointRepository = pickupPointRepository;
        }

        public async Task<Guid> Handle(CreatePickupPointCommand request, CancellationToken cancellationToken)
        {
            var pickupPoint = request.CreatePickupPoint();

            //TODO: Persist the pickupPoint to database
            await _pickupPointRepository.AddAsync(pickupPoint);

            return pickupPoint.Id;

        }
    }
}
