using Application.Features.ProductCategories.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System.Globalization;

namespace Application.Features.ProductCategories.Profiles;
internal class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Paginate<ProductCategory>, GetListResponse<GetListProductCategoryDto>>().ReverseMap();

        CreateMap<ProductCategory, GetListProductCategoryDto>()
            .ForMember(b => b.Name, m => m.MapFrom(b => b.Translations.FirstOrDefault(b => b.LanguageKey == CultureInfo.CurrentCulture.Name)!.Name))
            .ReverseMap();
    }
}