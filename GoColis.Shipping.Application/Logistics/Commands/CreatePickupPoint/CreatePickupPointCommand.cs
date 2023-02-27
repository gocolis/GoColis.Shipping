﻿using GoColis.Shipping.Domain.Logistics.Agregat;
using MediatR;
using Owls.ErrorOr.Core;

namespace GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint
{
    public class CreatePickupPointCommand : IRequest<ErrorOr<Guid>>
    {
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
