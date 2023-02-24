namespace GoColis.Shipping.Domain.Logistics.UseCases.CreatePickupPoint;

public record CreatePickupPointCommand(
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