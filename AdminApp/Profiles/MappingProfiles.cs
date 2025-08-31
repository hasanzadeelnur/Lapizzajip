using AutoMapper;
using Domain.Entities;
using Domain.Entities.Translations;
using Infrastructure.Dtos.ProductCategories;
using Infrastructure.Dtos.Products;

namespace AdminApp.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        //Products
        CreateMap<ProductCommandDto, Product>().ReverseMap();
        CreateMap<ProductCategory, ProductCategoryCommandDto>().ReverseMap();
        CreateMap<ProductTranslation, ProductTranslationCommandDto>().ReverseMap();
    }
}
