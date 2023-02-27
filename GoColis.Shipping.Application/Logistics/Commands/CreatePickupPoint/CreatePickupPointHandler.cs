using FluentValidation;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Application.Logistics.Interfaces;
using MediatR;
using Owls.ErrorOr.Core;
using GoColis.Shipping.Application.Common;
using AutoMapper;

namespace GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint
{
    public class CreatePickupPointHandler : RequestHandlerBase, IRequestHandler<CreatePickupPointCommand, ErrorOr<Guid>>
    {
        private readonly IPickupPointRepository<PickupPoint> _pickupPointRepository;
        private readonly IValidator<CreatePickupPointCommand> _validator;
        public CreatePickupPointHandler(IPickupPointRepository<PickupPoint> pickupPointRepository, IValidator<CreatePickupPointCommand> validator, IMapper mapper):base (mapper)
        {
            _pickupPointRepository = pickupPointRepository;
            _validator = validator;
        }

        public async Task<ErrorOr<Guid>> Handle(CreatePickupPointCommand request, CancellationToken cancellationToken)
        {
            var validation = _validator.Validate(request);

            if (!validation.IsValid)
                return ErrorOr.Failure<Guid>(Error.Validation("PickupPoint.Validation", validation.Errors.FirstOrDefault()?.ErrorMessage));

            var pickupPoint = Mapper.Map<PickupPoint>(request);

            try
            {
                await _pickupPointRepository.AddAsync(pickupPoint);
            }
            catch (Exception ex)
            {
                return ErrorOr.Failure<Guid>(Error.Unexpected("PickupPoint.Unexpected", ex.Message));
            }

            return pickupPoint.Id;
        }
    }
}
