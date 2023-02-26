using FluentValidation;

namespace GoColis.Shipping.Api.Logistics.UseCases.CreatePickupPoint;

public record CreatePickupPointRequestViewModel(
    string IdSte,
    string Address,
    decimal Latitude,
    decimal Longitude,
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string Role
);

public class CreatePickupPointRequestViewModelValidator : AbstractValidator<CreatePickupPointRequestViewModel>
{
    public CreatePickupPointRequestViewModelValidator()
    {
        RuleFor(x => x.FirstName).NotNull();
        RuleFor(x => x.LastName).Length(0, 10);
        RuleFor(x => x.Email).EmailAddress();
        RuleFor(x => x.Address).NotEmpty();
        RuleFor(x => x.Phone).MinimumLength(8);

    }
}