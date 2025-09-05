namespace Application.Features.Services.Queries.GetList;

public class GetListServiceResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public string ImagePath { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public GetListServiceResponse()
    {
        Title = string.Empty;
        Subtitle = string.Empty;
        ImagePath = string.Empty;
    }

    public GetListServiceResponse(Guid id, string title, string subtitle, string imagePath, int order, bool status)
    {
        Id = id;
        Title = title;
        Subtitle = subtitle;
        ImagePath = imagePath;
        Order = order;
        Status = status;
    }
}
