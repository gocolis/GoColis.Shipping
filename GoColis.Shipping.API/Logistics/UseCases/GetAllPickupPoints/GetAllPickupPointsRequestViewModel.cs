using FluentValidation;
using GoColis.Shipping.Api.Logistics.UseCases.CreatePickupPoint;

namespace GoColis.Shipping.Api.Logistics.UseCases.GetPickupPoint;
public record GetAllPickupPointsRequestViewModel();

public class GetAllPickupPointRequestViewModelValidator : AbstractValidator<GetAllPickupPointsRequestViewModel>
{
    public GetAllPickupPointRequestViewModelValidator()
    {

    }
}


