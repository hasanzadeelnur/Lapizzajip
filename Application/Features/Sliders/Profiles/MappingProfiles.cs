using Application.Features.Sliders.Queries.GetList;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Sliders.Profiles;
internal class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Slider,GetListSliderResponse>().ReverseMap();
    }
}
