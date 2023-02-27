
namespace GoColis.Shipping.Domain.Logistics.Agregat;

public class PickupPoint
{
    public Guid Id { get; set; }
    public string IdSte { get; set; }
    public string Address { get; set; }
    public List<Contact> Contacts { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}
