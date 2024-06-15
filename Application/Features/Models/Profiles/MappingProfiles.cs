using Application.Features.Models.Queries.GetList;
using AutoMapper;
using Core.Applicaton.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Models.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Model, GetListModelListItemDto>()
            .ForMember(destinationMember: m => m.BrandName, memberOptions: opt => opt.MapFrom(m => m.Brand.Name))
            .ForMember(destinationMember: m => m.FuelName, memberOptions: opt => opt.MapFrom(m => m.Fuel.Name))
            .ForMember(destinationMember: m => m.TransmissionName, memberOptions: opt => opt.MapFrom(m => m.Transmission.Name))
            .ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();
    }
}
