namespace Infrastructure.Dtos.ProductCategories;
public class ProductCategoryCommandDto
{
    public Guid? Id { get; set; }
    public int Order { get; set; }
    public int SpecialOrder { get; set; }
    public bool Status { get; set; }

    public ICollection<ProductCategoryTranslationCommandDto> Translations { get; set; }

    public ProductCategoryCommandDto()
    {
        Id = null!;
        Translations = [];
    }
    public ProductCategoryCommandDto(Guid? id, int order, int specialOrder, bool status, ICollection<ProductCategoryTranslationCommandDto> translations)
    {
        Id = id;
        Order = order;
        SpecialOrder = specialOrder;
        Status = status;
        Translations = translations;
    }
}