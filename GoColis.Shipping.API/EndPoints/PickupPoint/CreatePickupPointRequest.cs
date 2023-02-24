namespace GoColis.Shipping.Api.EndPoints.PickupPoint;
public record CreatePickupPointRequest(string Id, string IdSte, string Address, decimal Latitude, decimal Longitude, List<Contact> Contacts);

