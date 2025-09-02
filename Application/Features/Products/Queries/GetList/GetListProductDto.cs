namespace Application.Features.Products.Queries.GetList;

public class GetListProductDto
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string ImagePath { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }

    public GetListProductDto()
    {
        ImagePath = string.Empty;
        Name = string.Empty;
        ShortDescription = string.Empty;
        Description = string.Empty;
    }

    public GetListProductDto(Guid id, Guid categoryId, string imagePath, string name, string shortDescription, string description, double price, int order, bool status, DateTime createdDate)
    {
        Id = id;
        CategoryId = categoryId;
        ImagePath = imagePath;
        Name = name;
        ShortDescription = shortDescription;
        Description = description;
        Price = price;
        Order = order;
        Status = status;
        CreatedDate = createdDate;
    }
}