using  GoColis.Shipping.Domain.Common.ValueObjects;

namespace GoColis.Shipping.Domain.Domain.Logistics.Agregat;

public class PickupPoint
{
    public Guid Id { get; private set; }
    public string IdSte { get; private set; }
    public  string  Address { get; private set; }
    public List<Contact> Contacts { get; private set; }
    public decimal Latitude { get; private set; }
    public decimal Longitude { get; private set; }

    public PickupPoint(Guid id, string idSte, string address, List<Contact> contacts, decimal latitude, decimal longitude)
    {
        Id = id;
        IdSte = idSte;
        Address = address;
        Contacts = contacts;
        Latitude = latitude;
        Longitude = longitude;
    }

    private PickupPoint() { }

    public static PickupPoint Create(string idSte, string address, List<Contact> contacts, decimal latitude, decimal longitude)
    {
        return new PickupPoint(Guid.NewGuid(), idSte, address, contacts, latitude, longitude);
    }

}
