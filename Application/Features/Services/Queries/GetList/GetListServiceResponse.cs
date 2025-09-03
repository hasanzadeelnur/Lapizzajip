namespace Application.Features.Services.Queries.GetList;

public class GetListServiceResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public string Icon { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public GetListServiceResponse()
    {
        Title = string.Empty;
        Subtitle = string.Empty;
        Icon = string.Empty;
    }

    public GetListServiceResponse(Guid id, string title, string subtitle, string icon, int order, bool status)
    {
        Id = id;
        Title = title;
        Subtitle = subtitle;
        Icon = icon;
        Order = order;
        Status = status;
    }
}
