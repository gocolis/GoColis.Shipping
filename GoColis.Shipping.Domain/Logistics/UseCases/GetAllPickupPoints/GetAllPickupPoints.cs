using FluentResults;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Repository;
using MediatR;
namespace GoColis.Shipping.Domain.Logistics.UseCases.GetPickupPoint;

public class GetAllPickupPoints : IRequestHandler<GetAllPickupPointsCommand, Result<List<PickupPoint>>>
{

    private readonly IPickupPointRepository _pickupPointRepository;

    public GetAllPickupPoints(IPickupPointRepository pickupPointRepository)
    {
        _pickupPointRepository = pickupPointRepository;
    }
    public async Task<Result<List<PickupPoint>>> Handle(GetAllPickupPointsCommand command, CancellationToken cancellationToken)
    {
        var pickupPoints = await _pickupPointRepository.GetAllAsync();

        if (pickupPoints == null || pickupPoints.Count = 0)
        {
            return Result.Fail<List<PickupPoint>>("No pickup points found");
        }

        return Result.Ok(pickupPoints);
    }
}
