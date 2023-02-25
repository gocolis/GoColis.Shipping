namespace GoColis.Shipping.Domain.Logistics.Dtos.Requests.PickupPoint
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
