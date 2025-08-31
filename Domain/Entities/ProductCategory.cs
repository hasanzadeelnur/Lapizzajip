using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Domain.Entities;

public class ProductCategory : Entity<Guid>
{
    public int Order { get; set; }
    public bool Status { get; set; }

    public virtual ICollection<ProductCategoryTranslation> Translations { get; set; }
    public virtual ICollection<Product> Products { get; set; }

    public ProductCategory()
    {
        Translations = [];
        Products = [];
    }

    public ProductCategory(int order, bool status) : this()
    {
        Order = order;
        Status = status;
    }
}
