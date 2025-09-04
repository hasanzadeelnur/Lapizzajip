using Application.Features.Sliders.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using System.Globalization;

namespace Application.Features.Sliders.Profiles;
internal class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Slider,GetListSliderDto>()
            .ForMember(b => b.Title, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.Title))
            .ForMember(b => b.Subtitle, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.Subtitle))
            .ReverseMap();
    }
}
