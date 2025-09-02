using Core.Persistence.Repositories;

namespace Domain.Entities.Translations;

public class SliderTranslation : LanguageEntity
{
    public Guid SliderId { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }

    public virtual Slider Slider { get; set; }

    public SliderTranslation()
    {
        Title = string.Empty;
        Subtitle = string.Empty;
        Slider = null!;
    }

    public SliderTranslation(Guid sliderId, string title, string subtitle) : this()
    {
        SliderId = sliderId;
        Title = title;
        Subtitle = subtitle;
    }
}
