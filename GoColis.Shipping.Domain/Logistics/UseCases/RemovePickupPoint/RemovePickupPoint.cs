using FluentResults;

using GoColis.Shipping.Domain.Logistics.Repository;
using GoColis.Shipping.Domain.Logistics.UseCases.RemovePickupPoint;
using MediatR;

namespace GoColis.Shipping.Domain.Logistics.UseCases.DeletePickupPoint
{
    public class RemovePickupPoint : IRequestHandler<RemovePickupPointCommand, Result>
    {
        private readonly IPickupPointRepository _pickupPointRepository;
        public RemovePickupPoint(IPickupPointRepository pickupPointRepository)
        {
            _pickupPointRepository = pickupPointRepository;
        }
        public async Task<Result> Handle(RemovePickupPointCommand command, CancellationToken cancellationToken)
        {

            if (command.IdPickuppoint == null)
            {
                return Result.Fail($"Pickup point with ID {command.IdPickuppoint} not found.");
            }

            await _pickupPointRepository.RemoveAsync(command.IdPickuppoint);

            return Result.Ok();
        }
    }
}