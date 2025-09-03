namespace Application.Features.Sliders.Queries.GetList;

public class GetListSliderResponse
{
    public Guid Id { get; set; }
    public string ImagePath { get; set; }
    public string Body { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public GetListSliderResponse()
    {
        ImagePath = string.Empty;
        Body = string.Empty;
    }

    public GetListSliderResponse(Guid id, string imagePath, string body, int order, bool status)
    {
        Id = id;
        ImagePath = imagePath;
        Body = body;
        Order = order;
        Status = status;
    }
}
