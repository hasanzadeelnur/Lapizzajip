namespace Application.Features.Products.Queries.GetListSpecialityForCategory;

public class GetListSpecialityForCategoryProductCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public GetListSpecialityForCategoryProductCategoryDto()
    {
        Name = string.Empty;
    }

    public GetListSpecialityForCategoryProductCategoryDto(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
