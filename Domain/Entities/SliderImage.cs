using Core.Persistence.Repositories;

namespace Domain.Entities;

public class SliderImage : Entity<Guid>
{
    public Guid SliderId { get; set; }
    public string ImagePath { get; set; }
    public int Order { get; set; }

    public virtual Slider Slider { get; set; }

    public SliderImage()
    {
        ImagePath = string.Empty;
        Order = 1;
        Slider = null!;
    }

    public SliderImage(Guid sliderId, string imagePath, int order) : this()
    {
        SliderId = sliderId;
        ImagePath = imagePath;
        Order = order;
    }
}