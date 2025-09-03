using Application.Features.AboutUs.Queries.GetData;
using AutoMapper;

namespace Application.Features.AboutUs.Profiles;
internal class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Domain.Entities.AboutUs, GetAboutUsResponse>().ReverseMap();
    }
}
