namespace Infrastructure.Dtos.Sliders;
public class SliderTranslationCommandDto
{
    public Guid? Id { get; set; }
    public Guid? SliderId { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public string LanguageKey { get; set; }

    public SliderTranslationCommandDto()
    {
        Id = null!;
        SliderId = null!;
        Title = string.Empty;
        Subtitle = string.Empty;
        LanguageKey = string.Empty;
    }

    public SliderTranslationCommandDto(Guid? id, Guid? sliderId, string title, string subtitle, string languageKey)
    {
        Id = id;
        SliderId = sliderId;
        Title = title;
        Subtitle = subtitle;
        LanguageKey = languageKey;
    }
}