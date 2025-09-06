namespace Application.Features.Products.Queries.GetListSpecialityForCategory;

public class GetListSpecialityForCategoryProductResponse
{
    public List<GetListSpecialityForCategoryProductCategoryDto> Categories { get; set; }
    public List<GetListSpecialityForCategoryProductDto> Products { get; set; }

    public GetListSpecialityForCategoryProductResponse()
    {
        Categories = [];
        Products = [];
    }

    public GetListSpecialityForCategoryProductResponse(List<GetListSpecialityForCategoryProductCategoryDto> categories, List<GetListSpecialityForCategoryProductDto> products)
    {
        Categories = categories;
        Products = products;
    }
}