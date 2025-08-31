namespace Infrastructure.Dtos.Products;
public class ProductCommandDto
{
    public Guid? Id { get; set; }
    public Guid CategoryId { get; set; }
    public string ImagePath { get; set; }
    public double? Price { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public ICollection<ProductTranslationCommandDto> Translations { get; set; }

    public ProductCommandDto()
    {
        Id = null!;
        ImagePath = string.Empty;
        Price = null!;
        Translations = [];
    }

    public ProductCommandDto(Guid? id, Guid categoryId, string imagePath, double? price, int order, bool status) : this()
    {
        Id = id;
        CategoryId = categoryId;
        ImagePath = imagePath;
        Price = price;
        Order = order;
        Status = status;
    }
}