using FluentValidation;

namespace GoColis.Shipping.Api.Logistics.UseCases.UpdatePickupPoint;

public record UpdatePickupPointRequestViewModel(
    string IdSte,
    string Address,
    decimal Latitude,
    decimal Longitude
);

public class UpdatePickupPointRequestViewModelValidator : AbstractValidator<UpdatePickupPointRequestViewModel>
{
    public UpdatePickupPointRequestViewModelValidator()
    {
        RuleFor(x => x.Address).NotEmpty();
    }
}

