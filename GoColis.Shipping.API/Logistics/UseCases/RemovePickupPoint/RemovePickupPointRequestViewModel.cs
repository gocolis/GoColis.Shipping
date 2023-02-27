using FluentValidation;
namespace GoColis.Shipping.Api.Logistics.UseCases.RemovePickupPoint;

    public record RemovePickupPointRequestViewModel (string pickuppointId);
    
    public class RemovePickupPointRequestViewModelValidator : AbstractValidator<RemovePickupPointRequestViewModel>
    {
        public RemovePickupPointRequestViewModelValidator()
        {
           
        }
    }

