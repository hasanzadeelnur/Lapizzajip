namespace Application.Features.Sliders.Queries.GetList;

public class GetListSliderImageDto
{
    public Guid Id { get; set; }
    public Guid SliderId { get; set; }
    public string ImagePath { get; set; }
    public int Order { get; set; }

    public GetListSliderImageDto()
    {
        ImagePath = string.Empty;
    }

    public GetListSliderImageDto(Guid id, string imagePath, int order)
    {
        Id = id;
        ImagePath = imagePath;
        Order = order;
    }
}

