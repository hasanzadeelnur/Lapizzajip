using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Domain.Entities;

public class ProductCategory : Entity<Guid>
{
    public int Order { get; set; }
    public int SpecialOrder { get; set; }
    public bool Status { get; set; }

    public virtual ICollection<ProductCategoryTranslation> Translations { get; set; }
    public virtual ICollection<Product> Products { get; set; }

    public ProductCategory()
    {
        Translations = [];
        Products = [];
    }

    public ProductCategory(int order, int specialOrder, bool status) : this()
    {
        Order = order;
        SpecialOrder = specialOrder;
        Status = status;
    }
}
