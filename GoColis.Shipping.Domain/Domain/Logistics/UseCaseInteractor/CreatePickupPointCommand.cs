namespace GoColis.Shipping.Domain;
public record CreatePickupPointCommand(string Id, string IdSte, string Address, decimal Latitude, decimal Longitude, List<Contact> Contacts);


