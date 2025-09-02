using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Service : LanguageEntity
{
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public string ImagePath { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }

    public Service()
    {
        Title = string.Empty;
        Subtitle = string.Empty;
        ImagePath = string.Empty;
        Order = 1;
    }

    public Service(Guid id, string title, string subtitle, string imagePath, int order, bool status)
    {
        Id = id;
        Title = title;
        Subtitle = subtitle;
        ImagePath = imagePath;
        Order = order;
        Status = status;
    }
}
