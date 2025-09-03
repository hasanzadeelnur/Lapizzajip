namespace Infrastructure.Dtos.Sliders;

public class SliderImageCommandDto
{
    public Guid? Id { get; set; }
    public Guid? SliderId { get; set; }
    public string ImagePath { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public SliderImageCommandDto()
    {
        Id = null!;
        SliderId = null!;
        ImagePath = string.Empty;
        Order = 1;
    }

    public SliderImageCommandDto(Guid? id, Guid? sliderId, string imagePath, int order, bool status)
    {
        Id = id;
        SliderId = sliderId;
        ImagePath = imagePath;
        Order = order;
        Status = status;
    }
}