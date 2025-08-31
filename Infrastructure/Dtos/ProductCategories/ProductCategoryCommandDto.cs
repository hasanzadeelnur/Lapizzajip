namespace Infrastructure.Dtos.ProductCategories;
public class ProductCategoryCommandDto
{
    public Guid? Id { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public ICollection<ProductCategoryTranslationCommandDto> Translations { get; set; } = [];
}