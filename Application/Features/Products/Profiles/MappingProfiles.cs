using Application.Features.Products.Queries.GetList;
using Application.Features.Products.Queries.GetListSpeciality;
using Application.Features.Products.Queries.GetListSpecialityForCategory;
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
            .ForMember(b => b.ShortDescription, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.ShortDescription))
            .ReverseMap();

        CreateMap<Paginate<Product>, GetListResponse<GetListSpecialityProductDto>>().ReverseMap();

        CreateMap<Product, GetListSpecialityProductDto>()
            .ForMember(b => b.Name, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.Name))
            .ForMember(b => b.ShortDescription, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.ShortDescription))
            .ReverseMap();

        CreateMap<Product, GetListSpecialityForCategoryProductDto>()
            .ForMember(b => b.Name, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.Name))
            .ForMember(b => b.ShortDescription, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.ShortDescription))
            .ReverseMap();

        CreateMap<Paginate<ProductCategory>, GetListResponse<GetListSpecialityForCategoryProductCategoryDto>>().ReverseMap();

        CreateMap<ProductCategory, GetListSpecialityForCategoryProductCategoryDto>()
            .ForMember(b => b.Name, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.Name))
            .ReverseMap();
    }
}
