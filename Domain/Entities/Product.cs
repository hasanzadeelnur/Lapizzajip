using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Domain.Entities;
public class Product : Entity<Guid>
{
    public Guid CategoryId { get; set; }
    public string ImagePath { get; set; }
    public double Price { get; set; }
    public int Order { get; set; }
    public int SpecialOrder { get; set; }
    public bool Status { get; set; }

    public virtual ProductCategory Category { get; set; }
    public virtual ICollection<ProductTranslation> Translations { get; set; }

    public Product()
    {
        ImagePath = string.Empty;
        Category = null!;
        Translations = [];
    }

    public Product(Guid categoryId, string imagePath, double price, int order, int specialOrder, bool status) : this()
    {
        CategoryId = categoryId;
        ImagePath = imagePath;
        Price = price;
        Order = order;
        SpecialOrder = specialOrder;
        Status = status;
    }
}
