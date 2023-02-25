using GoColis.Shipping.Domain.Common.ValueObjects;

namespace GoColis.Shipping.Domain.Logistics.Agregat;

public class PickupPoint
{
    public PickupPoint() { }
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
        Id = id;
        IdSte = idSte;
        Address = address;
        Contacts = new List<Contact> { contact };
        Latitude = latitude;
        Longitude = longitude;
    }

    private PickupPoint(string idSte, string address, List<Contact> contacts)
    {
        IdSte = idSte;
        Address = address;
        Contacts = contacts;
    }

    public Guid Id { get; set; }
    public string IdSte { get; set; }
    public string Address { get; set; }
    public List<Contact> Contacts { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }

    public static PickupPoint Create(string idSte, string address, Contact contact, decimal latitude, decimal longitude)
    {
        return new PickupPoint(Guid.NewGuid(), idSte, address, contact, latitude, longitude);
    }
}