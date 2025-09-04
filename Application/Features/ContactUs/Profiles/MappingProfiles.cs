using Application.Features.ContactUs.Commands.SendMessage;
using Application.Features.ContactUs.Queries.GetData;
using AutoMapper;
using Domain.Entities;
using System.Globalization;

namespace Application.Features.ContactUs.Profiles;
internal class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        //  CreateMap<SendMessageCommand, CustomerMessage>().ReverseMap();
        CreateMap<Domain.Entities.ContactUs, GetContactUsResponse>()
            .ForMember(cu => cu.WorkingHours, m => m.MapFrom(cu => cu.Translations.FirstOrDefault(t => t.LanguageKey == CultureInfo.CurrentCulture.Name)!.WorkingHours))
            .ForMember(cu => cu.Address, m => m.MapFrom(cu => cu.Translations.FirstOrDefault(t => t.LanguageKey == CultureInfo.CurrentCulture.Name)!.Address))
            .ForMember(cu => cu.Description, m => m.MapFrom(cu => cu.Translations.FirstOrDefault(t => t.LanguageKey == CultureInfo.CurrentCulture.Name)!.Description))
            .ForMember(cu => cu.MetaTitle, m => m.MapFrom(cu => cu.Translations.FirstOrDefault(t => t.LanguageKey == CultureInfo.CurrentCulture.Name)!.MetaTitle))
            .ForMember(cu => cu.MetaDescription, m => m.MapFrom(cu => cu.Translations.FirstOrDefault(t => t.LanguageKey == CultureInfo.CurrentCulture.Name)!.MetaDescription))
            .ForMember(cu => cu.MetaKeys, m => m.MapFrom(cu => cu.Translations.FirstOrDefault(t => t.LanguageKey == CultureInfo.CurrentCulture.Name)!.MetaKeys))
            .ReverseMap();
    }
}