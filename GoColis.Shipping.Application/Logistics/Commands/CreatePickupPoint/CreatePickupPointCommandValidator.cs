using FluentValidation;

namespace GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint
{
    public class CreatePickupPointCommandValidator : AbstractValidator<CreatePickupPointCommand>
    {
        public CreatePickupPointCommandValidator()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("FirstName field shouldn't be empty");
            RuleFor(x => x.LastName).Length(0, 10).WithMessage("LastName field shouldn't be empty");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid email adress");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address field shouldn't be empty");
            RuleFor(x => x.Phone).MinimumLength(8).WithMessage("Invalid phone number");
        }
    }
}
