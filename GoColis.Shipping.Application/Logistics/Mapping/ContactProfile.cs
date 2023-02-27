using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Entities;

namespace GoColis.Shipping.Application.Logistics.Mapping;
public class ContactProfile : AutoMapper.Profile
{
    public ContactProfile()
    {
        CreateMap<Contact, ContactEntity>()
            .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
            .ForMember(x => x.FirstName, opt => opt.MapFrom(x => x.FirstName))
            .ForMember(x => x.LastName, opt => opt.MapFrom(x => x.LastName))
            .ForMember(x => x.Phone, opt => opt.MapFrom(x => x.PhoneNumber))
            .ReverseMap()
            ;
    }
}
