using Application.Features.Services.Queries.GetList;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Services.Profiles;
internal class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Service,GetListServiceResponse>().ReverseMap();
    }
}
