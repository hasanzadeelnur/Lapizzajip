using Core.Persistence.Repositories;

namespace Domain.Entities.Translations;

public class ProductCategoryTranslation : LanguageEntity
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }

    public virtual ProductCategory Category { get; set; }

    public ProductCategoryTranslation()
    {
        Name = string.Empty;
        Category = null!;
    }

    public ProductCategoryTranslation(Guid categoryId, string name) : this()
    {
        CategoryId = categoryId;
        Name = name;
    }
}