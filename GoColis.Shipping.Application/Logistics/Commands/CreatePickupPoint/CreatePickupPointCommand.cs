using FluentResults;
using GoColis.Shipping.Domain.Logistics.Agregat;
using MediatR;

namespace GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint
{
    public class CreatePickupPointCommand : IRequest<Result<Guid>>
    {
        public CreatePickupPointCommand(
   string idSte,
   string address,
   decimal latitude,
   decimal longitude,
   string firstName,
   string lastName,
   string email,
   string phone,
   string role
)
        {
            IdSte = idSte;
            Address = address;
            Latitude = latitude;
            Longitude = longitude;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Role = role;
        }

        public string IdSte { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public PickupPoint CreatePickupPoint()
        {
            var contact = new Domain.Common.ValueObjects.Contact(FirstName, LastName, Email, Phone);

            return PickupPoint.Create(IdSte, Address, contact, Latitude, Longitude);
        }
    }
}
