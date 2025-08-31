using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Dtos.ProductCategories;

public class ProductCategoryTranslationCommandDto
{
    public Guid? Id { get; set; }
    [Required]
    public Guid CategoryId { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string LanguageKey { get; set; } = string.Empty;
}