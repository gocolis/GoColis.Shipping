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