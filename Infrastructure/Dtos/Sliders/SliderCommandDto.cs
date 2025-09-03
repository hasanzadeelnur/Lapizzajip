namespace Infrastructure.Dtos.Sliders;
public class SliderCommandDto
{
    public Guid? Id { get; set; }
    public string ImagePath { get; set; }
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
        int order,
        bool status,
        ICollection<SliderImageCommandDto> images,
        ICollection<SliderTranslationCommandDto> translations)
    {
        Id = id;
        ImagePath = imagePath;
        Order = order;
        Status = status;
        Images = images;
        Translations = translations;
    }
}
