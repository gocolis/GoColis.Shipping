

namespace GoColis.Shipping.Domain.Domain.Logistics.Agregat;
using  GoColis.Shipping.Domain.Common.ValueObjects;

public class PickupPoint
{
    public Guid Id { get; private set; }
    public  Address  Address { get; private set; }

    public PickupPoint(Address address, Contact contact, GpsCoordionates gpsCoordionates, Guid id)
    {
        Id = id;
        Address = address;
        Contact = contact;
        GpsCoordionates = gpsCoordionates;
    }

    public Contact Contact { get; private set; }
    public GpsCoordionates GpsCoordionates { get; private set; }

    private PickupPoint() { }

    public static PickupPoint Create(string Name, string Address, string ContactName, string ContactPhone, string GpsCoordionates) 
    {
       var Id = Guid.NewGuid();
        return new PickupPoint();
    
    }

}
