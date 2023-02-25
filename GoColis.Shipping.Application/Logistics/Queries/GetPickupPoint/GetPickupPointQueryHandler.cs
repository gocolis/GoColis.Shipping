using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Dtos.Responses.PickupPoint;
using GoColis.Shipping.Infrastructure.Logistics.Repositories;
using MediatR;

namespace GoColis.Shipping.Application.Logistics.Queries.GetPickupPoint
{
    public class GetPickupPointQueryHandler: IRequestHandler<GetPickupPointQuery, GetPickupPointDto>
    {
        private readonly IPickupPointRepository<PickupPoint> _pickupPointRepository;
        public GetPickupPointQueryHandler(IPickupPointRepository<PickupPoint> pickupPointRepository)
        {
            _pickupPointRepository = pickupPointRepository;
        }

        public async Task<GetPickupPointDto?> Handle(GetPickupPointQuery request, CancellationToken cancellationToken)
        {
            var model= await _pickupPointRepository.GetAsync(request.Id);

            return model?.MapToGetPickupPointDto();
        }
    }
}
