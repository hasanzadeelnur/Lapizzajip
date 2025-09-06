namespace Application.Features.Products.Queries.GetListSpecialityForCategory;

public class GetListSpecialityForCategoryProductDto
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string ImagePath { get; set; }
    public string SpecialImagePath { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public double Price { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }

    public GetListSpecialityForCategoryProductDto()
    {
        ImagePath = string.Empty;
        SpecialImagePath = string.Empty;
        Name = string.Empty;
        ShortDescription = string.Empty;
    }

    public GetListSpecialityForCategoryProductDto(Guid id, Guid categoryId, string imagePath, string specialImagePath, string name, string shortDescription, double price, int order, bool status, DateTime createdDate)
    {
        Id = id;
        CategoryId = categoryId;
        ImagePath = imagePath;
        SpecialImagePath = specialImagePath;
        Name = name;
        ShortDescription = shortDescription;
        Price = price;
        Order = order;
        Status = status;
        CreatedDate = createdDate;
    }
}
