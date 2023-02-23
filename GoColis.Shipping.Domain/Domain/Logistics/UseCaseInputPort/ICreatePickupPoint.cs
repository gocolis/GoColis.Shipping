using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GoColis.Shipping.Domain.Domain.Logistics.UseCaseInputPort
{
    public interface ICreatePickupPoint
    {
        void Handle(CreatePickupPointCommand command);

    }
}
