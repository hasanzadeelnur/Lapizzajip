using AutoMapper;
using Domain.Entities;
using Domain.Entities.Translations;
using Infrastructure.Dtos.ContactUs;
using Infrastructure.Dtos.ProductCategories;
using Infrastructure.Dtos.Products;
using Infrastructure.Dtos.Sliders;

namespace AdminApp.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        //Products
        CreateMap<ProductCommandDto, Product>().ReverseMap();
        CreateMap<ProductCategory, ProductCategoryCommandDto>().ReverseMap();
        CreateMap<ProductTranslation, ProductTranslationCommandDto>().ReverseMap();

        //Sliders
        CreateMap<SliderCommandDto, Slider>().ReverseMap();
        CreateMap<SliderImage, SliderImageCommandDto>().ReverseMap();
        CreateMap<SliderTranslation, SliderTranslationCommandDto>().ReverseMap();

        //ContactUs
        CreateMap<ContactUsCommandDto, ContactUs>().ReverseMap();
        CreateMap<ContactUsTranslation, ContactUsTranslationCommandDto>().ReverseMap();
    }
}
