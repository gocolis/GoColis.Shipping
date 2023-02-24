namespace GoColis.Shipping.Api.Logistics.UseCases.UpdatePickupPoint;

public record UpdatePickupPointRequestViewModel(
    Guid Id,
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