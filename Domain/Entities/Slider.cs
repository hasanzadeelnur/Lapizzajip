using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Domain.Enums;

namespace Domain.Entities;
public class Slider : Entity<Guid>
{
    public string ImagePath { get; set; }
    public SliderType Type { get; set; }
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

    public Slider(string imagePath, SliderType type, int order, bool status) : this()
    {
        ImagePath = imagePath;
        Type = type;
        Order = order;
        Status = status;
    }
}