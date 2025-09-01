using Application.Features.Products.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System.Globalization;

namespace Application.Features.Products.Profiles;
internal class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Paginate<Product>, GetListResponse<GetListProductDto>>().ReverseMap();

        CreateMap<Product, GetListProductDto>()
            .ForMember(b => b.Name, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.Name))
            .ForMember(b => b.Description, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.Description))
            .ReverseMap();
    }
}
