using Core.Persistence.Repositories;

namespace Domain.Entities.Translations;
public class ProductTranslation : LanguageEntity
{
    public Guid ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual Product Product { get; set; }

    public ProductTranslation()
    {
        Name = string.Empty;
        Description = string.Empty;
        Product = null!;
    }

    public ProductTranslation(Guid productId, string name, string description) : this()
    {
        ProductId = productId;
        Name = name;
        Description = description;
    }
}
