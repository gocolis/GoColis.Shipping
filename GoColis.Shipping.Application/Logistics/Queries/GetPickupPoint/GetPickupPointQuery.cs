using GoColis.Shipping.Domain.Logistics.Dtos.Responses.PickupPoint;
using MediatR;

namespace GoColis.Shipping.Application.Logistics.Queries.GetPickupPoint
{
    public class GetPickupPointQuery : IRequest<GetPickupPointDto>
    {
        public GetPickupPointQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
