using FluentResults;
using MediatR;

namespace GoColis.Shipping.Domain.Logistics.UseCases.CreatePickupPoint;

public class CreatePickupPointCommand : IRequest<Result<Guid>>
{
    public CreatePickupPointCommand(string idSte, string address, decimal latitude, decimal longitude, string firstName,
        string lastName, string email, string phone, string role)
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

    public string IdSte { get; }
    public string Address { get; }
    public decimal Latitude { get; }
    public decimal Longitude { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string Phone { get; }
    public string Role { get; }
}