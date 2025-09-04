namespace Application.Features.Sliders.Queries.GetList;

public class GetListSliderDto
{
    public Guid Id { get; set; }
    public string ImagePath { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }
    public virtual ICollection<GetListSliderImageDto> Images { get; set; }

    public GetListSliderDto()
    {
        ImagePath = string.Empty;
        Title = string.Empty;
        Subtitle = string.Empty;
        Images = [];
    }

    public GetListSliderDto(Guid id, string imagePath, string title, string subtitle, int order, bool status, ICollection<GetListSliderImageDto> images)
    {
        Id = id;
        ImagePath = imagePath;
        Title = title;
        Subtitle = subtitle;
        Order = order;
        Status = status;
        Images = images;
    }
}
