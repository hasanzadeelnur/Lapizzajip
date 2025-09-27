using Domain.Enums;

namespace Infrastructure.Dtos.Sliders;
public class SliderCommandDto
{
    public Guid? Id { get; set; }
    public string ImagePath { get; set; }
    public SliderType Type { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public ICollection<SliderImageCommandDto> Images { get; set; }
    public ICollection<SliderTranslationCommandDto> Translations { get; set; }

    public SliderCommandDto()
    {
        ImagePath = string.Empty;
        Images = [];
        Translations = [];
    }

    public SliderCommandDto(
        Guid? id,
        string imagePath,
        SliderType type,
        int order,
        bool status,
        ICollection<SliderImageCommandDto> images,
        ICollection<SliderTranslationCommandDto> translations)
    {
        Id = id;
        ImagePath = imagePath;
        Type = type;
        Order = order;
        Status = status;
        Images = images;
        Translations = translations;
    }
}
