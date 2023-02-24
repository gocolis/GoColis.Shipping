namespace GoColis.Shipping.Domain.Logistics.UseCases.UpdatePickupPoint;

public record UpdatePickupPointCommand(
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