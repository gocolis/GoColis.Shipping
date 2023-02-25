using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Dtos.Responses.PickupPoint;

namespace GoColis.Shipping.Application.Logistics.Queries.GetPickupPoint
{
    public static class MapperExtensions
    {
        public static GetPickupPointDto MapToGetPickupPointDto(this PickupPoint pickupPoint)
        {
           return new GetPickupPointDto(
               pickupPoint.Id,
                pickupPoint.IdSte,
                pickupPoint.Address,
                pickupPoint.Latitude,
                pickupPoint.Longitude,
                pickupPoint.Contacts?.FirstOrDefault()?.firstName,
                pickupPoint.Contacts?.FirstOrDefault()?.lastName,
                pickupPoint.Contacts?.FirstOrDefault()?.email,
                pickupPoint.Contacts?.FirstOrDefault()?.phoneNumber,
                null);
            
        }
    }
}
