namespace Infrastructure.Dtos.Products;

public class ProductTranslationCommandDto
{
    public Guid? Id { get; set; }
    public Guid? ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string LanguageKey { get; set; }

    public ProductTranslationCommandDto()
    {
        Id = null!;
        ProductId = null!;
        Name = string.Empty;
        Description = string.Empty;
        LanguageKey = string.Empty;
    }

    public ProductTranslationCommandDto(Guid? id, Guid? productId, string name, string description, string languageKey)
    {
        Id = id;
        ProductId = productId;
        Name = name;
        Description = description;
        LanguageKey = languageKey;
    }
}