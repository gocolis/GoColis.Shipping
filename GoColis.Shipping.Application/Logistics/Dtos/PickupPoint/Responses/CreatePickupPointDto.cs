namespace GoColis.Shipping.Application.Logistics.Dtos.PickupPoint.Responses
{
    public record CreatePickupPointDto(
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
}
