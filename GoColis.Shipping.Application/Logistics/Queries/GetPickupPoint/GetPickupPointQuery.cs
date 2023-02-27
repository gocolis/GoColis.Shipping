using GoColis.Shipping.Application.Logistics.Dtos.PickupPoint.Requests;
using MediatR;
using Owls.ErrorOr.Core;

namespace GoColis.Shipping.Application.Logistics.Queries.GetPickupPoint
{
    public class GetPickupPointQuery : IRequest<ErrorOr<GetPickupPointDto>>
    {
        public GetPickupPointQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
