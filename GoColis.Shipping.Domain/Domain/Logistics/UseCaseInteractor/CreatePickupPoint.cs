using GoColis.Shipping.Domain.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Domain.Logistics.Repository;
using GoColis.Shipping.Domain.Domain.Logistics.UseCaseInputPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoColis.Shipping.Domain.Domain.Logistics.UseCaseInteractor
{
    internal class CreatePickupPoint : ICreatePickupPoint
    {
        private readonly IPickupPointRepository  _pickupPointRepository;

        public CreatePickupPoint(IPickupPointRepository pickupPointRepository)
        {
            _pickupPointRepository = pickupPointRepository;
        }

        public void Handle(CreatePickupPointCommand command)
        {
           var pickuppoint = PickupPoint.Create(command.Name, command.Address, command.ContactName, command.ContactPhone, command.GpsCoordionates);
            _pickupPointRepository.Add(pickuppoint);
            
        }
    }

}
