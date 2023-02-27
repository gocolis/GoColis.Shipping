using GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint;
using GoColis.Shipping.Application.Logistics.Dtos.PickupPoint.Requests;
using GoColis.Shipping.Application.Logistics.Dtos.PickupPoint.Responses;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Entities;

namespace GoColis.Shipping.Application.Logistics.Mapping;
public class PickupPointProfile : AutoMapper.Profile
{
    public PickupPointProfile()
    {
        CreateMap<CreatePickupPointDto, CreatePickupPointCommand>()
            //.ForMember(x => x.IdSte, opt => opt.MapFrom(x => x.IdSte))
            //.ForMember(x => x.Address, opt => opt.MapFrom(x => x.Address))
            //.ForMember(x => x.Latitude, opt => opt.MapFrom(x => x.Latitude))
            //.ForMember(x => x.Longitude, opt => opt.MapFrom(x => x.Longitude))
            //.ForMember(x => x.FirstName, opt => opt.MapFrom(x => x.FirstName))
            //.ForMember(x => x.LastName, opt => opt.MapFrom(x => x.LastName))
            //.ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
            //.ForMember(x => x.Phone, opt => opt.MapFrom(x => x.Phone))
            //.ForMember(x => x.Role, opt => opt.MapFrom(x => x.Role))
            ;

        CreateMap<PickupPoint, GetPickupPointDto>()
            .ForMember(x => x.FirstName, opt => opt.MapFrom((src, des) => src?.Contacts?.FirstOrDefault()?.FirstName))
            .ForMember(x => x.LastName, opt => opt.MapFrom((src, des) => src?.Contacts?.FirstOrDefault()?.LastName))
            .ForMember(x => x.Email, opt => opt.MapFrom((src, des) => src?.Contacts?.FirstOrDefault()?.Email))
            .ForMember(x => x.Phone, opt => opt.MapFrom((src, des) => src?.Contacts?.FirstOrDefault()?.PhoneNumber))
            .ForMember(x => x.Role, opt => opt.Ignore())
            ;

        CreateMap<CreatePickupPointCommand, PickupPoint>()
           .ForMember(x=>x.Contacts, opt => opt.MapFrom(x => new[] { new Contact { Email=x.Email, FirstName=x.FirstName, LastName=x.LastName, PhoneNumber=x.Phone} }))
           .ForMember(x => x.Id, opt => opt.MapFrom(x => Guid.NewGuid()))
           ;

        //CreateMap<PickupPoint, GetPickupPointDto>()
        //  //.ForMember(x => x.IdSte, opt => opt.MapFrom(x => x.IdSte))
        //  //.ForMember(x => x.Address, opt => opt.MapFrom(x => x.Address))
        //  //.ForMember(x => x.Latitude, opt => opt.MapFrom(x => x.Latitude))
        //  //.ForMember(x => x.Longitude, opt => opt.MapFrom(x => x.Longitude))
        //  //.ForMember(x => x.FirstName, opt => opt.MapFrom(x => x.FirstName))
        //  //.ForMember(x => x.LastName, opt => opt.MapFrom(x => x.LastName))
        //  //.ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
        //  //.ForMember(x => x.Phone, opt => opt.MapFrom(x => x.Phone))
        //  //.ForMember(x => x.Role, opt => opt.MapFrom(x => x.Role))
        //  ;

        CreateMap<Domain.Logistics.Agregat.PickupPoint, PickupPointEntity>()
            .ForMember(x => x.Adresse, opt => opt.MapFrom(x => x.Address))
            .ForMember(x => x.CreatedBy, opt => opt.Ignore())
            .ForMember(x => x.CreatedAt, opt => opt.Ignore())
            .ForMember(x => x.Latitude, opt => opt.MapFrom(x => x.Latitude))
            .ForMember(x => x.Longitude, opt => opt.MapFrom(x => x.Longitude))
            .ForMember(x => x.UpdatedAt, opt => opt.Ignore())
            .ForMember(x => x.UpdatedBy, opt => opt.Ignore())
            .ReverseMap()
            ;
    } 
}
