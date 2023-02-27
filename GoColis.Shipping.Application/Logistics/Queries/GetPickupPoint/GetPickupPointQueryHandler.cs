using AutoMapper;
using GoColis.Shipping.Application.Common;
using GoColis.Shipping.Application.Logistics.Dtos.PickupPoint.Requests;
using GoColis.Shipping.Application.Logistics.Interfaces;
using GoColis.Shipping.Domain.Logistics.Agregat;
using MediatR;
using Owls.ErrorOr.Core;

namespace GoColis.Shipping.Application.Logistics.Queries.GetPickupPoint
{
    public class GetPickupPointQueryHandler: RequestHandlerBase, IRequestHandler<GetPickupPointQuery, ErrorOr<GetPickupPointDto>>
    {
        private readonly IPickupPointRepository<PickupPoint> _pickupPointRepository;
        public GetPickupPointQueryHandler(IPickupPointRepository<PickupPoint> pickupPointRepository, IMapper mapper): base(mapper) 
        {
            _pickupPointRepository = pickupPointRepository;
        }

        public async Task<ErrorOr<GetPickupPointDto>> Handle(GetPickupPointQuery request, CancellationToken cancellationToken)
        {
            var model= await _pickupPointRepository.GetAsync(request.Id);

            if (model == null)
                return ErrorOr.Failure<GetPickupPointDto>(Error.NotFound("PickupPoint.NotFound", $"The requested resource ID \"{request.Id}\" was not found"));

            return Mapper.Map<GetPickupPointDto>(model);
        }
    }
}
