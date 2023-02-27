namespace GoColis.Shipping.Application.Logistics.Dtos.PickupPoint.Requests
{
    public class GetPickupPointDto
    {
        public Guid Id { get; set; }
        public string IdSte { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
    }
}
