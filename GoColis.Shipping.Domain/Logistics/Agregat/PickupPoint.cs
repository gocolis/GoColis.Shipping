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

    private PickupPoint(Guid id, string idSte, string address, Contact contact, decimal latitude,
        decimal longitude)
    {
        new PickupPoint(id, idSte, address, new List<Contact> {contact}, latitude,
            longitude);
    }

    private PickupPoint(string idSte, string address, List<Contact> contacts)
    {
        IdSte = idSte;
        Address = address;
        Contacts = contacts;
    }

    public Guid Id { get; }
    public string IdSte { get; }
    public string Address { get; }
    public List<Contact> Contacts { get; }
    public decimal Latitude { get; }
    public decimal Longitude { get; }

    public static PickupPoint Create(string idSte, string address, Contact contact, decimal latitude,
        decimal longitude)
    {
        return new PickupPoint(Guid.NewGuid(), idSte, address, contact, latitude, longitude);
        new CreatePickupPointEvent();
    }
}