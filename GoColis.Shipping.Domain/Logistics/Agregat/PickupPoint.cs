using GoColis.Shipping.Domain.Common.ValueObjects;

namespace GoColis.Shipping.Domain.Logistics.Agregat;

public class PickupPoint
{
    private PickupPoint(Guid id, string idSte, string address, List<Contact> contacts, decimal latitude,
        decimal longitude)
    {
        Id = id;
        IdSte = idSte;
        Address = address;
        Contacts = contacts;
        Latitude = latitude;
        Longitude = longitude;
    }

    public Guid Id { get; }
    public string IdSte { get; }
    public string Address { get; }
    public List<Contact> Contacts { get; }
    public decimal Latitude { get; }
    public decimal Longitude { get; }

    public static PickupPoint Create(string idSte, string address, decimal latitude,
        decimal longitude, string firstName, string lastName, string email, string phone, string role)
    {
        var contact = new Contact(firstName,
            lastName,
            email,
            phone,
            role);
        return new PickupPoint(Guid.NewGuid(), idSte, address,
            new List<Contact> {contact}, latitude, longitude);
    }
}