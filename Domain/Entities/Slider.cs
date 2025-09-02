using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Domain.Entities;
public class Slider : Entity<Guid>
{
    public string ImagePath { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public virtual ICollection<SliderTranslation> Translations { get; set; }
    public virtual ICollection<SliderImage> Images { get; set; }

    public Slider()
    {
        ImagePath = string.Empty;
        Translations = [];
        Images = [];
        Order = 1;
    }

    public Slider(string imagePath, int order, bool status) : this()
    {
        ImagePath = imagePath;
        Order = order;
        Status = status;
    }
}